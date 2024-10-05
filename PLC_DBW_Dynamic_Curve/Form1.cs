using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Sharp7;

namespace PLC_DBW_Dynamic_Curve
{
    public partial class Form1 : Form
    {
        private S7Client Client;
        private byte[] Buffer = new byte[65536];
        private Queue<String> dataQueue = new Queue<String>(100);
        private int num = 1;//每次添加一个数据

        public Form1()
        {
            InitializeComponent();
            Client = new S7Client();
            if (IntPtr.Size == 4)
                this.Text = this.Text + " - Running 32 bit Code";
            else
                this.Text = this.Text + " - Running 64 bit Code";

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = System.Convert.ToInt32(readCycle.Text);
      
            getDbwValues();
       
            UpdateQueueValue();
            this.chart1.Series[0].Points.Clear();
            for (int i = 0; i < dataQueue.Count; i++)
            {
                this.chart1.Series[0].Points.AddXY((i + 1), dataQueue.ElementAt(i));
            }
        }

        // 初始化图表
        private void InitChart()
        {
            //定义图表区域
            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            //定义存储和显示点的容器
            this.chart1.Series.Clear();
            Series series1 = new Series("DBW");
            series1.ChartArea = "C1";
            this.chart1.Series.Add(series1);
            //设置图表显示样式
            this.chart1.ChartAreas[0].AxisY.Minimum =Convert.ToDouble(ySmall.Text);
            this.chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(yBig.Text);
            this.chart1.ChartAreas[0].AxisX.Interval = Convert.ToDouble(jianJu.Text);
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            //设置标题
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("S01");
            this.chart1.Titles[0].Text = "DBW的值变化曲线";
            this.chart1.Titles[0].ForeColor = Color.RoyalBlue;
            this.chart1.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            //设置图表显示样式
            this.chart1.Series[0].Color = Color.Red;
        
                this.chart1.Titles[0].Text = string.Format("{0}", "DBW的值变化曲线");
                this.chart1.Series[0].ChartType = SeriesChartType.Line;
           
          
            this.chart1.Series[0].Points.Clear();
        }

        //更新队列中的值
        private void UpdateQueueValue()
        {
            if (dataQueue.Count > 100)
            {
                //先出列
                for (int i = 0; i < num; i++)
                {
                    dataQueue.Dequeue();
                }
            }
        
             
                for (int i = 0; i < num; i++)
                {
                    dataQueue.Enqueue(dbwValue.Text.ToString());
                }
            }

        private void connectPlc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(plcIp.Text))
            {
                MessageBox.Show("请输入IP地址");
                plcIp.Focus();
            }
            if (string.IsNullOrEmpty(plcRack.Text))
            {
                MessageBox.Show("请输入机架号");
                plcRack.Focus();
            }
            if (string.IsNullOrEmpty(plcSlot.Text))
            {
                MessageBox.Show("请输入插槽");
                plcSlot.Focus();
            }
            else
            {
                int Result;
                int Rack = System.Convert.ToInt32(plcRack.Text);
                int Slot = System.Convert.ToInt32(plcSlot.Text);
                Result = Client.ConnectTo(plcIp.Text, Rack, Slot);

                if (Result == 0)
                {

                    plcIp.Enabled = false;
                    plcRack.Enabled = false;
                    plcSlot.Enabled = false;
                    connectPlc.Enabled = false;
                    status.Text = "连接成功";
                    status.Enabled = false;

                }
            }
        }

        private void startRead_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(readCycle.Text))
            {
                MessageBox.Show("请输入采样周期");
                readCycle.Focus();
            }
            if (string.IsNullOrEmpty(dbNum.Text))
            {
                MessageBox.Show("请输入DB快");
                dbNum.Focus();
            }
            if (string.IsNullOrEmpty(dbwNum.Text))
            {
                MessageBox.Show("请输入DBW");
                dbwNum.Focus();
            }
           
            else
            {
                timer1.Start();
                dbNum.Enabled = false;
                dbwNum.Enabled = false;
                startRead.Enabled = false;
            }
        }


        private void getDbwValues()
        {

            byte[] Buffer = new byte[2];
        
            Client.DBRead(Convert.ToInt16(dbNum.Text.ToString()), Convert.ToInt16(dbwNum.Text.ToString()), 2, Buffer);//读取DbwNum所对应的字的值
      
            dbwValue.Text= S7.GetIntAt(Buffer, 0).ToString();

        

        }

        private void initialDrawing_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(yBig.Text))
            {

                MessageBox.Show("请输入最大值坐标");
            }
            if (string.IsNullOrEmpty(ySmall.Text))
            {

                MessageBox.Show("请输入最小值坐标");
            }
            if (string.IsNullOrEmpty(jianJu.Text))
            {

                MessageBox.Show("请输入显示间距");
            }
         
            else
            {
                InitChart();
            }

           
        }

        private void disconnectPlc_Click(object sender, EventArgs e)
        {

            Client.Disconnect();
            plcIp.Enabled = true;
            plcRack.Enabled = true;
            plcSlot.Enabled = true;
            connectPlc.Enabled = true;
            status.Text = "断开连接";
        }

        private void finishRead_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            dbNum.Enabled = true;
            dbwNum.Enabled = true;
            startRead.Enabled = true;
        }
    }
    }
