using modbus;
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
        private CModbus modbus;
        public Form1()
        {
            InitializeComponent();
            modbus = new CModbus();
        }
        private Socket socket;
        private byte[] trameE;
        private byte[] trameR;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxAdressIP.TextLength > 6)
            {
                string TextAdressIP = textBoxAdressIP.Text;
                textBoxStatut.AppendText("Connexion au serveur 172.17.50.180 \n");
                this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint iped = new IPEndPoint(IPAddress.Parse(TextAdressIP), 502);
                try
                {
                    this.socket.Connect(iped);
                    textBoxStatut.AppendText("Connexion ok \r\n");
                }
                catch (System.Exception ex)
                {
                    this.textBoxStatut.AppendText("**Exception : Impossible de se connecter au serveur" + ex.Message + "\r\n");
                }
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.socket.Close();
                this.textBoxStatut.AppendText("Deconnexion reussie \r\n");
            }
            catch (System.Exception ex)
            {
                this.textBoxStatut.AppendText("Deconnexion impossible" + ex.Message + "\r\n");
            }
        }

        private void buttonLireTension_Click(object sender, EventArgs e)
        {
            var trameE = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x01, 0x03, 0x02, 0x08, 0x93 };
            this.socket.Send(trameE);
            var trameR = new byte[256];
            int nbBytes = this.socket.Receive(trameR);
            int tensionRaw = (trameR[9] << 8) | trameR[10];
            double tension = tensionRaw / 10.0;
            this.textBoxTension.Text = nbBytes.ToString();
        }
    }
}
  
