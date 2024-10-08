﻿namespace PLC_DBW_Dynamic_Curve
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.finishRead = new System.Windows.Forms.Button();
            this.disconnectPlc = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.connectStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectPlc = new System.Windows.Forms.Button();
            this.startRead = new System.Windows.Forms.Button();
            this.dbwValue = new System.Windows.Forms.TextBox();
            this.dbwNum = new System.Windows.Forms.TextBox();
            this.dbNum = new System.Windows.Forms.TextBox();
            this.readCycle = new System.Windows.Forms.TextBox();
            this.plcSlot = new System.Windows.Forms.TextBox();
            this.plcRack = new System.Windows.Forms.TextBox();
            this.plcIp = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yBig = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ySmall = new System.Windows.Forms.TextBox();
            this.initialDrawing = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.jianJu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.finishRead);
            this.groupBox1.Controls.Add(this.disconnectPlc);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.connectStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.connectPlc);
            this.groupBox1.Controls.Add(this.startRead);
            this.groupBox1.Controls.Add(this.dbwValue);
            this.groupBox1.Controls.Add(this.dbwNum);
            this.groupBox1.Controls.Add(this.dbNum);
            this.groupBox1.Controls.Add(this.readCycle);
            this.groupBox1.Controls.Add(this.plcSlot);
            this.groupBox1.Controls.Add(this.plcRack);
            this.groupBox1.Controls.Add(this.plcIp);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1884, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读取PLC中DBW的值";
            // 
            // finishRead
            // 
            this.finishRead.Location = new System.Drawing.Point(808, 134);
            this.finishRead.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.finishRead.Name = "finishRead";
            this.finishRead.Size = new System.Drawing.Size(114, 46);
            this.finishRead.TabIndex = 19;
            this.finishRead.Text = "暂停";
            this.finishRead.UseVisualStyleBackColor = true;
            this.finishRead.Click += new System.EventHandler(this.finishRead_Click);
            // 
            // disconnectPlc
            // 
            this.disconnectPlc.Location = new System.Drawing.Point(808, 54);
            this.disconnectPlc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.disconnectPlc.Name = "disconnectPlc";
            this.disconnectPlc.Size = new System.Drawing.Size(114, 46);
            this.disconnectPlc.TabIndex = 18;
            this.disconnectPlc.Text = "断开";
            this.disconnectPlc.UseVisualStyleBackColor = true;
            this.disconnectPlc.Click += new System.EventHandler(this.disconnectPlc_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(1460, 20);
            this.status.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(196, 35);
            this.status.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "DBW";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "DB块";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "采样周期";
            // 
            // connectStatus
            // 
            this.connectStatus.AutoSize = true;
            this.connectStatus.Location = new System.Drawing.Point(850, 64);
            this.connectStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.connectStatus.Name = "connectStatus";
            this.connectStatus.Size = new System.Drawing.Size(0, 24);
            this.connectStatus.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "插槽";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "机架号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "IP地址";
            // 
            // connectPlc
            // 
            this.connectPlc.Location = new System.Drawing.Point(682, 54);
            this.connectPlc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.connectPlc.Name = "connectPlc";
            this.connectPlc.Size = new System.Drawing.Size(114, 46);
            this.connectPlc.TabIndex = 8;
            this.connectPlc.Text = "连接";
            this.connectPlc.UseVisualStyleBackColor = true;
            this.connectPlc.Click += new System.EventHandler(this.connectPlc_Click);
            // 
            // startRead
            // 
            this.startRead.Location = new System.Drawing.Point(682, 136);
            this.startRead.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.startRead.Name = "startRead";
            this.startRead.Size = new System.Drawing.Size(114, 46);
            this.startRead.TabIndex = 7;
            this.startRead.Text = "读取";
            this.startRead.UseVisualStyleBackColor = true;
            this.startRead.Click += new System.EventHandler(this.startRead_Click);
            // 
            // dbwValue
            // 
            this.dbwValue.Location = new System.Drawing.Point(1672, 20);
            this.dbwValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dbwValue.Name = "dbwValue";
            this.dbwValue.ReadOnly = true;
            this.dbwValue.Size = new System.Drawing.Size(196, 35);
            this.dbwValue.TabIndex = 6;
            // 
            // dbwNum
            // 
            this.dbwNum.Location = new System.Drawing.Point(580, 134);
            this.dbwNum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dbwNum.Name = "dbwNum";
            this.dbwNum.Size = new System.Drawing.Size(62, 35);
            this.dbwNum.TabIndex = 5;
            // 
            // dbNum
            // 
            this.dbNum.Location = new System.Drawing.Point(432, 136);
            this.dbNum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dbNum.Name = "dbNum";
            this.dbNum.Size = new System.Drawing.Size(74, 35);
            this.dbNum.TabIndex = 4;
            // 
            // readCycle
            // 
            this.readCycle.Location = new System.Drawing.Point(150, 134);
            this.readCycle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.readCycle.Name = "readCycle";
            this.readCycle.Size = new System.Drawing.Size(120, 35);
            this.readCycle.TabIndex = 3;
            // 
            // plcSlot
            // 
            this.plcSlot.Location = new System.Drawing.Point(592, 54);
            this.plcSlot.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.plcSlot.Name = "plcSlot";
            this.plcSlot.Size = new System.Drawing.Size(74, 35);
            this.plcSlot.TabIndex = 2;
            // 
            // plcRack
            // 
            this.plcRack.Location = new System.Drawing.Point(448, 54);
            this.plcRack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.plcRack.Name = "plcRack";
            this.plcRack.Size = new System.Drawing.Size(58, 35);
            this.plcRack.TabIndex = 1;
            // 
            // plcIp
            // 
            this.plcIp.Location = new System.Drawing.Point(118, 54);
            this.plcIp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.plcIp.Name = "plcIp";
            this.plcIp.Size = new System.Drawing.Size(228, 35);
            this.plcIp.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(24, 354);
            this.chart1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chart1.Name = "chart1";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1884, 480);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yBig
            // 
            this.yBig.Location = new System.Drawing.Point(174, 248);
            this.yBig.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.yBig.Name = "yBig";
            this.yBig.Size = new System.Drawing.Size(80, 35);
            this.yBig.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 254);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Y轴最大值";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Y轴最小值";
            // 
            // ySmall
            // 
            this.ySmall.Location = new System.Drawing.Point(400, 248);
            this.ySmall.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ySmall.Name = "ySmall";
            this.ySmall.Size = new System.Drawing.Size(80, 35);
            this.ySmall.TabIndex = 22;
            // 
            // initialDrawing
            // 
            this.initialDrawing.Location = new System.Drawing.Point(779, 243);
            this.initialDrawing.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.initialDrawing.Name = "initialDrawing";
            this.initialDrawing.Size = new System.Drawing.Size(167, 46);
            this.initialDrawing.TabIndex = 20;
            this.initialDrawing.Text = "初始化图表";
            this.initialDrawing.UseVisualStyleBackColor = true;
            this.initialDrawing.Click += new System.EventHandler(this.initialDrawing_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(496, 254);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "显示间距";
            // 
            // jianJu
            // 
            this.jianJu.Location = new System.Drawing.Point(624, 248);
            this.jianJu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.jianJu.Name = "jianJu";
            this.jianJu.Size = new System.Drawing.Size(80, 35);
            this.jianJu.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1932, 900);
            this.Controls.Add(this.jianJu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.initialDrawing);
            this.Controls.Add(this.ySmall);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.yBig);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "西门子PLC数据实时曲线显示";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startRead;
        private System.Windows.Forms.TextBox dbwValue;
        private System.Windows.Forms.TextBox dbwNum;
        private System.Windows.Forms.TextBox dbNum;
        private System.Windows.Forms.TextBox readCycle;
        private System.Windows.Forms.TextBox plcSlot;
        private System.Windows.Forms.TextBox plcRack;
        private System.Windows.Forms.TextBox plcIp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button connectPlc;
        private System.Windows.Forms.Button finishRead;
        private System.Windows.Forms.Button disconnectPlc;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label connectStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yBig;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ySmall;
        private System.Windows.Forms.Button initialDrawing;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox jianJu;
    }
}

