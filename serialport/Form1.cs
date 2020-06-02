using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serialport
{
    public partial class Form1 : Form
    {
        private delegate void UpdateGetData(string line);
        public Form1()
        {
            InitializeComponent();
        }
        StreamReader file;
        private void openFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = false;//該值確定是否可以選擇多個檔案
                dialog.Title = "請選擇資料夾";
                dialog.Filter = "txt(*.txt)|*.txt";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = dialog.FileName;
                    //dataIn = new MemoryStream(File.ReadAllBytes(dialog.FileName));
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comportOpen.Text == "開啟")
            {
                try
                {

                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                    }

                    //設定 Serial Port 參數
                    serialPort1.PortName = portComboBox.Text;
                    serialPort1.BaudRate = Int32.Parse(baudRateText.Text);
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;

                    if (!serialPort1.IsOpen)
                    {
                        //開啟 Serial Port
                        serialPort1.Open();
                        comportOpen.Text = "關閉";
                        portComboBox.Enabled = false;
                        baudRateText.Enabled = false;
                        scanBTN.Enabled = false;
                        sendBTN.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sendBTN.Enabled = false;
                    comportOpen.Text = "開啟";
                    portComboBox.Enabled = true;
                    baudRateText.Enabled = true;
                    scanBTN.Enabled = true;
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sendBTN.Enabled = false;
                comportOpen.Text = "開啟";
                portComboBox.Enabled = true;
                baudRateText.Enabled = true;
                scanBTN.Enabled = true;
            }
        }

        private void scanBTN_Click(object sender, EventArgs e)
        {
            portComboBox.Items.Clear();
            int itemsFound = 0;

            foreach (string s in SerialPort.GetPortNames())
            {
                portComboBox.Items.Add(s);
                itemsFound++;
            }

            if (itemsFound < 1)
                MessageBox.Show("NO ITEMS FOUND");
            else
                portComboBox.SelectedIndex = 0;

        }

        private void sendClear_Click(object sender, EventArgs e)
        {
            sendData.Text = "";

        }

        private void getClear_Click(object sender, EventArgs e)
        {
            getData.Text = "";
        }

        private void sendBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (sendBTN.Text == "開始傳送")
                {
                    file = new System.IO.StreamReader(textBox1.Text);
                    timer1.Interval = Int32.Parse(delayText.Text);
                    timer1.Enabled = true;
                    comportOpen.Enabled = false;
                    delayText.Enabled = false;
                    openFile.Enabled = false;
                    sendBTN.Text = "停止傳送";
                }
                else
                {
                    file.Close();
                    timer1.Enabled = false;
                    openFile.Enabled = true;
                    comportOpen.Enabled = true;
                    delayText.Enabled = true;
                    sendBTN.Text = "開始傳送";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                file.Close();
                timer1.Enabled = false;
                openFile.Enabled = true;
                comportOpen.Enabled = true;
                delayText.Enabled = true;
                sendBTN.Text = "開始傳送";

            }
        }
        string line;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if ((line = file.ReadLine()) != null)
            {
                serialPort1.Write(line);                
                sendData.AppendText(line);
                sendData.AppendText("\r\n");
            }
            else
            {
                sendBTN.PerformClick();
            }
        }

        private void UpdateGetDataText(string line)
        {
            getData.AppendText(line);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string InputData = serialPort1.ReadExisting();
            UpdateGetData d = new UpdateGetData(UpdateGetDataText);
            this.Invoke(d, new Object[] { InputData });

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scanBTN.PerformClick();
        }
    }
}
