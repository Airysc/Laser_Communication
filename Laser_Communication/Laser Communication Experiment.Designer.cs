namespace Laser_Communication
{
    partial class Laser_Communication_Experiment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laser_Communication_Experiment));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_RxMessage = new System.Windows.Forms.Label();
            this.panelRx = new System.Windows.Forms.Panel();
            this.lb_Rx = new System.Windows.Forms.Label();
            this.txb_Receiver = new System.Windows.Forms.TextBox();
            this.lb_Port = new System.Windows.Forms.Label();
            this.panelTx = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txb_Transmitter = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.comboBox_ComPort = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelRx.SuspendLayout();
            this.panelTx.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(281, 442);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // lb_RxMessage
            // 
            this.lb_RxMessage.AutoSize = true;
            this.lb_RxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RxMessage.Location = new System.Drawing.Point(5, 44);
            this.lb_RxMessage.Name = "lb_RxMessage";
            this.lb_RxMessage.Size = new System.Drawing.Size(65, 25);
            this.lb_RxMessage.TabIndex = 13;
            this.lb_RxMessage.Text = "訊息：";
            // 
            // panelRx
            // 
            this.panelRx.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelRx.Controls.Add(this.txb_Receiver);
            this.panelRx.Controls.Add(this.lb_RxMessage);
            this.panelRx.Controls.Add(this.lb_Rx);
            this.panelRx.Controls.Add(this.panelTx);
            this.panelRx.Location = new System.Drawing.Point(12, 62);
            this.panelRx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRx.Name = "panelRx";
            this.panelRx.Size = new System.Drawing.Size(444, 376);
            this.panelRx.TabIndex = 11;
            // 
            // lb_Rx
            // 
            this.lb_Rx.AutoSize = true;
            this.lb_Rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Rx.Location = new System.Drawing.Point(3, 5);
            this.lb_Rx.Name = "lb_Rx";
            this.lb_Rx.Size = new System.Drawing.Size(119, 39);
            this.lb_Rx.TabIndex = 8;
            this.lb_Rx.Text = "聊天室";
            // 
            // txb_Receiver
            // 
            this.txb_Receiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txb_Receiver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txb_Receiver.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txb_Receiver.Location = new System.Drawing.Point(0, 81);
            this.txb_Receiver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Receiver.Multiline = true;
            this.txb_Receiver.Name = "txb_Receiver";
            this.txb_Receiver.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_Receiver.Size = new System.Drawing.Size(444, 217);
            this.txb_Receiver.TabIndex = 2;
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Port.Location = new System.Drawing.Point(12, 14);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(75, 25);
            this.lb_Port.TabIndex = 10;
            this.lb_Port.Text = "連接埠";
            // 
            // panelTx
            // 
            this.panelTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelTx.Controls.Add(this.txb_Transmitter);
            this.panelTx.Controls.Add(this.btnSend);
            this.panelTx.Controls.Add(this.btnClear);
            this.panelTx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTx.Location = new System.Drawing.Point(0, 298);
            this.panelTx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTx.Name = "panelTx";
            this.panelTx.Size = new System.Drawing.Size(444, 78);
            this.panelTx.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(0, 42);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(444, 36);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(349, 0);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(95, 42);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "發送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txb_Transmitter
            // 
            this.txb_Transmitter.BackColor = System.Drawing.Color.Gainsboro;
            this.txb_Transmitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_Transmitter.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txb_Transmitter.Location = new System.Drawing.Point(0, 0);
            this.txb_Transmitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Transmitter.Multiline = true;
            this.txb_Transmitter.Name = "txb_Transmitter";
            this.txb_Transmitter.Size = new System.Drawing.Size(349, 42);
            this.txb_Transmitter.TabIndex = 1;
            this.txb_Transmitter.TextChanged += new System.EventHandler(this.txb_Transmitter_TextChanged);
            this.txb_Transmitter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Transmitter_KeyDown);
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(333, 6);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(108, 36);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "連線";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // comboBox_ComPort
            // 
            this.comboBox_ComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ComPort.FormattingEnabled = true;
            this.comboBox_ComPort.Location = new System.Drawing.Point(99, 11);
            this.comboBox_ComPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_ComPort.Name = "comboBox_ComPort";
            this.comboBox_ComPort.Size = new System.Drawing.Size(214, 28);
            this.comboBox_ComPort.TabIndex = 5;
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lb_Port);
            this.panel1.Controls.Add(this.comboBox_ComPort);
            this.panel1.Controls.Add(this.btn_Connect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 56);
            this.panel1.TabIndex = 13;
            // 
            // Laser_Communication_Experiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelRx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Laser_Communication_Experiment";
            this.Text = "Laser Communication Experiment - BaseTech";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Laser_Communication_Experiment_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelRx.ResumeLayout(false);
            this.panelRx.PerformLayout();
            this.panelTx.ResumeLayout(false);
            this.panelTx.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_RxMessage;
        private System.Windows.Forms.Panel panelRx;
        private System.Windows.Forms.Label lb_Rx;
        private System.Windows.Forms.TextBox txb_Receiver;
        private System.Windows.Forms.Label lb_Port;
        private System.Windows.Forms.Panel panelTx;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.ComboBox comboBox_ComPort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txb_Transmitter;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
    }
}

