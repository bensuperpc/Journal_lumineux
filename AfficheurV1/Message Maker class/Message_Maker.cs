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

        public int Enter_Effect_Index { set; get; }
        public int Leave_Effect_Index { set; get; }
        public int Text_Color_Index { set; get; }
        public int Speed_Display_Index { set; get; }
        public int Line_Number_Display_Index { set; get; }


        public string Speed_Display { set; get; }
        public int Page_Number { set; get; }
        public int Display_Number { set; get; }
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

        public Message_Maker(string Message, int Enter_Effect_Index, int Leave_Effect_Index, int Speed_Display_Index, int Text_Color_Index, int Page_Number_Index, int Display_Number_Index,int Line_Number_Display_Index)
        {
            Number_Instance_Static = Number_Instance_Static + 1;
            this.Message = Message;



            this.Enter_Effect_Index = Enter_Effect_Index;
            this.Leave_Effect_Index = Leave_Effect_Index;
            this.Speed_Display_Index = Speed_Display_Index;
            this.Text_Color_Index = Text_Color_Index;
            this.Page_Number = Page_Number_Index;
            this.Display_Number = Display_Number_Index;
            this.Line_Number_Display_Index = Line_Number_Display_Index;
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
                Message_Send_String_local = Display_Number_Fonc(this.Display_Number) + Line_Number_Display_Fonc(this.Line_Number_Display_Index)+ Page_Number_Fonc(this.Page_Number) + Enter_And_Left_effect(this.Enter_Effect_Index) + Speed_Display_Fonc(this.Leave_Effect_Index) + "<WC>" + Enter_And_Left_effect(this.Leave_Effect_Index) + Text_Color_Fonc(this.Text_Color_Index) + this.Message;
                Message_Send_String_local = Message_Send_String_local + calculateLRC(Message_Send_String_local) + "<E>";
            this.Number_Of_Byte_Of_This_Command = Message_Send_String_local.Count();
                return Message_Send_String_local;

        }

        private string Line_Number_Display_Fonc(int Line_Number_Display)

        {
      
            return "<"+"L"+Line_Number_Display.ToString() +">";
        }


        private string calculateLRC(string messageLRC)
        {
            int CS = 0;
            string input = messageLRC.Substring(0, messageLRC.Length);
            input = input.Substring(6, input.Length - 6);
            char[] values = input.ToCharArray();
            foreach (char letter in values)
            {
                int value = Convert.ToInt32(letter);
                CS = value ^ CS;
            }
            string hexValue = CS.ToString("X");
            this.LRC = hexValue;
            return hexValue;
        }

        private string Text_Color_Fonc(int Text_Color)
        {
            string[] Text_Color_List = { "<CA>", "<CD>", "<CH>", "<CL>","<CM>","<CN>","<CP>","<CQ>","<CR>","<CS>" };
            return Text_Color_List[Text_Color];
        }

        private string Speed_Display_Fonc(int Speed_Display)
        {
            string[] Enter_Effect_List = {"<Mq>","<Ma>","<MQ>","<MA>"};
            return Enter_Effect_List[Speed_Display];
        }

        private string Display_Number_Fonc(int Display_Number)
        {
            string[] Display_Number_List = { "<ID01>", "<ID02>", "<ID03>", "<ID04>", "<ID05>", "<ID06>" };
            return Display_Number_List[Display_Number];
        }

        private string Page_Number_Fonc(int Page_Number)
        {
            string[] Text_Color_List = {"<PA>", "<PB>", "<PC>", "<PD>", "<PE>"};
            return Text_Color_List[Page_Number];
        }

        private string Enter_And_Left_effect(int Effect)
        {
            string[] Effect_List = { "<FA>", "<FC>", "<FD>", "<FE>", "<FF>", "<FI>", "<FJ>", "<FL>"};
            return Effect_List[Effect];
        }




    }
}
