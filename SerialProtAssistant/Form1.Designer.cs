namespace SerialProtAssistant
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_openserialport = new Button();
            cb_dtr = new CheckBox();
            cb_rts = new CheckBox();
            cmb_stopbit = new ComboBox();
            cmb_databit = new ComboBox();
            cmb_checkbit = new ComboBox();
            cmb_baud = new ComboBox();
            cmb_port = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txt_rec_path = new TextBox();
            btn_rec_path = new Button();
            btn_rec_save = new Button();
            btn_rec_stop = new Button();
            btn_rec_clear = new Button();
            cb_rec_hex = new CheckBox();
            cb_rec_auto = new CheckBox();
            groupBox3 = new GroupBox();
            txt_send_cycle = new TextBox();
            label6 = new Label();
            txt_send_path = new TextBox();
            btn_send_openfile = new Button();
            btn_send_sendfile = new Button();
            btn_send_clear = new Button();
            btn_send = new Button();
            cb_send_hex = new CheckBox();
            cb_send_auto = new CheckBox();
            groupBox4 = new GroupBox();
            rtxt_rec = new RichTextBox();
            groupBox5 = new GroupBox();
            rtxt_send = new RichTextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            status = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            sendcount = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            reccount = new ToolStripStatusLabel();
            clearcount = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_openserialport);
            groupBox1.Controls.Add(cb_dtr);
            groupBox1.Controls.Add(cb_rts);
            groupBox1.Controls.Add(cmb_stopbit);
            groupBox1.Controls.Add(cmb_databit);
            groupBox1.Controls.Add(cmb_checkbit);
            groupBox1.Controls.Add(cmb_baud);
            groupBox1.Controls.Add(cmb_port);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "串口配置";
            // 
            // btn_openserialport
            // 
            btn_openserialport.Location = new Point(113, 220);
            btn_openserialport.Name = "btn_openserialport";
            btn_openserialport.Size = new Size(150, 64);
            btn_openserialport.TabIndex = 12;
            btn_openserialport.Text = "打开串口";
            btn_openserialport.UseVisualStyleBackColor = true;
            // 
            // cb_dtr
            // 
            cb_dtr.AutoSize = true;
            cb_dtr.Location = new Point(19, 260);
            cb_dtr.Name = "cb_dtr";
            cb_dtr.Size = new Size(58, 24);
            cb_dtr.TabIndex = 11;
            cb_dtr.Text = "DTR";
            cb_dtr.UseVisualStyleBackColor = true;
            // 
            // cb_rts
            // 
            cb_rts.AutoSize = true;
            cb_rts.Location = new Point(19, 220);
            cb_rts.Name = "cb_rts";
            cb_rts.Size = new Size(56, 24);
            cb_rts.TabIndex = 10;
            cb_rts.Text = "RTS";
            cb_rts.UseVisualStyleBackColor = true;
            // 
            // cmb_stopbit
            // 
            cmb_stopbit.FormattingEnabled = true;
            cmb_stopbit.Location = new Point(113, 176);
            cmb_stopbit.Name = "cmb_stopbit";
            cmb_stopbit.Size = new Size(150, 28);
            cmb_stopbit.TabIndex = 9;
            // 
            // cmb_databit
            // 
            cmb_databit.FormattingEnabled = true;
            cmb_databit.Location = new Point(113, 137);
            cmb_databit.Name = "cmb_databit";
            cmb_databit.Size = new Size(150, 28);
            cmb_databit.TabIndex = 8;
            // 
            // cmb_checkbit
            // 
            cmb_checkbit.FormattingEnabled = true;
            cmb_checkbit.Location = new Point(113, 98);
            cmb_checkbit.Name = "cmb_checkbit";
            cmb_checkbit.Size = new Size(150, 28);
            cmb_checkbit.TabIndex = 7;
            // 
            // cmb_baud
            // 
            cmb_baud.FormattingEnabled = true;
            cmb_baud.Location = new Point(113, 59);
            cmb_baud.Name = "cmb_baud";
            cmb_baud.Size = new Size(150, 28);
            cmb_baud.TabIndex = 6;
            // 
            // cmb_port
            // 
            cmb_port.FormattingEnabled = true;
            cmb_port.Location = new Point(113, 20);
            cmb_port.Name = "cmb_port";
            cmb_port.Size = new Size(150, 28);
            cmb_port.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 179);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "停止位";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 140);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "数据位";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 101);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "校验位";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 62);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "波特率";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "端口号";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_rec_path);
            groupBox2.Controls.Add(btn_rec_path);
            groupBox2.Controls.Add(btn_rec_save);
            groupBox2.Controls.Add(btn_rec_stop);
            groupBox2.Controls.Add(btn_rec_clear);
            groupBox2.Controls.Add(cb_rec_hex);
            groupBox2.Controls.Add(cb_rec_auto);
            groupBox2.Location = new Point(12, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 162);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "接收配置";
            // 
            // txt_rec_path
            // 
            txt_rec_path.Location = new Point(15, 126);
            txt_rec_path.Name = "txt_rec_path";
            txt_rec_path.Size = new Size(248, 27);
            txt_rec_path.TabIndex = 6;
            // 
            // btn_rec_path
            // 
            btn_rec_path.Location = new Point(15, 91);
            btn_rec_path.Name = "btn_rec_path";
            btn_rec_path.Size = new Size(87, 29);
            btn_rec_path.TabIndex = 5;
            btn_rec_path.Text = "选择文路径";
            btn_rec_path.UseVisualStyleBackColor = true;
            // 
            // btn_rec_save
            // 
            btn_rec_save.Location = new Point(113, 91);
            btn_rec_save.Name = "btn_rec_save";
            btn_rec_save.Size = new Size(150, 29);
            btn_rec_save.TabIndex = 4;
            btn_rec_save.Text = "保存数据";
            btn_rec_save.UseVisualStyleBackColor = true;
            // 
            // btn_rec_stop
            // 
            btn_rec_stop.Location = new Point(113, 56);
            btn_rec_stop.Name = "btn_rec_stop";
            btn_rec_stop.Size = new Size(150, 29);
            btn_rec_stop.TabIndex = 3;
            btn_rec_stop.Text = "暂停";
            btn_rec_stop.UseVisualStyleBackColor = true;
            // 
            // btn_rec_clear
            // 
            btn_rec_clear.Location = new Point(113, 21);
            btn_rec_clear.Name = "btn_rec_clear";
            btn_rec_clear.Size = new Size(150, 29);
            btn_rec_clear.TabIndex = 2;
            btn_rec_clear.Text = "手动清空";
            btn_rec_clear.UseVisualStyleBackColor = true;
            // 
            // cb_rec_hex
            // 
            cb_rec_hex.AutoSize = true;
            cb_rec_hex.Location = new Point(15, 56);
            cb_rec_hex.Name = "cb_rec_hex";
            cb_rec_hex.Size = new Size(88, 24);
            cb_rec_hex.TabIndex = 1;
            cb_rec_hex.Text = "十六进制";
            cb_rec_hex.UseVisualStyleBackColor = true;
            // 
            // cb_rec_auto
            // 
            cb_rec_auto.AutoSize = true;
            cb_rec_auto.Location = new Point(15, 26);
            cb_rec_auto.Name = "cb_rec_auto";
            cb_rec_auto.Size = new Size(88, 24);
            cb_rec_auto.TabIndex = 0;
            cb_rec_auto.Text = "自动清空";
            cb_rec_auto.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_send_cycle);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txt_send_path);
            groupBox3.Controls.Add(btn_send_openfile);
            groupBox3.Controls.Add(btn_send_sendfile);
            groupBox3.Controls.Add(btn_send_clear);
            groupBox3.Controls.Add(btn_send);
            groupBox3.Controls.Add(cb_send_hex);
            groupBox3.Controls.Add(cb_send_auto);
            groupBox3.Location = new Point(12, 488);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(280, 210);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "发送配置";
            // 
            // txt_send_cycle
            // 
            txt_send_cycle.Location = new Point(171, 159);
            txt_send_cycle.Name = "txt_send_cycle";
            txt_send_cycle.Size = new Size(92, 27);
            txt_send_cycle.TabIndex = 8;
            txt_send_cycle.Text = "1000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 162);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 7;
            label6.Text = "自动发送周期（ms）";
            // 
            // txt_send_path
            // 
            txt_send_path.Location = new Point(15, 126);
            txt_send_path.Name = "txt_send_path";
            txt_send_path.Size = new Size(248, 27);
            txt_send_path.TabIndex = 6;
            // 
            // btn_send_openfile
            // 
            btn_send_openfile.Location = new Point(15, 91);
            btn_send_openfile.Name = "btn_send_openfile";
            btn_send_openfile.Size = new Size(87, 29);
            btn_send_openfile.TabIndex = 5;
            btn_send_openfile.Text = "打开文件";
            btn_send_openfile.UseVisualStyleBackColor = true;
            // 
            // btn_send_sendfile
            // 
            btn_send_sendfile.Location = new Point(113, 91);
            btn_send_sendfile.Name = "btn_send_sendfile";
            btn_send_sendfile.Size = new Size(150, 29);
            btn_send_sendfile.TabIndex = 4;
            btn_send_sendfile.Text = "发送文件";
            btn_send_sendfile.UseVisualStyleBackColor = true;
            // 
            // btn_send_clear
            // 
            btn_send_clear.Location = new Point(113, 56);
            btn_send_clear.Name = "btn_send_clear";
            btn_send_clear.Size = new Size(150, 29);
            btn_send_clear.TabIndex = 3;
            btn_send_clear.Text = "清空发送";
            btn_send_clear.UseVisualStyleBackColor = true;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(113, 21);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(150, 29);
            btn_send.TabIndex = 2;
            btn_send.Text = "手动发送";
            btn_send.UseVisualStyleBackColor = true;
            // 
            // cb_send_hex
            // 
            cb_send_hex.AutoSize = true;
            cb_send_hex.Location = new Point(15, 56);
            cb_send_hex.Name = "cb_send_hex";
            cb_send_hex.Size = new Size(88, 24);
            cb_send_hex.TabIndex = 1;
            cb_send_hex.Text = "十六进制";
            cb_send_hex.UseVisualStyleBackColor = true;
            // 
            // cb_send_auto
            // 
            cb_send_auto.AutoSize = true;
            cb_send_auto.Location = new Point(15, 26);
            cb_send_auto.Name = "cb_send_auto";
            cb_send_auto.Size = new Size(88, 24);
            cb_send_auto.TabIndex = 0;
            cb_send_auto.Text = "自动发送";
            cb_send_auto.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rtxt_rec);
            groupBox4.Location = new Point(298, 14);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(786, 468);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "接收区";
            // 
            // rtxt_rec
            // 
            rtxt_rec.Dock = DockStyle.Fill;
            rtxt_rec.Location = new Point(3, 23);
            rtxt_rec.Name = "rtxt_rec";
            rtxt_rec.Size = new Size(780, 442);
            rtxt_rec.TabIndex = 0;
            rtxt_rec.Text = "";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rtxt_send);
            groupBox5.Location = new Point(301, 488);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(780, 210);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "发送区";
            // 
            // rtxt_send
            // 
            rtxt_send.Dock = DockStyle.Fill;
            rtxt_send.Location = new Point(3, 23);
            rtxt_send.Name = "rtxt_send";
            rtxt_send.Size = new Size(774, 184);
            rtxt_send.TabIndex = 0;
            rtxt_send.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, status, toolStripStatusLabel3, sendcount, toolStripStatusLabel5, reccount, clearcount });
            statusStrip1.Location = new Point(0, 706);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1097, 26);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(54, 20);
            toolStripStatusLabel1.Text = "状态：";
            // 
            // status
            // 
            status.AutoSize = false;
            status.Name = "status";
            status.Size = new Size(400, 20);
            status.Text = "初始化正常！";
            status.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(84, 20);
            toolStripStatusLabel3.Text = "发送计数：";
            // 
            // sendcount
            // 
            sendcount.AutoSize = false;
            sendcount.Name = "sendcount";
            sendcount.Size = new Size(100, 20);
            sendcount.Text = "0";
            sendcount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(84, 20);
            toolStripStatusLabel5.Text = "接收计数：";
            // 
            // reccount
            // 
            reccount.AutoSize = false;
            reccount.Name = "reccount";
            reccount.Size = new Size(100, 20);
            reccount.Text = "0";
            reccount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clearcount
            // 
            clearcount.Name = "clearcount";
            clearcount.Size = new Size(222, 20);
            clearcount.Spring = true;
            clearcount.Text = "清空计数";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 732);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "串口调试助手";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox cb_rts;
        private ComboBox cmb_stopbit;
        private ComboBox cmb_databit;
        private ComboBox cmb_checkbit;
        private ComboBox cmb_baud;
        private ComboBox cmb_port;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_openserialport;
        private CheckBox cb_dtr;
        private GroupBox groupBox2;
        private TextBox txt_rec_path;
        private Button btn_rec_path;
        private Button btn_rec_save;
        private Button btn_rec_stop;
        private Button btn_rec_clear;
        private CheckBox cb_rec_hex;
        private CheckBox cb_rec_auto;
        private GroupBox groupBox3;
        private TextBox txt_send_cycle;
        private Label label6;
        private TextBox txt_send_path;
        private Button btn_send_openfile;
        private Button btn_send_sendfile;
        private Button btn_send_clear;
        private Button btn_send;
        private CheckBox cb_send_hex;
        private CheckBox cb_send_auto;
        private GroupBox groupBox4;
        private RichTextBox rtxt_rec;
        private GroupBox groupBox5;
        private RichTextBox rtxt_send;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel status;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel sendcount;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel reccount;
        private ToolStripStatusLabel clearcount;
    }
}