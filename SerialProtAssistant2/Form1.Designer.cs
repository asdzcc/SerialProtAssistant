using System.Drawing;
using System.Windows.Forms;

namespace SerialProtAssistant2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_openserialport = new System.Windows.Forms.Button();
            this.cb_dtr = new System.Windows.Forms.CheckBox();
            this.cb_rts = new System.Windows.Forms.CheckBox();
            this.cmb_stopbit = new System.Windows.Forms.ComboBox();
            this.cmb_databit = new System.Windows.Forms.ComboBox();
            this.cmb_checkbit = new System.Windows.Forms.ComboBox();
            this.cmb_baud = new System.Windows.Forms.ComboBox();
            this.cmb_port = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_rec_path = new System.Windows.Forms.TextBox();
            this.btn_rec_path = new System.Windows.Forms.Button();
            this.btn_rec_save = new System.Windows.Forms.Button();
            this.btn_rec_stop = new System.Windows.Forms.Button();
            this.btn_rec_clear = new System.Windows.Forms.Button();
            this.cb_rec_hex = new System.Windows.Forms.CheckBox();
            this.cb_rec_autoclear = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_send_cycle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_send_path = new System.Windows.Forms.TextBox();
            this.btn_send_openfile = new System.Windows.Forms.Button();
            this.btn_send_sendfile = new System.Windows.Forms.Button();
            this.btn_send_clear = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.cb_send_hex = new System.Windows.Forms.CheckBox();
            this.cb_send_auto = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtxt_rec = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rtxt_send = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statu_info = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_send_count = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_rec_count = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_clearcount = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_jx_useDataFrameRec = new System.Windows.Forms.CheckBox();
            this.rtxt_dataFrame = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_jx_data2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_jx_data3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_jx_data4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_jx_data1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_openserialport);
            this.groupBox1.Controls.Add(this.cb_dtr);
            this.groupBox1.Controls.Add(this.cb_rts);
            this.groupBox1.Controls.Add(this.cmb_stopbit);
            this.groupBox1.Controls.Add(this.cmb_databit);
            this.groupBox1.Controls.Add(this.cmb_checkbit);
            this.groupBox1.Controls.Add(this.cmb_baud);
            this.groupBox1.Controls.Add(this.cmb_port);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(315, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // btn_openserialport
            // 
            this.btn_openserialport.Location = new System.Drawing.Point(127, 264);
            this.btn_openserialport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_openserialport.Name = "btn_openserialport";
            this.btn_openserialport.Size = new System.Drawing.Size(169, 77);
            this.btn_openserialport.TabIndex = 12;
            this.btn_openserialport.Text = "打开串口";
            this.btn_openserialport.UseVisualStyleBackColor = true;
            this.btn_openserialport.Click += new System.EventHandler(this.btn_openserialport_Click);
            // 
            // cb_dtr
            // 
            this.cb_dtr.AutoSize = true;
            this.cb_dtr.Location = new System.Drawing.Point(21, 312);
            this.cb_dtr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_dtr.Name = "cb_dtr";
            this.cb_dtr.Size = new System.Drawing.Size(54, 22);
            this.cb_dtr.TabIndex = 11;
            this.cb_dtr.Text = "DTR";
            this.cb_dtr.UseVisualStyleBackColor = true;
            // 
            // cb_rts
            // 
            this.cb_rts.AutoSize = true;
            this.cb_rts.Location = new System.Drawing.Point(21, 264);
            this.cb_rts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_rts.Name = "cb_rts";
            this.cb_rts.Size = new System.Drawing.Size(54, 22);
            this.cb_rts.TabIndex = 10;
            this.cb_rts.Text = "RTS";
            this.cb_rts.UseVisualStyleBackColor = true;
            // 
            // cmb_stopbit
            // 
            this.cmb_stopbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stopbit.FormattingEnabled = true;
            this.cmb_stopbit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cmb_stopbit.Location = new System.Drawing.Point(127, 211);
            this.cmb_stopbit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_stopbit.Name = "cmb_stopbit";
            this.cmb_stopbit.Size = new System.Drawing.Size(168, 26);
            this.cmb_stopbit.TabIndex = 9;
            // 
            // cmb_databit
            // 
            this.cmb_databit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_databit.FormattingEnabled = true;
            this.cmb_databit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cmb_databit.Location = new System.Drawing.Point(127, 164);
            this.cmb_databit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_databit.Name = "cmb_databit";
            this.cmb_databit.Size = new System.Drawing.Size(168, 26);
            this.cmb_databit.TabIndex = 8;
            // 
            // cmb_checkbit
            // 
            this.cmb_checkbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_checkbit.FormattingEnabled = true;
            this.cmb_checkbit.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.cmb_checkbit.Location = new System.Drawing.Point(127, 118);
            this.cmb_checkbit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_checkbit.Name = "cmb_checkbit";
            this.cmb_checkbit.Size = new System.Drawing.Size(168, 26);
            this.cmb_checkbit.TabIndex = 7;
            // 
            // cmb_baud
            // 
            this.cmb_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_baud.FormattingEnabled = true;
            this.cmb_baud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "11520"});
            this.cmb_baud.Location = new System.Drawing.Point(127, 71);
            this.cmb_baud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_baud.Name = "cmb_baud";
            this.cmb_baud.Size = new System.Drawing.Size(168, 26);
            this.cmb_baud.TabIndex = 6;
            // 
            // cmb_port
            // 
            this.cmb_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_port.FormattingEnabled = true;
            this.cmb_port.Location = new System.Drawing.Point(127, 24);
            this.cmb_port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_port.Name = "cmb_port";
            this.cmb_port.Size = new System.Drawing.Size(168, 26);
            this.cmb_port.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "校验位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_rec_path);
            this.groupBox2.Controls.Add(this.btn_rec_path);
            this.groupBox2.Controls.Add(this.btn_rec_save);
            this.groupBox2.Controls.Add(this.btn_rec_stop);
            this.groupBox2.Controls.Add(this.btn_rec_clear);
            this.groupBox2.Controls.Add(this.cb_rec_hex);
            this.groupBox2.Controls.Add(this.cb_rec_autoclear);
            this.groupBox2.Location = new System.Drawing.Point(14, 384);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(315, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // txt_rec_path
            // 
            this.txt_rec_path.Location = new System.Drawing.Point(17, 151);
            this.txt_rec_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_rec_path.Name = "txt_rec_path";
            this.txt_rec_path.Size = new System.Drawing.Size(278, 28);
            this.txt_rec_path.TabIndex = 6;
            // 
            // btn_rec_path
            // 
            this.btn_rec_path.Location = new System.Drawing.Point(17, 109);
            this.btn_rec_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_rec_path.Name = "btn_rec_path";
            this.btn_rec_path.Size = new System.Drawing.Size(98, 35);
            this.btn_rec_path.TabIndex = 5;
            this.btn_rec_path.Text = "选择文路径";
            this.btn_rec_path.UseVisualStyleBackColor = true;
            // 
            // btn_rec_save
            // 
            this.btn_rec_save.Location = new System.Drawing.Point(127, 109);
            this.btn_rec_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_rec_save.Name = "btn_rec_save";
            this.btn_rec_save.Size = new System.Drawing.Size(169, 35);
            this.btn_rec_save.TabIndex = 4;
            this.btn_rec_save.Text = "保存数据";
            this.btn_rec_save.UseVisualStyleBackColor = true;
            // 
            // btn_rec_stop
            // 
            this.btn_rec_stop.Location = new System.Drawing.Point(127, 67);
            this.btn_rec_stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_rec_stop.Name = "btn_rec_stop";
            this.btn_rec_stop.Size = new System.Drawing.Size(169, 35);
            this.btn_rec_stop.TabIndex = 3;
            this.btn_rec_stop.Text = "暂停";
            this.btn_rec_stop.UseVisualStyleBackColor = true;
            this.btn_rec_stop.Click += new System.EventHandler(this.btn_rec_stop_Click);
            // 
            // btn_rec_clear
            // 
            this.btn_rec_clear.Location = new System.Drawing.Point(127, 25);
            this.btn_rec_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_rec_clear.Name = "btn_rec_clear";
            this.btn_rec_clear.Size = new System.Drawing.Size(169, 35);
            this.btn_rec_clear.TabIndex = 2;
            this.btn_rec_clear.Text = "手动清空";
            this.btn_rec_clear.UseVisualStyleBackColor = true;
            this.btn_rec_clear.Click += new System.EventHandler(this.btn_rec_clear_Click);
            // 
            // cb_rec_hex
            // 
            this.cb_rec_hex.AutoSize = true;
            this.cb_rec_hex.Location = new System.Drawing.Point(17, 67);
            this.cb_rec_hex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_rec_hex.Name = "cb_rec_hex";
            this.cb_rec_hex.Size = new System.Drawing.Size(99, 22);
            this.cb_rec_hex.TabIndex = 1;
            this.cb_rec_hex.Text = "十六进制";
            this.cb_rec_hex.UseVisualStyleBackColor = true;
            this.cb_rec_hex.CheckedChanged += new System.EventHandler(this.cb_rec_hex_CheckedChanged);
            // 
            // cb_rec_autoclear
            // 
            this.cb_rec_autoclear.AutoSize = true;
            this.cb_rec_autoclear.Location = new System.Drawing.Point(17, 31);
            this.cb_rec_autoclear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_rec_autoclear.Name = "cb_rec_autoclear";
            this.cb_rec_autoclear.Size = new System.Drawing.Size(99, 22);
            this.cb_rec_autoclear.TabIndex = 0;
            this.cb_rec_autoclear.Text = "自动清空";
            this.cb_rec_autoclear.UseVisualStyleBackColor = true;
            this.cb_rec_autoclear.CheckedChanged += new System.EventHandler(this.cb_rec_auto_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_send_cycle);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_send_path);
            this.groupBox3.Controls.Add(this.btn_send_openfile);
            this.groupBox3.Controls.Add(this.btn_send_sendfile);
            this.groupBox3.Controls.Add(this.btn_send_clear);
            this.groupBox3.Controls.Add(this.btn_send);
            this.groupBox3.Controls.Add(this.cb_send_hex);
            this.groupBox3.Controls.Add(this.cb_send_auto);
            this.groupBox3.Location = new System.Drawing.Point(14, 586);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(315, 252);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // txt_send_cycle
            // 
            this.txt_send_cycle.Location = new System.Drawing.Point(192, 191);
            this.txt_send_cycle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_send_cycle.Name = "txt_send_cycle";
            this.txt_send_cycle.Size = new System.Drawing.Size(103, 28);
            this.txt_send_cycle.TabIndex = 8;
            this.txt_send_cycle.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "自动发送周期（ms）";
            // 
            // txt_send_path
            // 
            this.txt_send_path.Location = new System.Drawing.Point(17, 151);
            this.txt_send_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_send_path.Name = "txt_send_path";
            this.txt_send_path.Size = new System.Drawing.Size(278, 28);
            this.txt_send_path.TabIndex = 6;
            // 
            // btn_send_openfile
            // 
            this.btn_send_openfile.Location = new System.Drawing.Point(17, 109);
            this.btn_send_openfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_send_openfile.Name = "btn_send_openfile";
            this.btn_send_openfile.Size = new System.Drawing.Size(98, 35);
            this.btn_send_openfile.TabIndex = 5;
            this.btn_send_openfile.Text = "打开文件";
            this.btn_send_openfile.UseVisualStyleBackColor = true;
            // 
            // btn_send_sendfile
            // 
            this.btn_send_sendfile.Location = new System.Drawing.Point(127, 109);
            this.btn_send_sendfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_send_sendfile.Name = "btn_send_sendfile";
            this.btn_send_sendfile.Size = new System.Drawing.Size(169, 35);
            this.btn_send_sendfile.TabIndex = 4;
            this.btn_send_sendfile.Text = "发送文件";
            this.btn_send_sendfile.UseVisualStyleBackColor = true;
            // 
            // btn_send_clear
            // 
            this.btn_send_clear.Location = new System.Drawing.Point(127, 67);
            this.btn_send_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_send_clear.Name = "btn_send_clear";
            this.btn_send_clear.Size = new System.Drawing.Size(169, 35);
            this.btn_send_clear.TabIndex = 3;
            this.btn_send_clear.Text = "清空发送";
            this.btn_send_clear.UseVisualStyleBackColor = true;
            this.btn_send_clear.Click += new System.EventHandler(this.btn_send_clear_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(127, 25);
            this.btn_send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(169, 35);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "手动发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // cb_send_hex
            // 
            this.cb_send_hex.AutoSize = true;
            this.cb_send_hex.Location = new System.Drawing.Point(17, 67);
            this.cb_send_hex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_send_hex.Name = "cb_send_hex";
            this.cb_send_hex.Size = new System.Drawing.Size(99, 22);
            this.cb_send_hex.TabIndex = 1;
            this.cb_send_hex.Text = "十六进制";
            this.cb_send_hex.UseVisualStyleBackColor = true;
            this.cb_send_hex.CheckedChanged += new System.EventHandler(this.cb_send_hex_CheckedChanged);
            // 
            // cb_send_auto
            // 
            this.cb_send_auto.AutoSize = true;
            this.cb_send_auto.Location = new System.Drawing.Point(17, 31);
            this.cb_send_auto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_send_auto.Name = "cb_send_auto";
            this.cb_send_auto.Size = new System.Drawing.Size(99, 22);
            this.cb_send_auto.TabIndex = 0;
            this.cb_send_auto.Text = "自动发送";
            this.cb_send_auto.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtxt_rec);
            this.groupBox4.Location = new System.Drawing.Point(335, 17);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(669, 562);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // rtxt_rec
            // 
            this.rtxt_rec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_rec.Location = new System.Drawing.Point(3, 25);
            this.rtxt_rec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxt_rec.Name = "rtxt_rec";
            this.rtxt_rec.Size = new System.Drawing.Size(663, 533);
            this.rtxt_rec.TabIndex = 0;
            this.rtxt_rec.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rtxt_send);
            this.groupBox5.Location = new System.Drawing.Point(339, 586);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(666, 252);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // rtxt_send
            // 
            this.rtxt_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_send.Location = new System.Drawing.Point(3, 25);
            this.rtxt_send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxt_send.Name = "rtxt_send";
            this.rtxt_send.Size = new System.Drawing.Size(660, 223);
            this.rtxt_send.TabIndex = 0;
            this.rtxt_send.Text = "";
            this.rtxt_send.Leave += new System.EventHandler(this.rtxt_send_Leave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statu_info,
            this.toolStripStatusLabel3,
            this.status_send_count,
            this.toolStripStatusLabel5,
            this.status_rec_count,
            this.status_clearcount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 852);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1259, 26);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 21);
            this.toolStripStatusLabel1.Text = "状态：";
            // 
            // statu_info
            // 
            this.statu_info.AutoSize = false;
            this.statu_info.Name = "statu_info";
            this.statu_info.Size = new System.Drawing.Size(400, 21);
            this.statu_info.Text = "初始化正常！";
            this.statu_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 21);
            this.toolStripStatusLabel3.Text = "发送计数：";
            // 
            // status_send_count
            // 
            this.status_send_count.AutoSize = false;
            this.status_send_count.Name = "status_send_count";
            this.status_send_count.Size = new System.Drawing.Size(100, 21);
            this.status_send_count.Text = "0";
            this.status_send_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(68, 21);
            this.toolStripStatusLabel5.Text = "接收计数：";
            // 
            // status_rec_count
            // 
            this.status_rec_count.AutoSize = false;
            this.status_rec_count.Name = "status_rec_count";
            this.status_rec_count.Size = new System.Drawing.Size(100, 21);
            this.status_rec_count.Text = "0";
            this.status_rec_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // status_clearcount
            // 
            this.status_clearcount.Name = "status_clearcount";
            this.status_clearcount.Size = new System.Drawing.Size(462, 21);
            this.status_clearcount.Spring = true;
            this.status_clearcount.Text = "清空计数";
            this.status_clearcount.Click += new System.EventHandler(this.status_clearcount_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.cb_jx_useDataFrameRec);
            this.groupBox6.Controls.Add(this.rtxt_dataFrame);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txt_jx_data2);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txt_jx_data3);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txt_jx_data4);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.txt_jx_data1);
            this.groupBox6.Location = new System.Drawing.Point(1011, 17);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(236, 562);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "指令解析";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(7, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 52);
            this.label12.TabIndex = 11;
            this.label12.Text = "格式：\r\n    7F+长度+数据+CRC\r\n\r\n例：7f0431323334DE10\r\n";
            // 
            // cb_jx_useDataFrameRec
            // 
            this.cb_jx_useDataFrameRec.AutoSize = true;
            this.cb_jx_useDataFrameRec.Location = new System.Drawing.Point(10, 329);
            this.cb_jx_useDataFrameRec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_jx_useDataFrameRec.Name = "cb_jx_useDataFrameRec";
            this.cb_jx_useDataFrameRec.Size = new System.Drawing.Size(153, 22);
            this.cb_jx_useDataFrameRec.TabIndex = 10;
            this.cb_jx_useDataFrameRec.Text = "启用数据帧接收";
            this.cb_jx_useDataFrameRec.UseVisualStyleBackColor = true;
            // 
            // rtxt_dataFrame
            // 
            this.rtxt_dataFrame.Location = new System.Drawing.Point(10, 206);
            this.rtxt_dataFrame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxt_dataFrame.Name = "rtxt_dataFrame";
            this.rtxt_dataFrame.Size = new System.Drawing.Size(192, 114);
            this.rtxt_dataFrame.TabIndex = 9;
            this.rtxt_dataFrame.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "数据帧";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "数据2";
            // 
            // txt_jx_data2
            // 
            this.txt_jx_data2.Location = new System.Drawing.Point(82, 66);
            this.txt_jx_data2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_jx_data2.Name = "txt_jx_data2";
            this.txt_jx_data2.Size = new System.Drawing.Size(120, 28);
            this.txt_jx_data2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "数据3";
            // 
            // txt_jx_data3
            // 
            this.txt_jx_data3.Location = new System.Drawing.Point(82, 103);
            this.txt_jx_data3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_jx_data3.Name = "txt_jx_data3";
            this.txt_jx_data3.Size = new System.Drawing.Size(120, 28);
            this.txt_jx_data3.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "数据4";
            // 
            // txt_jx_data4
            // 
            this.txt_jx_data4.Location = new System.Drawing.Point(82, 140);
            this.txt_jx_data4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_jx_data4.Name = "txt_jx_data4";
            this.txt_jx_data4.Size = new System.Drawing.Size(120, 28);
            this.txt_jx_data4.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "数据1";
            // 
            // txt_jx_data1
            // 
            this.txt_jx_data1.Location = new System.Drawing.Point(82, 29);
            this.txt_jx_data1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_jx_data1.Name = "txt_jx_data1";
            this.txt_jx_data1.Size = new System.Drawing.Size(120, 28);
            this.txt_jx_data1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 878);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "串口调试助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private CheckBox cb_rec_autoclear;
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
        private ToolStripStatusLabel statu_info;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel status_send_count;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel status_rec_count;
        private ToolStripStatusLabel status_clearcount;
        private System.IO.Ports.SerialPort serialPort1;
        private Timer timer1;
        private GroupBox groupBox6;
        private Label label10;
        private TextBox txt_jx_data2;
        private Label label9;
        private TextBox txt_jx_data3;
        private Label label8;
        private TextBox txt_jx_data4;
        private Label label7;
        private TextBox txt_jx_data1;
        private Label label12;
        private CheckBox cb_jx_useDataFrameRec;
        private RichTextBox rtxt_dataFrame;
        private Label label11;
    }
}

