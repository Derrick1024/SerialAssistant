using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialAssistantApplication
{
    public partial class Form1 : Form
    {
        SerialPort sp = null;//声明一个串口类
        bool isOpen = false;//打开串口标志位
        bool isSetProperty = false;//属性设置标志位
        bool isHex = false;//十六进制显示标志位

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //列出可用COMPort
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cbbCOMPort.Items.Add(port);
            }

            //列出BaudRate
            cbbBaudRate.Items.Add("1200");
            cbbBaudRate.Items.Add("2400");
            cbbBaudRate.Items.Add("4800");
            cbbBaudRate.Items.Add("9600");
            cbbBaudRate.Items.Add("19200");
            cbbBaudRate.Items.Add("38400");
            cbbBaudRate.Items.Add("43000");
            cbbBaudRate.Items.Add("56000");
            cbbBaudRate.Items.Add("57600");
            cbbBaudRate.Items.Add("115200");
            cbbBaudRate.SelectedIndex = 9;
            //列出DateBits
            cbbDataBits.Items.Add("8");
            cbbDataBits.Items.Add("7");
            cbbDataBits.Items.Add("6");
            cbbDataBits.Items.Add("5");
            cbbDataBits.SelectedIndex = 0;
            //列出StopBits
            cbbStopBits.Items.Add("0");
            cbbStopBits.Items.Add("1");
            cbbStopBits.Items.Add("1.5");
            cbbStopBits.Items.Add("2");
            cbbStopBits.SelectedIndex = 1;
            //列出Parity
            cbbParity.Items.Add("无");
            cbbParity.Items.Add("奇校验");
            cbbParity.Items.Add("偶校验");
            cbbParity.SelectedIndex = 0;
        }

        private bool CheckPortSetting()//检查串口是否设置
        {
            if (cbbCOMPort.Text.Trim() == "") return false;
            if (cbbBaudRate.Text.Trim() == "") return false;
            if (cbbDataBits.Text.Trim() == "") return false;
            if (cbbParity.Text.Trim() == "") return false;
            if (cbbStopBits.Text.Trim() == "") return false;
            return true;
        }

        private bool CheckSendData()
        {
            if (tbxDataSend.Text.Trim() == "") return false;
            return true;
        }

        private void SetPortProperty()//设置串口的属性
        {
            sp = new SerialPort();
            sp.PortName = cbbCOMPort.Text.Trim();//设置串口名
            sp.BaudRate = Convert.ToInt32(cbbBaudRate.Text.Trim());//设置串口的波特率
            float f = Convert.ToSingle(cbbStopBits.Text.Trim());//设置停止位
            if (f == 0)
            {
                sp.StopBits = StopBits.None;
            }
            else if (f == 1.5)
            {

                sp.StopBits = StopBits.OnePointFive;
            }
            else if (f == 1)
            {
                sp.StopBits = StopBits.One;
            }
            else if (f == 2)
            {
                sp.StopBits = StopBits.Two;
            }
            else
            {
                sp.StopBits = StopBits.One;
            }
            sp.DataBits = Convert.ToInt16(cbbDataBits.Text.Trim());//设置数据位
            string s = cbbParity.Text.Trim(); //设置奇偶校验位
            if (s.CompareTo("无") == 0)
            {
                sp.Parity = Parity.None;
            }
            else if (s.CompareTo("奇校验") == 0)
            {
                sp.Parity = Parity.Odd;
            }
            else if (s.CompareTo("偶校验") == 0)
            {
                sp.Parity = Parity.Even;
            }
            else
            {
                sp.Parity = Parity.None;
            }
            sp.ReadTimeout = -1;//设置超时读取时间
            sp.RtsEnable = true;
            //定义 DataReceived 事件，当串口收到数据后触发事件
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            if (rbnHEX.Checked)
            {

                isHex = true;
            }
            else
            {
                isHex = false;
            }
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(10);//延时 100ms 等待接收完数据
                                               //this.Invoke 就是跨线程访问 ui 的方法，也是本文的范例
            this.Invoke((EventHandler)(delegate
            {
                if (isHex == false)
                {
                    //tbxDataRev.Text += sp.ReadLine();
                    tbxDataRev.AppendText(sp.ReadLine());
                }
                else
                {
                    Byte[] ReceivedData = new Byte[sp.BytesToRead]; //创建接收字节数组
                    sp.Read(ReceivedData, 0, ReceivedData.Length); //读取所接收到的数据
                    String RecvDataText = null;
                    for (int i = 0; i < ReceivedData.Length - 1; i++)
                    {
                        RecvDataText += ("0x" + ReceivedData[i].ToString("X2") + " ");
                    }
                    //tbxDataRev.Text += RecvDataText;
                    tbxDataRev.AppendText(sp.ReadLine());
                }
                sp.DiscardInBuffer();//丢弃接收缓冲区数据
            }));
        }

        private void About_Click(object sender, EventArgs e)
        {
            Form About = new AboutBox1();
            About.ShowDialog();
        }

        private void COMCheck_Click(object sender, EventArgs e)
        {
            cbbCOMPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cbbCOMPort.Items.Add(port);
            }
        }

        private void btnOpenCOM_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                if (!CheckPortSetting())//检测串口设置
                {
                    MessageBox.Show("串口未设置！", "错误提示");
                    return;
                }

                if (!isSetProperty)//串口未设置则设置串口
                {
                    SetPortProperty();
                    isSetProperty = true;
                }
                try//打开串口
                {
                    sp.Open();
                    isOpen = true;
                    btnOpenCOM.Text = "关闭串口";
                    //串口打开后则相关的串口设置按钮便不可再用
                    cbbCOMPort.Enabled = false;
                    cbbBaudRate.Enabled = false;
                    cbbDataBits.Enabled = false;
                    cbbParity.Enabled = false;
                    cbbStopBits.Enabled = false;
                    rbnChar.Enabled = false;
                    rbnHEX.Enabled = false;
                }
                catch (Exception)
                {
                    //打开串口失败后，相应标志位取消
                    isSetProperty = false;
                    isOpen = false;
                    MessageBox.Show("串口无效或已被占用！", "错误提示");
                }
            }
            else
            {
                try//打开串口
                {
                    sp.Close();
                    isOpen = false;
                    isSetProperty = false;
                    btnOpenCOM.Text = "打开串口";
                    //关闭串口后，串口设置选项便可以继续使用
                    cbbCOMPort.Enabled = true;
                    cbbBaudRate.Enabled = true;
                    cbbDataBits.Enabled = true;
                    cbbParity.Enabled = true;
                    cbbStopBits.Enabled = true;
                    rbnChar.Enabled = true;
             
                rbnHEX.Enabled = true;
                }
                catch (Exception)
                {
                    //lblStatus.Text = "关闭串口时发生错误";
                }
            }
        }

       

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (isOpen)//写串口数据
            {
                try
                {
                    sp.WriteLine(tbxDataSend.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("发送数据时发生错误！", "错误提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("串口未打开！", "错误提示");
                return;
            }
            if (!CheckSendData())//检测要发送的数据
            {
                MessageBox.Show("请输入要发送的数据！", "错误提示");
                return;
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            tbxDataRev.Text = "";
        }
    }
}

