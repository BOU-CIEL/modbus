using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Modbus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Socket socket;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if (textBoxAdressIP.TextLength > 6)
            {
                string TextAdressIP = textBoxAdressIP.Text;
                textBox2.AppendText("Connexion au serveur 172.17.50.180 \n");
                this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint iped = new IPEndPoint(IPAddress.Parse(TextAdressIP), 502);
                try
                {
                    this.socket.Connect(iped);
                    textBox2.AppendText("Connexion ok \r\n");
                }
                catch(System.Exception ex) 
                {
                    this.textBox2.AppendText("**Exception : Impossible de se connecter au serveur" + ex.Message + "\r\n");
                }
            }
            

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.socket.Close();
                this.textBox2.AppendText("Deconnexion reussie \r\n");
            }
            catch (System.Exception ex)
            {
                this.textBox2.AppendText("Deconnexion impossible" + ex.Message + "\r\n");
            }
        }
    }
}
