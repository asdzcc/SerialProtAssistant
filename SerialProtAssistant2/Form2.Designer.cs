namespace SerialProtAssistant2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxt_frm2_rec = new System.Windows.Forms.RichTextBox();
            this.txt_frm2_send = new System.Windows.Forms.TextBox();
            this.btn_frm2_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt_frm2_rec
            // 
            this.rtxt_frm2_rec.Location = new System.Drawing.Point(14, 14);
            this.rtxt_frm2_rec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxt_frm2_rec.Name = "rtxt_frm2_rec";
            this.rtxt_frm2_rec.Size = new System.Drawing.Size(788, 291);
            this.rtxt_frm2_rec.TabIndex = 0;
            this.rtxt_frm2_rec.Text = "";
            // 
            // txt_frm2_send
            // 
            this.txt_frm2_send.Location = new System.Drawing.Point(15, 314);
            this.txt_frm2_send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_frm2_send.Name = "txt_frm2_send";
            this.txt_frm2_send.Size = new System.Drawing.Size(583, 28);
            this.txt_frm2_send.TabIndex = 1;
            // 
            // btn_frm2_send
            // 
            this.btn_frm2_send.Location = new System.Drawing.Point(610, 314);
            this.btn_frm2_send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_frm2_send.Name = "btn_frm2_send";
            this.btn_frm2_send.Size = new System.Drawing.Size(197, 38);
            this.btn_frm2_send.TabIndex = 2;
            this.btn_frm2_send.Text = "发送";
            this.btn_frm2_send.UseVisualStyleBackColor = true;
            this.btn_frm2_send.Click += new System.EventHandler(this.btn_frm2_send_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 353);
            this.Controls.Add(this.btn_frm2_send);
            this.Controls.Add(this.txt_frm2_send);
            this.Controls.Add(this.rtxt_frm2_rec);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_frm2_rec;
        private System.Windows.Forms.TextBox txt_frm2_send;
        private System.Windows.Forms.Button btn_frm2_send;
    }
}