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
using System.Web;
using System.Diagnostics;

namespace WindowsFormsApp6
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            /* Setup new connection */
            WebClient conn = new WebClient();

            try
            {
                /* Get Internal IP Address */
                IPHostEntry host;
                String getiIP = "";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        getiIP = ip.ToString();
                    }
                }

                /* Get External IP address */
                metroTextBox2.Text = getiIP;

                String geteIP = conn.DownloadString("http://www.passwordrandom.com/query?command=ip");
                metroTextBox1.Text = geteIP;

            } catch (WebException)
            {
                MessageBox.Show("Failed to locate External IP address!\nPlease check your connection.");
                return;
            }

            /* Display */
            MessageBox.Show("IP addresses located!");
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("http://github.com/evelystria/");
        }
    }
}
