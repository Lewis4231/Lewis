﻿namespace ConveyorCs
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbSensor2_1 = new System.Windows.Forms.CheckBox();
            this.cbSensorS_1 = new System.Windows.Forms.CheckBox();
            this.cbSensor4_1 = new System.Windows.Forms.CheckBox();
            this.cbSensorS_2 = new System.Windows.Forms.CheckBox();
            this.cbSensor1_1 = new System.Windows.Forms.CheckBox();
            this.cbSensor1_2 = new System.Windows.Forms.CheckBox();
            this.cbSensor3_2 = new System.Windows.Forms.CheckBox();
            this.cbSensor3_1 = new System.Windows.Forms.CheckBox();
            this.cbSensor2_2 = new System.Windows.Forms.CheckBox();
            this.cbSensor4_2 = new System.Windows.Forms.CheckBox();
            this.btnConveyor3 = new System.Windows.Forms.Button();
            this.btnConveyorS = new System.Windows.Forms.Button();
            this.btnConveyor2 = new System.Windows.Forms.Button();
            this.btnConveyor4 = new System.Windows.Forms.Button();
            this.btnConveyor1 = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnTakeIn = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnTakeOut = new System.Windows.Forms.Button();
            this.ConvMotionProc = new System.Windows.Forms.Timer(this.components);
            this.MainSchedulerProc = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // cbSensor2_1
            // 
            this.cbSensor2_1.AutoSize = true;
            this.cbSensor2_1.Location = new System.Drawing.Point(300, 380);
            this.cbSensor2_1.Name = "cbSensor2_1";
            this.cbSensor2_1.Size = new System.Drawing.Size(42, 16);
            this.cbSensor2_1.TabIndex = 0;
            this.cbSensor2_1.Text = "2-1";
            this.cbSensor2_1.UseVisualStyleBackColor = true;
            this.cbSensor2_1.CheckedChanged += new System.EventHandler(this.cbSensor2_1_CheckedChanged);
            // 
            // cbSensorS_1
            // 
            this.cbSensorS_1.AutoSize = true;
            this.cbSensorS_1.Location = new System.Drawing.Point(175, 240);
            this.cbSensorS_1.Name = "cbSensorS_1";
            this.cbSensorS_1.Size = new System.Drawing.Size(44, 16);
            this.cbSensorS_1.TabIndex = 0;
            this.cbSensorS_1.Text = "S-1";
            this.cbSensorS_1.UseVisualStyleBackColor = true;
            this.cbSensorS_1.CheckedChanged += new System.EventHandler(this.cbSensorS_1_CheckedChanged);
            // 
            // cbSensor4_1
            // 
            this.cbSensor4_1.AutoSize = true;
            this.cbSensor4_1.Location = new System.Drawing.Point(300, 100);
            this.cbSensor4_1.Name = "cbSensor4_1";
            this.cbSensor4_1.Size = new System.Drawing.Size(42, 16);
            this.cbSensor4_1.TabIndex = 0;
            this.cbSensor4_1.Text = "4-1";
            this.cbSensor4_1.UseVisualStyleBackColor = true;
            this.cbSensor4_1.CheckedChanged += new System.EventHandler(this.cbSensor4_1_CheckedChanged);
            // 
            // cbSensorS_2
            // 
            this.cbSensorS_2.AutoSize = true;
            this.cbSensorS_2.Location = new System.Drawing.Point(175, 160);
            this.cbSensorS_2.Name = "cbSensorS_2";
            this.cbSensorS_2.Size = new System.Drawing.Size(44, 16);
            this.cbSensorS_2.TabIndex = 0;
            this.cbSensorS_2.Text = "S-2";
            this.cbSensorS_2.UseVisualStyleBackColor = true;
            this.cbSensorS_2.CheckedChanged += new System.EventHandler(this.cbSensorS_2_CheckedChanged);
            // 
            // cbSensor1_1
            // 
            this.cbSensor1_1.AutoSize = true;
            this.cbSensor1_1.Location = new System.Drawing.Point(50, 380);
            this.cbSensor1_1.Name = "cbSensor1_1";
            this.cbSensor1_1.Size = new System.Drawing.Size(42, 16);
            this.cbSensor1_1.TabIndex = 0;
            this.cbSensor1_1.Text = "1-1";
            this.cbSensor1_1.UseVisualStyleBackColor = true;
            this.cbSensor1_1.CheckedChanged += new System.EventHandler(this.cbSensor1_1_CheckedChanged);
            // 
            // cbSensor1_2
            // 
            this.cbSensor1_2.AutoSize = true;
            this.cbSensor1_2.Location = new System.Drawing.Point(50, 300);
            this.cbSensor1_2.Name = "cbSensor1_2";
            this.cbSensor1_2.Size = new System.Drawing.Size(42, 16);
            this.cbSensor1_2.TabIndex = 0;
            this.cbSensor1_2.Text = "1-2";
            this.cbSensor1_2.UseVisualStyleBackColor = true;
            this.cbSensor1_2.CheckedChanged += new System.EventHandler(this.cbSensor1_2_CheckedChanged);
            // 
            // cbSensor3_2
            // 
            this.cbSensor3_2.AutoSize = true;
            this.cbSensor3_2.Location = new System.Drawing.Point(50, 20);
            this.cbSensor3_2.Name = "cbSensor3_2";
            this.cbSensor3_2.Size = new System.Drawing.Size(42, 16);
            this.cbSensor3_2.TabIndex = 0;
            this.cbSensor3_2.Text = "3-2";
            this.cbSensor3_2.UseVisualStyleBackColor = true;
            this.cbSensor3_2.CheckedChanged += new System.EventHandler(this.cbSensor3_2_CheckedChanged);
            // 
            // cbSensor3_1
            // 
            this.cbSensor3_1.AutoSize = true;
            this.cbSensor3_1.Location = new System.Drawing.Point(50, 100);
            this.cbSensor3_1.Name = "cbSensor3_1";
            this.cbSensor3_1.Size = new System.Drawing.Size(42, 16);
            this.cbSensor3_1.TabIndex = 0;
            this.cbSensor3_1.Text = "3-1";
            this.cbSensor3_1.UseVisualStyleBackColor = true;
            this.cbSensor3_1.CheckedChanged += new System.EventHandler(this.cbSensor3_1_CheckedChanged);
            // 
            // cbSensor2_2
            // 
            this.cbSensor2_2.AutoSize = true;
            this.cbSensor2_2.Location = new System.Drawing.Point(300, 300);
            this.cbSensor2_2.Name = "cbSensor2_2";
            this.cbSensor2_2.Size = new System.Drawing.Size(42, 16);
            this.cbSensor2_2.TabIndex = 0;
            this.cbSensor2_2.Text = "2-2";
            this.cbSensor2_2.UseVisualStyleBackColor = true;
            this.cbSensor2_2.CheckedChanged += new System.EventHandler(this.cbSensor2_2_CheckedChanged);
            // 
            // cbSensor4_2
            // 
            this.cbSensor4_2.AutoSize = true;
            this.cbSensor4_2.Location = new System.Drawing.Point(300, 20);
            this.cbSensor4_2.Name = "cbSensor4_2";
            this.cbSensor4_2.Size = new System.Drawing.Size(42, 16);
            this.cbSensor4_2.TabIndex = 0;
            this.cbSensor4_2.Text = "4-2";
            this.cbSensor4_2.UseVisualStyleBackColor = true;
            this.cbSensor4_2.CheckedChanged += new System.EventHandler(this.cbSensor4_2_CheckedChanged);
            // 
            // btnConveyor3
            // 
            this.btnConveyor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConveyor3.Location = new System.Drawing.Point(110, 20);
            this.btnConveyor3.Name = "btnConveyor3";
            this.btnConveyor3.Size = new System.Drawing.Size(180, 110);
            this.btnConveyor3.TabIndex = 1;
            this.btnConveyor3.UseVisualStyleBackColor = false;
            this.btnConveyor3.Click += new System.EventHandler(this.btnConveyor3_Click);
            // 
            // btnConveyorS
            // 
            this.btnConveyorS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConveyorS.Location = new System.Drawing.Point(230, 160);
            this.btnConveyorS.Name = "btnConveyorS";
            this.btnConveyorS.Size = new System.Drawing.Size(180, 110);
            this.btnConveyorS.TabIndex = 2;
            this.btnConveyorS.UseVisualStyleBackColor = false;
            this.btnConveyorS.Click += new System.EventHandler(this.btnConveyorS_Click);
            // 
            // btnConveyor2
            // 
            this.btnConveyor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConveyor2.Location = new System.Drawing.Point(360, 300);
            this.btnConveyor2.Name = "btnConveyor2";
            this.btnConveyor2.Size = new System.Drawing.Size(180, 110);
            this.btnConveyor2.TabIndex = 3;
            this.btnConveyor2.UseVisualStyleBackColor = false;
            this.btnConveyor2.Click += new System.EventHandler(this.btnConveyor2_Click);
            // 
            // btnConveyor4
            // 
            this.btnConveyor4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConveyor4.Location = new System.Drawing.Point(360, 20);
            this.btnConveyor4.Name = "btnConveyor4";
            this.btnConveyor4.Size = new System.Drawing.Size(180, 110);
            this.btnConveyor4.TabIndex = 4;
            this.btnConveyor4.UseVisualStyleBackColor = false;
            this.btnConveyor4.Click += new System.EventHandler(this.btnConveyor4_Click);
            // 
            // btnConveyor1
            // 
            this.btnConveyor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConveyor1.Location = new System.Drawing.Point(110, 300);
            this.btnConveyor1.Name = "btnConveyor1";
            this.btnConveyor1.Size = new System.Drawing.Size(180, 110);
            this.btnConveyor1.TabIndex = 5;
            this.btnConveyor1.Text = " ";
            this.btnConveyor1.UseVisualStyleBackColor = false;
            this.btnConveyor1.Click += new System.EventHandler(this.btnConveyor1_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.White;
            this.btnAuto.Location = new System.Drawing.Point(600, 20);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(150, 90);
            this.btnAuto.TabIndex = 6;
            this.btnAuto.Text = "자동";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnTakeIn
            // 
            this.btnTakeIn.BackColor = System.Drawing.Color.White;
            this.btnTakeIn.Location = new System.Drawing.Point(600, 320);
            this.btnTakeIn.Name = "btnTakeIn";
            this.btnTakeIn.Size = new System.Drawing.Size(150, 90);
            this.btnTakeIn.TabIndex = 7;
            this.btnTakeIn.Text = "입고";
            this.btnTakeIn.UseVisualStyleBackColor = false;
            this.btnTakeIn.Click += new System.EventHandler(this.btnTakeIn_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(600, 220);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(150, 90);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "정지";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnTakeOut
            // 
            this.btnTakeOut.BackColor = System.Drawing.Color.White;
            this.btnTakeOut.Location = new System.Drawing.Point(600, 120);
            this.btnTakeOut.Name = "btnTakeOut";
            this.btnTakeOut.Size = new System.Drawing.Size(150, 90);
            this.btnTakeOut.TabIndex = 9;
            this.btnTakeOut.Text = "반출";
            this.btnTakeOut.UseVisualStyleBackColor = false;
            this.btnTakeOut.Click += new System.EventHandler(this.btnTakeOut_Click);
            // 
            // ConvMotionProc
            // 
            this.ConvMotionProc.Enabled = true;
            this.ConvMotionProc.Interval = 1000;
            this.ConvMotionProc.Tick += new System.EventHandler(this.ConvMotionProc_Tick);
            // 
            // MainSchedulerProc
            // 
            this.MainSchedulerProc.Enabled = true;
            this.MainSchedulerProc.Interval = 1000;
            this.MainSchedulerProc.Tick += new System.EventHandler(this.MainSchedulerProc_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.DataBits = 7;
            this.serialPort1.Parity = System.IO.Ports.Parity.Odd;
            this.serialPort1.PortName = "COM4";
            this.serialPort1.StopBits = System.IO.Ports.StopBits.Two;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.btnTakeOut);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTakeIn);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnConveyor1);
            this.Controls.Add(this.btnConveyor4);
            this.Controls.Add(this.btnConveyor2);
            this.Controls.Add(this.btnConveyorS);
            this.Controls.Add(this.btnConveyor3);
            this.Controls.Add(this.cbSensor4_2);
            this.Controls.Add(this.cbSensor3_1);
            this.Controls.Add(this.cbSensorS_2);
            this.Controls.Add(this.cbSensor3_2);
            this.Controls.Add(this.cbSensor2_2);
            this.Controls.Add(this.cbSensor4_1);
            this.Controls.Add(this.cbSensor1_2);
            this.Controls.Add(this.cbSensor1_1);
            this.Controls.Add(this.cbSensorS_1);
            this.Controls.Add(this.cbSensor2_1);
            this.Name = "Form1";
            this.Text = "Conveyor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSensor2_1;
        private System.Windows.Forms.CheckBox cbSensorS_1;
        private System.Windows.Forms.CheckBox cbSensor4_1;
        private System.Windows.Forms.CheckBox cbSensorS_2;
        private System.Windows.Forms.CheckBox cbSensor1_1;
        private System.Windows.Forms.CheckBox cbSensor1_2;
        private System.Windows.Forms.CheckBox cbSensor3_2;
        private System.Windows.Forms.CheckBox cbSensor3_1;
        private System.Windows.Forms.CheckBox cbSensor2_2;
        private System.Windows.Forms.CheckBox cbSensor4_2;
        private System.Windows.Forms.Button btnConveyor3;
        private System.Windows.Forms.Button btnConveyorS;
        private System.Windows.Forms.Button btnConveyor2;
        private System.Windows.Forms.Button btnConveyor4;
        private System.Windows.Forms.Button btnConveyor1;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnTakeIn;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnTakeOut;
        private System.Windows.Forms.Timer ConvMotionProc;
        private System.Windows.Forms.Timer MainSchedulerProc;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

