using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SerialProtAssistant2
{
    public partial class Form1 : Form
    {
        private bool _isSerialPortOpen = false;
        private bool _isStopRec = true;
        private bool _isFramHead = false;
        private List<byte> recBuffer = new List<byte>(); //接收数据的缓存
        private List<byte> sendBuffer = new List<byte>(); //发送数据的缓存
        private Queue<byte> queueBuffer = null; //数据帧解析队列
        private int _recCount = 0;
        private int _sendCount = 0;
        private int _frameLength = 0;

        //事件传值
        public event Action<byte[]> TransmitData;

        public Form1()
        {
            InitializeComponent();

            //CheckForIllegalCrossThreadCalls = false;//取消跨线程检查，不推荐使用此方法
        }

        private void btn_openserialport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = cmb_port.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cmb_baud.Text);
                    switch (cmb_checkbit.SelectedIndex)
                    {
                        case 0:
                            serialPort1.Parity = Parity.None;
                            break;
                        case 1:
                            serialPort1.Parity = Parity.Odd;
                            break;
                        case 2:
                            serialPort1.Parity = Parity.Even;
                            break;
                        default:
                            serialPort1.Parity = Parity.None;
                            break;
                    }

                    switch (cmb_stopbit.SelectedIndex)
                    {
                        case 0:
                            serialPort1.StopBits = StopBits.One;
                            break;
                        case 1:
                            serialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case 2:
                            serialPort1.StopBits = StopBits.Two;
                            break;
                        default:
                            serialPort1.StopBits = StopBits.One;
                            break;
                    }

                    serialPort1.DataBits = Convert.ToInt32(cmb_databit.Text);
                    serialPort1.Open();
                    _isSerialPortOpen = true;
                    btn_openserialport.Text = "关闭串口";
                }
                else
                {
                    serialPort1.Close();
                    _isSerialPortOpen = false;
                    btn_openserialport.Text = "打开串口";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// 初始化串口配置
        /// </summary>
        private void InitialSerialPort()
        {
            //从计算机中读取可用的端口号
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(
                @"Hardware\DeviceMap\SerialComm"
            );
            if (registryKey != null)
            {
                string[] names = registryKey.GetValueNames();
                cmb_port.Items.Clear();
                foreach (string name in names)
                {
                    string portName = registryKey.GetValue(name).ToString();
                    cmb_port.Items.Add(portName);
                }
            }

            cmb_port.SelectedIndex = 0;
            cmb_baud.SelectedIndex = 1;
            cmb_checkbit.SelectedIndex = 0;
            cmb_databit.SelectedIndex = 3;
            cmb_stopbit.SelectedIndex = 0;

            serialPort1.Encoding = Encoding.UTF8;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitialSerialPort();

            //在窗体加载时实例化数据帧解析队列
            queueBuffer = new Queue<byte>();

            //在窗体加载时实例化子窗体
            Form2 fm2 = new Form2();
            TransmitData += fm2.ReceiveDataFromForm1;
            fm2.SendData += Fm2_SendData;
            fm2.Show();
        }
        /// <summary>
        /// 子窗体用父窗体的serialPort1来发送数据
        /// </summary>
        /// <param name="data"></param>
        private void Fm2_SendData(byte[] data)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("端口未打开！");
                return;
            }
            serialPort1.Write(data, 0, data.Length);
            _sendCount += data.Length;
            status_send_count.Text = _sendCount.ToString();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtxt_send.Text) && _isSerialPortOpen)
            {
                SendData();
            }
            else
            {
                MessageBox.Show("请先输入要发送的数据！");
            }
        }

        /// <summary>
        /// 向串行端口中写入数据
        /// </summary>
        private void SendData()
        {
            //将准备好的数据中的指定数量的字节写入串行端口
            byte[] dataTemp = sendBuffer.ToArray();
            serialPort1.Write(dataTemp, 0, dataTemp.Length);
            _sendCount += sendBuffer.Count;
            status_send_count.Text = _sendCount.ToString();
        }

        /// <summary>
        /// 从串行端口中读取数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //点击了接收区暂停按钮就直接返回，停止接收数据
            if (!_isStopRec)
                return;
            //serialPort1.BytesToRead 获取接收缓冲区中数据的字节数
            byte[] dataTemp = new byte[serialPort1.BytesToRead];
            //从 SerialPort 输入缓冲区读取一些字节并将那些字节写入字节数组dataTemp中指定的偏移量处
            serialPort1.Read(dataTemp, 0, dataTemp.Length);
            //将读取到的数据缓存起来
            recBuffer.AddRange(dataTemp);
            _recCount += dataTemp.Length;

            //向子窗体发生数据
            TransmitData?.Invoke(dataTemp);

            //跨线程更新UI，使用控件的Invoke方法，将委托转到UI线程上调用，实现线程安全的更新
            this.Invoke(
                new Action(() =>
                {
                    //界面显示已接收的数据量
                    status_rec_count.Text = _recCount.ToString();

                    //是否解析数据帧
                    if (!cb_jx_useDataFrameRec.Checked)
                    {
                        if (!cb_rec_hex.Checked)
                        {
                            //未选中16进制复选框时，以字符串方式接受数据
                            string str = Encoding.UTF8.GetString(dataTemp).Replace("\0", "\\0");
                            rtxt_rec.AppendText(str);
                        }
                        else
                        {
                            //选中16进制复选框时，以16进制方式接受数据
                            string str = Transform.ToHexString(dataTemp, " ");
                            rtxt_rec.AppendText(str);
                        }
                    }
                    //解析数据帧
                    else
                    {
                        //先将dataTemp中的数据全部入列
                        foreach (byte item in dataTemp)
                        {
                            queueBuffer.Enqueue(item);
                        }

                        // 解析获取帧头 0x7f是协议自定义的帧头
                        if (!_isFramHead)
                        {
                            foreach (byte item in queueBuffer.ToArray())
                            {
                                if (item != 0x7f)
                                {
                                    //如果帧头不是0x7f，说明不是我们要的数据，就将该项从队列中出列，直至匹配到对应的帧头
                                    queueBuffer.Dequeue();
                                    Debug.WriteLine("not 0x7f, Dequeue !!");
                                }
                                else
                                {
                                    _isFramHead = true;
                                    Debug.WriteLine("0x7f is recived !!");
                                    break;
                                }
                            }
                        }

                        if (_isFramHead)
                        {
                            if (queueBuffer.Count >= 2)
                            {
                                Debug.WriteLine(DateTime.Now.ToLongTimeString());
                                Debug.WriteLine(
                                    $"show the data in queueBuffer{Transform.ToHexString(queueBuffer.ToArray())}"
                                );
                                Debug.WriteLine(
                                    $"frame lenth ={String.Format("{0:X2}", queueBuffer.ToArray()[1])}"
                                );

                                _frameLength = queueBuffer.ToArray()[1]; //数据中第二个字节表示数据长度

                                // 一帧完整的数据长度判断，不代表数据是正确的
                                if (queueBuffer.Count >= 1 + 1 + _frameLength + 2)
                                {
                                    //将有效长度的数据保存起来
                                    byte[] frameBuffer = new byte[1 + 1 + _frameLength + 2];
                                    Array.Copy(
                                        queueBuffer.ToArray(),
                                        0,
                                        frameBuffer,
                                        0,
                                        frameBuffer.Length
                                    );
                                    //数据校验解析
                                    if (CrcCheck(frameBuffer))
                                    {
                                        Debug.WriteLine("frame is check ok,pick it");
                                        //这一帧完整的数据 帧头+长度+数据+CRC
                                        rtxt_dataFrame.Text = Transform.ToHexString(frameBuffer); 
                                        txt_jx_data1.Text = String.Format("{0:X2}", frameBuffer[2]);
                                        txt_jx_data2.Text = String.Format("{0:X2}", frameBuffer[3]);
                                        txt_jx_data3.Text = String.Format("{0:X2}", frameBuffer[4]);
                                        txt_jx_data4.Text = String.Format("{0:X2}", frameBuffer[5]);
                                    }
                                    else
                                    {
                                        // 无效数据
                                        Debug.WriteLine("bad frame, drop it");
                                    }

                                    //数据解析完后，将这一帧数据全部出列，将帧头重新标记为false
                                    //然后匹配到正确的帧头，接着解析下一帧数据
                                    for (int i = 0; i < 1 + 1 + _frameLength + 2; i++)
                                    {
                                        queueBuffer.Dequeue();
                                    }
                                    _isFramHead = false;
                                }
                                else
                                {
                                    //数据长度小于协议定义的长度，接着接收数据
                                }
                            }
                        }
                    }
                })
            );
        }

        /// <summary>
        /// CRC校验
        /// </summary>
        /// <param name="frameBuffer"></param>
        /// <returns></returns>
        private bool CrcCheck(byte[] frameBuffer)
        {
            /*大端模式: 是指数据的高字节保存在内存的低地址中，
             * 而数据的低字节保存在内存的高地址中，这样的存储
             * 模式有点儿类似于把数据当作字符串顺序处理：地址
             * 由小向大增加，而数据从高位往低位放；这和我们的
             * 阅读习惯一致。
             *
             * 小端模式: 是指数据的高字节保存在内存的高地址中，
             * 而数据的低字节保存在内存的低地址中，这种存储模
             * 式将地址的高低和数据位权有效地结合起来，高地址
             * 部分权值高，低地址部分权值低。
             */
            bool isOK = false;

            byte[] temp = new byte[frameBuffer.Length - 2];
            Array.Copy(frameBuffer, 0, temp, 0, temp.Length);
            byte[] crcdata = DataCheck.DataCrc16_Ccitt(temp, DataCheck.BigOrLittle.BigEndian);
            if (
                crcdata[0] == frameBuffer[frameBuffer.Length - 2]
                && crcdata[1] == frameBuffer[frameBuffer.Length - 1]
            )
            {
                // check ok
                isOK = true;
            }

            return isOK;
        }

        private void btn_rec_stop_Click(object sender, EventArgs e)
        {
            if (_isStopRec)
            {
                _isStopRec = false;
                btn_rec_stop.Text = "恢复";
            }
            else
            {
                _isStopRec = true;
                btn_rec_stop.Text = "暂停";
            }
        }

        /// <summary>
        /// 切换接收区文本框内容是否以十六进制显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_rec_hex_CheckedChanged(object sender, EventArgs e)
        {
            rtxt_rec.Text = SwitchHexadecimalDisplay(
                rtxt_rec.Text,
                cb_rec_hex.Checked,
                recBuffer.ToArray()
            );
        }

        /// <summary>
        /// 清除接受的数据及相关显示内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_rec_clear_Click(object sender, EventArgs e)
        {
            recBuffer.Clear();
            rtxt_rec.Text = "";
            status_rec_count.Text = "0";
            _recCount = 0;
        }

        /// <summary>
        /// 切换接收区文本框内容是否自动清空，使用定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_rec_auto_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_rec_autoclear.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        /// <summary>
        /// 当接收区文本框内容长度大于4096时，自动清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rtxt_rec.Text.Length > 4096)
            {
                recBuffer.Clear();
                rtxt_rec.Text = "";
            }
        }

        /// <summary>
        /// 状态栏清空计数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void status_clearcount_Click(object sender, EventArgs e)
        {
            //界面显示已接收的数据量
            status_rec_count.Text = "0";
            _recCount = 0;
        }

        /// <summary>
        /// 发送文本框失去焦点时，将数据保存起来
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtxt_send_Leave(object sender, EventArgs e)
        {
            //判断十六进制复选框是否勾选，以不同的形式存储数据
            if (cb_send_hex.Checked)
            {
                //判断输入的数据是否符合十六进制格式
                if (DataEncoding.IsHexString(rtxt_send.Text.Replace(" ", "")))
                {
                    sendBuffer.Clear();
                    sendBuffer.AddRange(Transform.ToBytes(rtxt_send.Text.Replace(" ", "")));
                }
                else
                {
                    MessageBox.Show("输入内容非十六进制！");
                    rtxt_send.Select();
                }
            }
            else
            {
                sendBuffer.Clear();
                sendBuffer.AddRange(Encoding.UTF8.GetBytes(rtxt_send.Text));
            }
        }

        /// <summary>
        /// 切换十六进制复选框状态时，更新发送框UI显示内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_send_hex_CheckedChanged(object sender, EventArgs e)
        {
            rtxt_send.Text = SwitchHexadecimalDisplay(
                rtxt_send.Text,
                cb_send_hex.Checked,
                sendBuffer.ToArray()
            );
        }

        private void btn_send_clear_Click(object sender, EventArgs e)
        {
            sendBuffer.Clear();
            _sendCount = 0;
            status_send_count.Text = "0";
            rtxt_send.Text = "";
        }

        /// <summary>
        /// 切换十六进制显示
        /// </summary>
        /// <param name="content">显示的内容</param>
        /// <param name="isHex">是否以十六进制显示</param>
        /// <param name="dataSource">数据源</param>
        /// <returns>返回转换后的字符串</returns>
        private string SwitchHexadecimalDisplay(string content, bool isHex, byte[] dataSource)
        {
            if (string.IsNullOrEmpty(content))
            {
                return "";
            }
            if (isHex)
            {
                //以十六进制格式显示 以空格间隔
                content = Transform.ToHexString(dataSource.ToArray(), " ");
            }
            else
            {
                //以普通字符串格式显示  0x00->\0 不会显示 需要转义
                content = Encoding.UTF8.GetString(dataSource.ToArray()).Replace("\0", "\\0");
            }

            return content;
        }
    }
}
