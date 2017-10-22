using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Bai2_Check
{
    public partial class Form1 : Form
    {
        IPEndPoint host;
        TcpClient tcpClient;
        UdpClient udpClient;

        byte[] receive;
        public Form1()
        {
            InitializeComponent();
            initComponents();
        }
        private void initComponents()
        {
            host = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1724);
            tcpClient = new TcpClient();
            udpClient = new UdpClient();
            receive = new byte[0];
        }

        private void btn1_Load(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int port = Convert.ToInt32(txt2.Text);
                host = new IPEndPoint(IPAddress.Parse(txt1.Text), port);

                tcpClient.Connect(host);

                udpClient.Connect(host);
                udpClient.Send(new byte[] { 1 }, 1);        //send 1 byte of 1 as hello packet
                receive = udpClient.Receive(ref host);
            }
            catch (FormatException)
            {
                txt3.Text = "Invalid input format\n";
            }
            catch (ArgumentNullException)
            {
                txt3.Text = "Invalid input format\n";
            }
            catch (SocketException)
            {
                txt3.Text = "Cannot connect to host\n";
            }
            catch (IndexOutOfRangeException exc)
            {
                txt3.Text = exc.Message;
            }
            if (tcpClient.Connected)
            {
                txt3.Text = host.ToString() + " opens for TCP\n";
                tcpClient.Close();
            }
            else
            {
                Console.WriteLine();
            }
            if (receive.Length == 1)
            {
                if (receive[0] == 1)
                {
                    txt3.Text += host.ToString() + " opens for UDP\n";
                    udpClient.Close();
                }
            }
            else
            {
                txt3.Text += host.ToString() + " closed for UDP\n";
                udpClient.Close();
            }
        }
    }
}
