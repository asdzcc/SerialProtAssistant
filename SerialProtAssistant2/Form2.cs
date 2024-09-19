using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialProtAssistant2
{
    public partial class Form2 : Form
    {
        //事件传值
        public event Action<byte[]> SendData;
        public Form2()
        {
            InitializeComponent();
        }

        public void ReceiveDataFromForm1(byte[] data)
        {
            string str = Encoding.UTF8.GetString(data).Replace("\0", "\\0");
            this.Invoke(new Action(() =>
            {
                rtxt_frm2_rec.AppendText(str);
            }));
        }

        private void btn_frm2_send_Click(object sender, EventArgs e)
        {
            SendData?.Invoke(Encoding.UTF8.GetBytes(txt_frm2_send.Text));
        }
    }
}
