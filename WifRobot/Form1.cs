using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WifiVideo
{
    public partial class Form1 : Form
    {
        private static readonly string FileName = Path.Combine(Application.StartupPath, "Config.ini");
        private string CameraIp = "";

        private string CMD_Forward = "",
            CMD_Backward = "",
            CMD_TurnLeft = "",
            CMD_TurnRight = "",
            CMD_TurnLeft1 = "",
            CMD_TurnRight1 = "",
            CMD_TurnLeft2 = "",
            CMD_TurnRight2 = "",
            CMD_Stop = "",
            CMD_ServoUp = "",
            CMD_ServoDown = "",
            CMD_ServoLeft = "",
            CMD_ServoRight = "",
            CMD_ledon = "",
            CMD_ledoff = "";

        private string ControlIp = "192.168.1.1";
        private string Port = "2001";

        public Form1()
        {
            InitializeComponent();

            SetEvents();
        }

        //声明读写INI文件的API函数
        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal,
            int size, string filePath);

        public string ReadIni(string section, string ident, string Default)
        {
            var buffer = new Byte[65535];
            var bufLen = GetPrivateProfileString(section, ident, Default, buffer, buffer.GetUpperBound(0), FileName);
            var s = Encoding.GetEncoding(0).GetString(buffer);
            s = s.Substring(0, bufLen);
            return s.Trim();
        }

        private void SetEvents()
        {
            btnCocheAvanzar.Click += (sender, args) => SendData(CMD_Forward);
            btnCocheRetroceder.Click += (sender, args) => SendData(CMD_Backward);
            btnCocheIzquierda.Click += (sender, args) => SendData(CMD_TurnLeft);
            btnCocheDerecha.Click += (sender, args) => SendData(CMD_TurnRight);
            btnCocheParar.Click += (sender, args) => SendData(CMD_Stop);

            btnLucesOn.Click += (sender, args) => SendData(CMD_ledon);
            btnLucesOff.Click += (sender, args) => SendData(CMD_ledoff);

            btnCamaraArriba.Click += (sender, args) => SendData(CMD_ServoUp);
            btnCamaraAbajo.Click += (sender, args) => SendData(CMD_ServoDown);
            btnCamaraIzquierda.Click += (sender, args) => SendData(CMD_ServoLeft);
            btnCamaraDerecha.Click += (sender, args) => SendData(CMD_ServoRight);

            btnVideo.Click += (sender, args) => timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = CameraIp;// "http://192.168.1.1:8080/?action=snapshot";
        }

        private void SendData(string data)
        {
            try
            {
                var ips = IPAddress.Parse(ControlIp); //("192.168.2.1");
                var ipe = new IPEndPoint(ips, Convert.ToInt32(Port)); //把ip和端口转化为IPEndPoint实例
                var c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //创建一个Socket

                c.Connect(ipe); //连接到服务器

                var bs = Encoding.ASCII.GetBytes(data);
                c.Send(bs, bs.Length, 0); //发送测试信息
                c.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SendData(CMD_TurnLeft1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SendData(CMD_TurnRight1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SendData(CMD_TurnLeft2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SendData(CMD_TurnRight2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var cfg = new Config();
            cfg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetIni();
            btnCocheAvanzar.BackColor = Color.LightBlue;
            btnCocheRetroceder.BackColor = Color.LightBlue;
            btnCocheIzquierda.BackColor = Color.LightBlue;
            btnCocheDerecha.BackColor = Color.LightBlue;
            buttonLeft1.BackColor = Color.LightBlue;
            buttonRight1.BackColor = Color.LightBlue;
            buttonLeft2.BackColor = Color.LightBlue;
            buttonRight2.BackColor = Color.LightBlue;
            btnCocheParar.BackColor = Color.LightBlue;
            btnCamaraArriba.BackColor = Color.LightBlue;
            btnCamaraAbajo.BackColor = Color.LightBlue;
            btnCamaraIzquierda.BackColor = Color.LightBlue;
            btnCamaraDerecha.BackColor = Color.LightBlue;
        }

        private void GetIni()
        {
            CameraIp = ReadIni("VideoUrl", "videoUrl", "");
            ControlIp = ReadIni("ControlUrl", "controlUrl", "");
            Port = ReadIni("ControlPort", "controlPort", "");
            CMD_Forward = ReadIni("ControlCommand", "CMD_Forward", "");
            CMD_Backward = ReadIni("ControlCommand", "CMD_Backward", "");
            CMD_TurnLeft = ReadIni("ControlCommand", "CMD_TurnLeft", "");
            CMD_TurnRight = ReadIni("ControlCommand", "CMD_TurnRight", "");
            CMD_TurnLeft1 = ReadIni("ControlCommand", "CMD_TurnLeft1", "");
            CMD_TurnRight1 = ReadIni("ControlCommand", "CMD_TurnRight1", "");
            CMD_TurnLeft2 = ReadIni("ControlCommand", "CMD_TurnLeft2", "");
            CMD_TurnRight2 = ReadIni("ControlCommand", "CMD_TurnRight2", "");
            CMD_Stop = ReadIni("ControlCommand", "CMD_Stop", "");
            CMD_ServoUp = ReadIni("ControlCommand", "CMD_EngineUp", "");
            CMD_ServoDown = ReadIni("ControlCommand", "CMD_EngineDown", "");
            CMD_ServoLeft = ReadIni("ControlCommand", "CMD_Engineleft", "");
            CMD_ServoRight = ReadIni("ControlCommand", "CMD_Engineright", "");
            CMD_ledon = ReadIni("ControlCommand", "CMD_ledon", "");
            CMD_ledoff = ReadIni("ControlCommand", "CMD_ledoff", "");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                btnCocheAvanzar.BackColor = Color.DarkGray;
                btnCocheAvanzar.PerformClick();
            }
            else if (e.KeyCode == Keys.S)
            {
                btnCocheRetroceder.BackColor = Color.DarkGray;
                btnCocheRetroceder.PerformClick();
            }
            else if (e.KeyCode == Keys.A)
            {
                btnCocheIzquierda.BackColor = Color.DarkGray;
                btnCocheIzquierda.PerformClick();
            }
            else if (e.KeyCode == Keys.D)
            {
                btnCocheDerecha.BackColor = Color.DarkGray;
                btnCocheDerecha.PerformClick();
            }
            else if (e.KeyCode == Keys.Q)
            {
                buttonLeft1.BackColor = Color.DarkGray;
                buttonLeft1.PerformClick();
            }
            else if (e.KeyCode == Keys.E)
            {
                buttonRight1.BackColor = Color.DarkGray;
                buttonRight1.PerformClick();
            }
            else if (e.KeyCode == Keys.Z)
            {
                buttonLeft2.BackColor = Color.DarkGray;
                buttonLeft2.PerformClick();
            }
            else if (e.KeyCode == Keys.C)
            {
                buttonRight2.BackColor = Color.DarkGray;
                buttonRight2.PerformClick();
            }
            else if (e.KeyCode == Keys.X)
            {
                btnCocheParar.BackColor = Color.DarkGray;
                btnCocheParar.PerformClick();
            }
            else if (e.KeyCode == Keys.I)
            {
                btnCamaraArriba.BackColor = Color.DarkGray;
                btnCamaraArriba.PerformClick();
            }
            else if (e.KeyCode == Keys.K)
            {
                btnCamaraAbajo.BackColor = Color.DarkGray;
                btnCamaraAbajo.PerformClick();
            }
            else if (e.KeyCode == Keys.J)
            {
                btnCamaraIzquierda.BackColor = Color.DarkGray;
                btnCamaraIzquierda.PerformClick();
            }
            else if (e.KeyCode == Keys.L)
            {
                btnCamaraDerecha.BackColor = Color.DarkGray;
                btnCamaraDerecha.PerformClick();
            }
            else if (e.KeyCode == Keys.N)
            {
                btnLucesOn.BackColor = Color.DarkGray;
                btnLucesOn.PerformClick();
            }
            else if (e.KeyCode == Keys.M)
            {
                btnLucesOff.BackColor = Color.DarkGray;
                btnLucesOff.PerformClick();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            btnCocheParar.PerformClick();
            btnCocheAvanzar.BackColor = Color.LightBlue;
            btnCocheRetroceder.BackColor = Color.LightBlue;
            btnCocheIzquierda.BackColor = Color.LightBlue;
            btnCocheDerecha.BackColor = Color.LightBlue;
            buttonLeft1.BackColor = Color.LightBlue;
            buttonRight1.BackColor = Color.LightBlue;
            buttonLeft2.BackColor = Color.LightBlue;
            buttonRight2.BackColor = Color.LightBlue;
            btnCamaraArriba.BackColor = Color.LightBlue;
            btnCamaraAbajo.BackColor = Color.LightBlue;
            btnCamaraIzquierda.BackColor = Color.LightBlue;
            btnCamaraDerecha.BackColor = Color.LightBlue;
            btnLucesOn.BackColor = Color.LightBlue;
            btnLucesOff.BackColor = Color.LightBlue;
        }

        private void btnEngineUp_Click(object sender, EventArgs e)
        {
            SendData(CMD_ServoUp);
        }

        private void btnEngineDown_Click(object sender, EventArgs e)
        {
            SendData(CMD_ServoDown);
        }

        private void btnEngineleft_Click(object sender, EventArgs e)
        {
            SendData(CMD_ServoLeft);
        }

        private void btnEngineright_Click(object sender, EventArgs e)
        {
            SendData(CMD_ServoRight);
        }

        private void ledon_Click(object sender, EventArgs e)
        {
            SendData(CMD_ledon);
        }

        private void ledoff_Click(object sender, EventArgs e)
        {
            SendData(CMD_ledoff);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}