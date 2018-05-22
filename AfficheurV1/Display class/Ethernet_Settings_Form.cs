using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
//using System.Data;
//using System.Linq;
using System.Net;


namespace AfficheurV1
{
    public partial class Ethernet_Settings_Form : Form
    {
        public Ethernet_Settings_Form()
        {
            InitializeComponent();
            //IP_TextBox.Text

            IP_TextBox.Text = MainForm.AddressIP;
            Port_TextBox.Text = MainForm.PortsIP;
        }
        public byte[] bytes;
        //NetworkStream netStream;

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.AddressIP = IP_TextBox.Text;
            MainForm.PortsIP = Port_TextBox.Text;
            //this.AddressIP = MainForm.AddressIP;
            //this.PortsIP = MainForm.PortsIP;
        }

        private void Port_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 32 || e.KeyChar == 'è' || e.KeyChar == 'ê' || e.KeyChar == 39 || e.KeyChar == '-' || e.KeyChar == 'à' || e.KeyChar == 'é' || (e.KeyChar >= 97 && e.KeyChar <= 122) || Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '#' || (e.KeyChar >= 65 && e.KeyChar <= 90))
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == '\b') // '\b'/* pour supprimer un caractère*/

            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void Ip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 46 || e.KeyChar == '\b') //'\b'/* pour supprimer un caractère*/

            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
