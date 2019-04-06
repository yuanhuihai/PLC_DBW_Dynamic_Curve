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

        private void ReadDbw()
        {
            int DBNumber;
            int Size = 10;
            int Result;

            DBNumber = System.Convert.ToInt32(dbNum.Text);
            Result = Client.DBRead(DBNumber, 0, Size, Buffer);
            if (Result == 0)
                HexDump(Buffer, Size);

        }
        private void HexDump(byte[] bytes, int Size)
        {
            if (bytes == null)
                return;
            int bytesLength = Size;
            int bytesPerLine = 16;

            char[] HexChars = "0123456789ABCDEF".ToCharArray();

            int firstHexColumn =
                  8                   // 8 characters for the address
                + 3;                  // 3 spaces

            int firstCharColumn = firstHexColumn
                + bytesPerLine * 3       // - 2 digit for the hexadecimal value and 1 space
                + (bytesPerLine - 1) / 8 // - 1 extra space every 8 characters from the 9th
                + 2;                  // 2 spaces 

            int lineLength = firstCharColumn
                + bytesPerLine           // - characters to show the ascii value
                + Environment.NewLine.Length; // Carriage return and line feed (should normally be 2)

            char[] line = (new String(' ', lineLength - 2) + Environment.NewLine).ToCharArray();
            int expectedLines = (bytesLength + bytesPerLine - 1) / bytesPerLine;
            StringBuilder result = new StringBuilder(expectedLines * lineLength);

            for (int i = 0; i < bytesLength; i += bytesPerLine)
            {
                line[0] = HexChars[(i >> 28) & 0xF];
                line[1] = HexChars[(i >> 24) & 0xF];
                line[2] = HexChars[(i >> 20) & 0xF];
                line[3] = HexChars[(i >> 16) & 0xF];
                line[4] = HexChars[(i >> 12) & 0xF];
                line[5] = HexChars[(i >> 8) & 0xF];
                line[6] = HexChars[(i >> 4) & 0xF];
                line[7] = HexChars[(i >> 0) & 0xF];

                int hexColumn = firstHexColumn;
                int charColumn = firstCharColumn;

                for (int j = 0; j < bytesPerLine; j++)
                {
                    if (j > 0 && (j & 7) == 0) hexColumn++;
                    if (i + j >= bytesLength)
                    {
                        line[hexColumn] = ' ';
                        line[hexColumn + 1] = ' ';
                        line[charColumn] = ' ';
                    }
                    else
                    {
                        byte b = bytes[i + j];
                        line[hexColumn] = HexChars[(b >> 4) & 0xF];
                        line[hexColumn + 1] = HexChars[b & 0xF];
                        line[charColumn] = (b < 32 ? '·' : (char)b);
                    }
                    hexColumn += 3;
                    charColumn++;
                }
                result.Append(line);
            }

        }
        private void getDbwValues()
        {


            ReadDbw();
            int Pos = System.Convert.ToInt32(dbwNum.Text);
            int S7Int = S7.GetIntAt(Buffer, Pos);
            dbwValue.Text = System.Convert.ToString(S7Int);

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
