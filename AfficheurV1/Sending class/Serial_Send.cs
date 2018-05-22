//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

namespace AfficheurV1
{
    public static class Serial_Send
    {
        public static string Serial_Envoi(string Message)
        {
            try {
                SerialPort PortAffichage = new SerialPort(MainForm.COM_Port);

                ///PortAffichage.Handshake = Handshake.XOnXOff;
                //PortAffichage.Handshake = Handshake.XOnXOff;
                //
                PortAffichage.BaudRate = Convert.ToInt32(MainForm.Baud_Rate);
                //PortAffichage.Parity = System.IO.Ports.Parity.None;
                PortAffichage.DataBits = MainForm.Data_Bits;
                //PortAffichage.StopBits = System.IO.Ports.StopBits.One;

                //MessageBox.Show("'"+ Serial_Settings.Flow_Control+"'");
                switch (MainForm.Parity)
                {
                    case "None":
                        PortAffichage.Parity = System.IO.Ports.Parity.None;
                        break;
                    case "Mark":
                        PortAffichage.Parity = System.IO.Ports.Parity.Mark;
                        break;
                    case "Odd":
                        PortAffichage.Parity = System.IO.Ports.Parity.Odd;
                        break;
                    case "Space":
                        PortAffichage.Parity = System.IO.Ports.Parity.Odd;
                        break;
                    case "Even":
                        PortAffichage.Parity = System.IO.Ports.Parity.Even;
                        break;
                    default:
                        //MessageBox.Show("Error Flow");

                        break;
                }
                switch (MainForm.Stop_Bit/*Convert.ToDouble(Serial_Settings.Stop_Bit)*/)
                {
                    case "1":
                        PortAffichage.StopBits = System.IO.Ports.StopBits.One;
                        break;
                    case "1,5":
                        //PortAffichage.StopBits = System.IO.Ports.StopBits.OnePointFive;
                        PortAffichage.StopBits = System.IO.Ports.StopBits.One;
                        //MessageBox.Show("Error go to dafaut value : 1");

                        break;
                    case "0":
                        //PortAffichage.StopBits = System.IO.Ports.StopBits.None;
                        PortAffichage.StopBits = System.IO.Ports.StopBits.One;
                        //MessageBox.Show("Error go to dafaut value : 1");

                        break;
                    case "2":
                        PortAffichage.StopBits = System.IO.Ports.StopBits.Two;
                        break;
                    default:
                        // MessageBox.Show("Error Stop Bit");

                        break;
                }

                switch (MainForm.Flow_Control)
                {
                    case "None":
                        PortAffichage.Handshake = System.IO.Ports.Handshake.None;
                        break;
                    case "DTR":
                        PortAffichage.Handshake = Handshake.RequestToSend;
                        break;
                    case "XOnXOff":
                        PortAffichage.Handshake = Handshake.XOnXOff;
                        break;
                    default:
                        //MessageBox.Show("Error");

                        break;
                }


                PortAffichage.Open();

                //PortAffichage.Open();

                //PortAffichage.Write(new byte[] { 0xE0, 0xE1, 0xE2 }, 0, 3);

                //string message = "<ID01><L1><PA><FA><Ma><WC><FA><CD>Geraldine0A<E>";


                PortAffichage.Write(Message);


                //while (PortAffichage.ReadChar() == 0) {
                //}



                PortAffichage.Close();
                return "OK " + PortAffichage.ReadChar() + PortAffichage.ReadChar() + PortAffichage.ReadChar();
                //PortAffichage.Close();
            }
            catch
            {
                if (MainForm.Avalable_COM_Port.Count() == 0)
                {
                    return LanguageText_Data_Static.Error_Message_FR[0] + LanguageText_Data_Static.Error_Message_FR[1];
                }
                else
                {
                    return LanguageText_Data_Static.Error_Message_FR[0] + LanguageText_Data_Static.Error_Message_FR[2];
                }
                
            }

            

        }
    }
}
