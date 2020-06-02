namespace serialport
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.delayText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.baudRateText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.comportOpen = new System.Windows.Forms.Button();
            this.scanBTN = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.sendBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sendData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.getData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sendClear = new System.Windows.Forms.Button();
            this.getClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(90, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 22);
            this.textBox1.TabIndex = 0;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(631, 59);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 3;
            this.openFile.Text = "開啟檔案";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // delayText
            // 
            this.delayText.Location = new System.Drawing.Point(96, 89);
            this.delayText.Name = "delayText";
            this.delayText.Size = new System.Drawing.Size(132, 22);
            this.delayText.TabIndex = 4;
            this.delayText.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "檔案位置:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "延遲時間:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(234, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(17, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "BaudRate :";
            // 
            // baudRateText
            // 
            this.baudRateText.Location = new System.Drawing.Point(100, 20);
            this.baudRateText.Name = "baudRateText";
            this.baudRateText.Size = new System.Drawing.Size(132, 22);
            this.baudRateText.TabIndex = 9;
            this.baudRateText.Text = "115200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(268, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "comport :";
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(342, 22);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 20);
            this.portComboBox.TabIndex = 11;
            // 
            // comportOpen
            // 
            this.comportOpen.Location = new System.Drawing.Point(469, 21);
            this.comportOpen.Name = "comportOpen";
            this.comportOpen.Size = new System.Drawing.Size(75, 23);
            this.comportOpen.TabIndex = 12;
            this.comportOpen.Text = "開啟";
            this.comportOpen.UseVisualStyleBackColor = true;
            this.comportOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // scanBTN
            // 
            this.scanBTN.Location = new System.Drawing.Point(550, 21);
            this.scanBTN.Name = "scanBTN";
            this.scanBTN.Size = new System.Drawing.Size(75, 23);
            this.scanBTN.TabIndex = 13;
            this.scanBTN.Text = "重新掃描";
            this.scanBTN.UseVisualStyleBackColor = true;
            this.scanBTN.Click += new System.EventHandler(this.scanBTN_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // sendBTN
            // 
            this.sendBTN.Location = new System.Drawing.Point(266, 88);
            this.sendBTN.Name = "sendBTN";
            this.sendBTN.Size = new System.Drawing.Size(75, 23);
            this.sendBTN.TabIndex = 14;
            this.sendBTN.Text = "開始傳送";
            this.sendBTN.UseVisualStyleBackColor = true;
            this.sendBTN.Click += new System.EventHandler(this.sendBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sendData
            // 
            this.sendData.Location = new System.Drawing.Point(12, 143);
            this.sendData.Multiline = true;
            this.sendData.Name = "sendData";
            this.sendData.ReadOnly = true;
            this.sendData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sendData.Size = new System.Drawing.Size(873, 169);
            this.sendData.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "傳送資料";
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(12, 393);
            this.getData.Multiline = true;
            this.getData.Name = "getData";
            this.getData.ReadOnly = true;
            this.getData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.getData.Size = new System.Drawing.Size(873, 169);
            this.getData.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "接收資料";
            // 
            // sendClear
            // 
            this.sendClear.Location = new System.Drawing.Point(891, 143);
            this.sendClear.Name = "sendClear";
            this.sendClear.Size = new System.Drawing.Size(75, 23);
            this.sendClear.TabIndex = 20;
            this.sendClear.Text = "傳送清除";
            this.sendClear.UseVisualStyleBackColor = true;
            this.sendClear.Click += new System.EventHandler(this.sendClear_Click);
            // 
            // getClear
            // 
            this.getClear.Location = new System.Drawing.Point(891, 393);
            this.getClear.Name = "getClear";
            this.getClear.Size = new System.Drawing.Size(75, 23);
            this.getClear.TabIndex = 21;
            this.getClear.Text = "接收清除";
            this.getClear.UseVisualStyleBackColor = true;
            this.getClear.Click += new System.EventHandler(this.getClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 703);
            this.Controls.Add(this.getClear);
            this.Controls.Add(this.sendClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sendData);
            this.Controls.Add(this.sendBTN);
            this.Controls.Add(this.scanBTN);
            this.Controls.Add(this.comportOpen);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.baudRateText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delayText);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "serial port";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.TextBox delayText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox baudRateText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Button comportOpen;
        private System.Windows.Forms.Button scanBTN;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button sendBTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox sendData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox getData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sendClear;
        private System.Windows.Forms.Button getClear;
    }
}

