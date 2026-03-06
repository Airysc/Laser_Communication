using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Laser_Communication
{
    public partial class Laser_Communication_Experiment : Form
    {
        Thread threadSerial;
        public Laser_Communication_Experiment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_ComPort.Items.Clear(); // 清空 comboBox_ComPort
            comboBox_ComPort.Items.AddRange(SerialPort.GetPortNames()); // 獲取所有可用的serial port
            //serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                threadSerial.Abort();
                serialPort.Close();
                btn_Connect.BackColor = Color.Pink;
                return;
            }

            if (comboBox_ComPort.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose your device.", "Remind");
                return;
            }
            serialPort.Encoding = System.Text.Encoding.UTF8; // Ensure this         matches the sender's encoding
            serialPort.Handshake = Handshake.None;
            serialPort.PortName = comboBox_ComPort.Text;
            serialPort.BaudRate = 9600; // 設定波特率為 9600

            try
            {
                serialPort.Open();
                btn_Connect.BackColor = Color.LightGreen;
                threadSerial = new Thread(ThreadReadloop);
                threadSerial.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Device connection error.\n{ex.Message}", "Warning");
            }
        }
        void ThreadReadloop()
        {
            while (serialPort != null)
            {
                threadReadSerial();
                Thread.Sleep(1);
            }
            Thread.CurrentThread.Abort();
        }
        private void threadReadSerial()
        {
            string recvBuff = "";
            if (!serialPort.IsOpen) return;
            if (serialPort.BytesToRead <= 0) return;
            try
            {
                recvBuff = serialPort.ReadLine();
                
                string Display_Message = $"接收: {recvBuff}\t {DateTime.Now:HH:mm:ss} \r\n";
                UpdateReceiverTextBox(Display_Message);
            }
            catch (Exception)
            {
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Device not connected. Please connect first.", "Error");
                return;
            }

            if (string.IsNullOrEmpty(txb_Transmitter.Text))
            {
                return; // 傳送內容為空時不進行傳輸
            }

            string Tx_Message = $"發送:{txb_Transmitter.Text} \t {DateTime.Now:HH:mm:ss} \r\n";
            serialPort.WriteLine(txb_Transmitter.Text); // 傳送訊息
            txb_Receiver.Text += Tx_Message;
            txb_Receiver.SelectionStart = txb_Receiver.Text.Length;
            txb_Receiver.ScrollToCaret();
        }

        private void tmr_Com_Tick(object sender, EventArgs e)
        {
        }

        private void UpdateReceiverTextBox(string message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(UpdateReceiverTextBox), message);
            }
            else
            {
                txb_Receiver.Text += message;
                txb_Receiver.SelectionStart = txb_Receiver.Text.Length;
                txb_Receiver.ScrollToCaret();
            }
        }


        private void txb_Transmitter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Transmitter_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSend.Focus();
                btnSend_Click(sender, e);
                txb_Transmitter.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txb_Receiver.Text = "";
        }

        private void Laser_Communication_Experiment_FormClosing(object sender, FormClosingEventArgs e)
        {
            threadSerial.Abort();
        }
    }
}
