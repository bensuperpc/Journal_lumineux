using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfficheurV1
{
    [Serializable]
    public class Message_Maker
    {
        public string Message{ set; get; }
        public string Enter_Effect { set; get; }
        public string Leave_Effect { set; get; }

        public int Enter_Effect_Index { set; get; }
        public int Leave_Effect_Index { set; get; }

        public string Speed_Display { set; get; }
        public string Text_Color { set; get; }
        public string Page_Number { set; get; }
        public string Display_Number { set; get; }
        public string LRC { get; set; }

        public string COM_Port { set; get; }
        public string[] Avalable_COM_Port { set; get; }
        public string Baud_Rate { set; get; }
        public string Stop_Bit { set; get; }
        public Byte Data_Bits { set; get; }
        public string Parity { set; get; }
        public string Flow_Control { set; get; }
        public int Number_Command { set; get; }
        public int Number_Of_Byte_Of_This_Command { set; get; }

        public string AddressIP { set; get; }
        public string PortsIP { set; get; }

        public string Message_Send_String { set; get; }
        public static int Number_Instance_Static { set; get; }
        //public bool Command_Calc_OK { set; get; }

        public Message_Maker(string Message, int Enter_Effect_Index, int Leave_Effect_Index, string Speed_Display, string Text_Color, string Page_Number, string Display_Number)
        {
            Number_Instance_Static = Number_Instance_Static + 1;
            this.Message = Message;

            //this.Enter_Effect = Enter_Effect;
            //this.Leave_Effect = Leave_Effect;

            this.Enter_Effect_Index = Enter_Effect_Index;
            this.Leave_Effect_Index = Leave_Effect_Index;
            //MessageBox.Show(this.Enter_Effect_Index.ToString());
            this.Speed_Display = Speed_Display;
            this.Text_Color = Text_Color;
            this.Page_Number = Page_Number;
            this.Display_Number = Display_Number;
            this.LRC = "";

            //Pour Historique
            if (MainForm.Serial_Comm_True_Ethernet_False == true)
            {
                this.COM_Port = MainForm.COM_Port;
                this.Avalable_COM_Port = MainForm.Avalable_COM_Port;
                this.Baud_Rate = MainForm.Baud_Rate;
                this.Stop_Bit = MainForm.Stop_Bit;
                this.Data_Bits = MainForm.Data_Bits;
                this.Parity = MainForm.Parity;
                this.Flow_Control = MainForm.Flow_Control;
            } else {
                this.AddressIP = MainForm.AddressIP;
                this.PortsIP = MainForm.PortsIP;
            }

            //FIN//Pour Historique

            this.Number_Command = Number_Instance_Static;
            //this.Number_Command = Number_Instance_Static;
            this.Message_Send_String = Message_Send_Prog(); //pour la creation d'un message
            //this.Command_Calc_OK = true;
        }
        public Message_Maker()
        {
            Number_Instance_Static = Number_Instance_Static + 1;
        }
        private string Message_Send_Prog()
        {

                string Message_Send_String_local;
                Message_Send_String_local = Display_Number_Fonc(this.Display_Number) + "<L1>" + Page_Number_Fonc(this.Page_Number) + Enter_And_Left_effect(this.Enter_Effect_Index) + Speed_Display_Fonc(this.Speed_Display) + "<WC>" + Enter_And_Left_effect(this.Leave_Effect_Index) + Text_Color_Fonc(this.Text_Color) + this.Message;
                Message_Send_String_local = Message_Send_String_local + calculateLRC(Message_Send_String_local) + "<E>";
            this.Number_Of_Byte_Of_This_Command = Message_Send_String_local.Count();
                return Message_Send_String_local;

        }


        private string calculateLRC(string messageLRC)
        {
            


            int CS = 0;

            //b = Encoding.ASCII.GetBytes(messageLRC.Substring(0,messageLRC.Length-3));

            string input = messageLRC.Substring(0, messageLRC.Length);
            input = input.Substring(6, input.Length - 6);
            char[] values = input.ToCharArray();
            foreach (char letter in values)
            {
                // Get the integral value of the character.
                int value = Convert.ToInt32(letter);
                CS = value ^ CS;

            }

            
            string hexValue = CS.ToString("X");
            this.LRC = hexValue;
            return hexValue;
        }

        private string Text_Color_Fonc(string Text_Color)
        {
            string[] Text_Color_List = { "<CA>", "<CD>", "<CH>", "<CL>","<CM>","<CN>","<CP>","<CQ>","<CR>","<CS>" };

            int n = -1;

            if (Text_Color == LanguageText_Data_Static.Text_color_FR[0] || Text_Color == LanguageText_Data_Static.Text_color_EN[0] || Text_Color == LanguageText_Data_Static.Text_color_SP[0])
            {
                n = 0;
                //MessageBox.Show(n.ToString());
            }
            else if (Text_Color == LanguageText_Data_Static.Text_color_FR[1] || Text_Color == LanguageText_Data_Static.Text_color_EN[1] || Text_Color == LanguageText_Data_Static.Text_color_SP[1])
            {
                n = 1;
                //MessageBox.Show(n.ToString());
            }
            else if (Text_Color == LanguageText_Data_Static.Text_color_FR[2] || Text_Color == LanguageText_Data_Static.Text_color_EN[2] || Text_Color == LanguageText_Data_Static.Text_color_SP[2])
            {
                n = 2;
                //MessageBox.Show(n.ToString());
            }
            else if (Text_Color == LanguageText_Data_Static.Text_color_FR[3] || Text_Color == LanguageText_Data_Static.Text_color_EN[3] || Text_Color == LanguageText_Data_Static.Text_color_SP[3])
            {
                n = 3;
                //MessageBox.Show(n.ToString());
            }
            else if (Text_Color == LanguageText_Data_Static.Text_color_FR[4] || Text_Color == LanguageText_Data_Static.Text_color_EN[4] || Text_Color == LanguageText_Data_Static.Text_color_SP[4])
            {
                n = 4;
            }
            else if (Text_Color == LanguageText_Data_Static.Text_color_FR[5] || Text_Color == LanguageText_Data_Static.Text_color_EN[5] || Text_Color == LanguageText_Data_Static.Text_color_SP[5])
            {
                n = 5;
            }
            else if (Text_Color == LanguageText_Data_Static.Text_color_FR[6] || Text_Color == LanguageText_Data_Static.Text_color_EN[6] || Text_Color == LanguageText_Data_Static.Text_color_SP[6])
            {
                n = 6;
            }
            else if (Text_Color == LanguageText_Data_Static.Text_color_FR[7] || Text_Color == LanguageText_Data_Static.Text_color_EN[7] || Text_Color == LanguageText_Data_Static.Text_color_SP[7])
            {
                n = 7;
            }
            else if (Text_Color == LanguageText_Data_Static.Text_color_FR[8] || Text_Color == LanguageText_Data_Static.Text_color_EN[8] || Text_Color == LanguageText_Data_Static.Text_color_SP[8])
            {
                n = 8;
            }
            else if (Text_Color == LanguageText_Data_Static.Text_color_FR[9] || Text_Color == LanguageText_Data_Static.Text_color_EN[9] || Text_Color == LanguageText_Data_Static.Text_color_SP[9])
            {
                n = 9;
            }

            return Text_Color_List[n];
        }

        private string Speed_Display_Fonc(string Speed_Display)
        {
            string[] Enter_Effect_List = {"<Mq>","<Ma>","<MQ>","<MA>"};
            int n = -1;

            if (Speed_Display == LanguageText_Data_Static.Speed_FR[0] || Speed_Display == LanguageText_Data_Static.Speed_EN[0] || Speed_Display == LanguageText_Data_Static.Speed_SP[0])
            {
                n = 0;
                //MessageBox.Show(n.ToString());
            }
            else if (Speed_Display == LanguageText_Data_Static.Speed_FR[1] || Speed_Display == LanguageText_Data_Static.Speed_EN[1] || Speed_Display == LanguageText_Data_Static.Speed_SP[1])
            {
                n = 1;
                //MessageBox.Show(n.ToString());
            }
            else if (Speed_Display == LanguageText_Data_Static.Speed_FR[2] || Speed_Display == LanguageText_Data_Static.Speed_EN[2] || Speed_Display == LanguageText_Data_Static.Speed_SP[2])
            {
                n = 2;
                //MessageBox.Show(n.ToString());
            }
            else if (Speed_Display == LanguageText_Data_Static.Speed_FR[3] || Speed_Display == LanguageText_Data_Static.Speed_EN[3] || Speed_Display == LanguageText_Data_Static.Speed_SP[3])
            {
                n = 3;
                //MessageBox.Show(n.ToString());
            }

            return Enter_Effect_List[n];
        }

        private string Display_Number_Fonc(string Display_Number)
        {
            return "<"+ "ID"+Display_Number + ">";
        }
        private string Page_Number_Fonc(string Page_Number)
        {
            switch (Page_Number)
            {
                case "Page 1":
                    Page_Number = "PA";
                    break;
                case "Page 2":
                    Page_Number = "PB";
                    break;
                case "Page 3":
                    Page_Number = "PC";
                    break;
                case "Page 4":
                    Page_Number = "PD";
                    break;
                case "Page 5":
                    Page_Number = "PE";
                    break;
                default:
                    MessageBox.Show("Error");
                    Page_Number = "null";
                    break;
            }
            return "<" + Page_Number + ">";
        }

        private string Enter_And_Left_effect(int Effect)
        {
            string[] Effect_List = { "<FA>", "<FC>", "<FD>", "<FE>", "<FF>", "<FI>", "<FJ>", "<FL>" };


            return Effect_List[Effect];
        }



            private string Enter_Effect_Fonc(string Enter_Effect)
        {

            string[] Enter_Effect_List = { "<FA>","<FC>", "<FD>", "<FE>", "<FF>", "<FI>", "<FJ>", "<FL>" };
            //<FA> Aucune transition
            //<FC> Bas vers le haut
            //<FD> haut vers le bas
            //<FE> Scroll left
            //<FF> Scroll right
            //<FI> Scroll up
            //<FJ> Scroll down
            //<FL> Effet neige

            int n = -1;

            if (Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_FR[0] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_EN[0] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_SP[0])
            {
                n = 0;
                //MessageBox.Show(n.ToString());
            } else if (Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_FR[1] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_EN[1] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_SP[1])
            {
                n = 1;
                //MessageBox.Show(n.ToString());
            } else if (Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_FR[2] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_EN[2] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_SP[2])
            {
                n = 2;
                //MessageBox.Show(n.ToString());
            } else if (Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_FR[3] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_EN[3] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_SP[3])
            {
                n = 3;
                //MessageBox.Show(n.ToString());
            } else if (Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_FR[4] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_EN[4] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_SP[4])
            {
                n = 4;
            } else if (Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_FR[5] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_EN[5] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_SP[5])
            {
                n = 5;
            } else if (Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_FR[6] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_EN[6] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_SP[6])
            {
                n = 6;
            }
            else if (Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_FR[7] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_EN[7] || Enter_Effect == LanguageText_Data_Static.Enter_Effect_Static_SP[7])
            {
                n = 7;
            }


            return Enter_Effect_List[n];
        }
        private string Leave_Effect_Fonc(string Leave_Effect)
        {
            string[] Leave_Effect_List = { "<FA>", "<FC>", "<FD>", "<FE>", "<FF>", "<FI>", "<FJ>", "<FL>" };

            int n = -1;

            if (Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_FR[0] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_EN[0] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_SP[0])
            {
                n = 0;
                //MessageBox.Show(n.ToString());
            }
            else if (Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_FR[1] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_EN[1] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_SP[1])
            {
                n = 1;
                //MessageBox.Show(n.ToString());
            }
            else if (Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_FR[2] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_EN[2] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_SP[2])
            {
                n = 2;
                //MessageBox.Show(n.ToString());
            }
            else if (Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_FR[3] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_EN[3] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_SP[3])
            {
                n = 3;
                //MessageBox.Show(n.ToString());
            }
            else if (Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_FR[4] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_EN[4] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_SP[4])
            {
                n = 4;
            }
            else if (Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_FR[5] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_EN[5] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_SP[5])
            {
                n = 5;
            }
            else if (Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_FR[6] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_EN[6]|| Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_SP[6])
            {
                n = 6;
            }
            else if (Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_FR[7] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_EN[7] || Leave_Effect == LanguageText_Data_Static.Left_Effect_Static_SP[7])
            {
                n = 7;
            }

            return Leave_Effect_List[n];
        }




    }
}
