using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using System.IO.Ports;
using System.Threading;
using System.Runtime.InteropServices;
using System.Net.Sockets;


namespace AfficheurV1
{
    public partial class MainForm : Form
    {
        //Variables synchronisées 
        public static string COM_Port { set; get; }

        public static string Baud_Rate = "9600";
        public static string Stop_Bit = "1";
        public static Byte Data_Bits = 8;
        public static string Parity = "None";
        public static string Flow_Control = "None";


        public static string Message { set; get; }
        public static string Enter_Effect { set; get; }
        public static string Leave_Effect { set; get; }

        public static int Enter_Effect_Index = 0;
        public static int Leave_Effect_Index = 0;

        public static string Speed_Display { set; get; }
        public static string Text_Color { set; get; }
        public static string Page_Number { set; get; }
        public static string Display_Number { set; get; }
        public static bool Serial_Comm_True_Ethernet_False { set; get; }

        public static string AddressIP { get; set; }
        public static string PortsIP { get; set; }

        public static string[] Avalable_COM_Port
        {
            get { return SerialPort.GetPortNames(); }
            set {; }
        }



        public MainForm()
        {
            InitializeComponent();
            //this.Avalable_COM_Port_MainForm = SerialPort.GetPortNames();

            /*
            MainForm.Baud_Rate = "9600";
            MainForm.Stop_Bit = "1";
            MainForm.COM_Port = "";//probleme sur la form Serial settings !
            MainForm.Data_Bits = 8;
            MainForm.Parity = "None";
            MainForm.Flow_Control = "None";
            */
            MainForm.Serial_Comm_True_Ethernet_False = true;


            LanguageText_Data_Static.CurrentLanguage_Static = "FR";
            LanguageForm languageForm = new LanguageForm("Language");
            if (languageForm.ShowDialog() == DialogResult.OK)
            {
                Language_Change(LanguageText_Data_Static.CurrentLanguage_Static);
            }
            else
            {
                System.Environment.Exit(0);
            }
            Serial_Settings_Form serial_Settings = new Serial_Settings_Form();
            if (serial_Settings.ShowDialog() == DialogResult.OK){ }
        }

        Command_History_Class command_History = new Command_History_Class();




        private void Language_Change_Button_Click(object sender, EventArgs e)
        {

            LanguageForm languageForm = new LanguageForm("Language");

            if (languageForm.ShowDialog() == DialogResult.OK)
            {
                languageForm.Close();
                Language_Change(LanguageText_Data_Static.CurrentLanguage_Static);
            }


        }
        private void Language_Change(string Language)
        {

            if (Language == null || LanguageText_Data_Static.CurrentLanguage_Static == null)
            {
                MessageBox.Show("La langue par defaut est choisie 'FR' ");
                LanguageText_Data_Static.CurrentLanguage_Static = LanguageText_Data_Static.DefaultLanguage_Static();
                Language_Change("FR");
            }
            else
            {
                //Speed_ComboBox.Text
                Speed_ComboBox.Items.Clear();
                Text_Effet_Sortie_ComboBox.Items.Clear();
                Text_Effet_Entre_ComboBox.Items.Clear();
                Text_color_ComboBox.Items.Clear();
                switch (LanguageText_Data_Static.CurrentLanguage_Static)
                {
                    //Text_color_EN
                    case "FR":
                        for (int i = 0; i <= LanguageText_Data_Static.Speed_FR.Length - 1; i++)
                        {
                            Speed_ComboBox.Items.Add(LanguageText_Data_Static.Speed_FR[i]);
                        }
                        Speed_ComboBox.Text = LanguageText_Data_Static.Speed_FR[0];

                        for (int i = 0; i <= LanguageText_Data_Static.Left_Effect_Static_FR.Length - 1; i++)
                        {
                            Text_Effet_Sortie_ComboBox.Items.Add(LanguageText_Data_Static.Left_Effect_Static_FR[i]);
                            Text_Effet_Entre_ComboBox.Items.Add(LanguageText_Data_Static.Enter_Effect_Static_FR[i]);

                        }
                        Text_Effet_Sortie_ComboBox.Text = LanguageText_Data_Static.Left_Effect_Static_FR[0];
                        Text_Effet_Entre_ComboBox.Text = LanguageText_Data_Static.Enter_Effect_Static_FR[0];

                        for (int i = 0; i <= LanguageText_Data_Static.Text_color_FR.Length - 1; i++)
                        {
                            Text_color_ComboBox.Items.Add(LanguageText_Data_Static.Text_color_FR[i]);
                        }
                        Text_color_ComboBox.Text = LanguageText_Data_Static.Text_color_FR[0];



                        Dispay_Number_Label.Text = LanguageText_Data_Static.Label_FR[0];
                        Page_of_Message_Label.Text = LanguageText_Data_Static.Label_FR[1];
                        Message_label.Text = LanguageText_Data_Static.Label_FR[2];
                        Transition_appearance_message_Label.Text = LanguageText_Data_Static.Label_FR[3];
                        Transition_Disappearance_message_label.Text = LanguageText_Data_Static.Label_FR[4];
                        Scroll_Speed_Label.Text = LanguageText_Data_Static.Label_FR[5];
                        Text_color_Label.Text = LanguageText_Data_Static.Label_FR[6];
                        Message_label.Text = LanguageText_Data_Static.Label_FR[7];

                        Page_Settings_GroupBox.Text = LanguageText_Data_Static.GroupeBox_FR[0];
                        Verbose_Serial_GroupBox.Text = LanguageText_Data_Static.GroupeBox_FR[1];
                        General_Settings_GroupBox.Text = LanguageText_Data_Static.GroupeBox_FR[2];
                        Message_GroupBox.Text = LanguageText_Data_Static.GroupeBox_FR[3];
                        Display_Settings_GroupBox.Text = LanguageText_Data_Static.GroupeBox_FR[4];
                        Settings_Display_GroupBox.Text = LanguageText_Data_Static.GroupeBox_FR[5];

                        if (MainForm.Serial_Comm_True_Ethernet_False == true)
                        {
                            RS232_Settings_Button.Text = LanguageText_Data_Static.Button_FR[0];
                        }
                        else
                        {
                            RS232_Settings_Button.Text = LanguageText_Data_Static.Button_FR[9];
                        }


                        Light_Plus_button.Text = LanguageText_Data_Static.Button_FR[1];
                        Light_Moins_button.Text = LanguageText_Data_Static.Button_FR[2];
                        Change_Language_Button.Text = LanguageText_Data_Static.Button_FR[3];
                        Export_to_XML_Button.Text = LanguageText_Data_Static.Button_FR[4];
                        Drawing_Button.Text = LanguageText_Data_Static.Button_FR[5];
                        Val_Button.Text = LanguageText_Data_Static.Button_FR[6];
                        Info_LRC_Button.Text = LanguageText_Data_Static.Button_FR[7];
                        OK_Button.Text = LanguageText_Data_Static.Button_FR[8];


                        break;
                    case "EN":
                        for (int i = 0; i <= LanguageText_Data_Static.Speed_EN.Length - 1; i++)
                        {
                            Speed_ComboBox.Items.Add(LanguageText_Data_Static.Speed_EN[i]);
                        }
                        Speed_ComboBox.Text = LanguageText_Data_Static.Speed_EN[0];

                        for (int i = 0; i <= LanguageText_Data_Static.Left_Effect_Static_EN.Length - 1; i++)
                        {
                            Text_Effet_Sortie_ComboBox.Items.Add(LanguageText_Data_Static.Left_Effect_Static_EN[i]);
                            Text_Effet_Entre_ComboBox.Items.Add(LanguageText_Data_Static.Enter_Effect_Static_EN[i]);

                        }
                        Text_Effet_Sortie_ComboBox.Text = LanguageText_Data_Static.Left_Effect_Static_EN[0];
                        Text_Effet_Entre_ComboBox.Text = LanguageText_Data_Static.Enter_Effect_Static_EN[0];

                        for (int i = 0; i <= LanguageText_Data_Static.Text_color_EN.Length - 1; i++)
                        {
                            Text_color_ComboBox.Items.Add(LanguageText_Data_Static.Text_color_EN[i]);
                        }
                        Text_color_ComboBox.Text = LanguageText_Data_Static.Text_color_EN[0];

                        Dispay_Number_Label.Text = LanguageText_Data_Static.Label_EN[0];
                        Page_of_Message_Label.Text = LanguageText_Data_Static.Label_EN[1];
                        Message_label.Text = LanguageText_Data_Static.Label_EN[2];
                        Transition_appearance_message_Label.Text = LanguageText_Data_Static.Label_EN[3];
                        Transition_Disappearance_message_label.Text = LanguageText_Data_Static.Label_EN[4];
                        Scroll_Speed_Label.Text = LanguageText_Data_Static.Label_EN[5];
                        Text_color_Label.Text = LanguageText_Data_Static.Label_EN[6];
                        Message_label.Text = LanguageText_Data_Static.Label_EN[7];


                        Page_Settings_GroupBox.Text = LanguageText_Data_Static.GroupeBox_EN[0];
                        Verbose_Serial_GroupBox.Text = LanguageText_Data_Static.GroupeBox_EN[1];
                        General_Settings_GroupBox.Text = LanguageText_Data_Static.GroupeBox_EN[2];
                        Message_GroupBox.Text = LanguageText_Data_Static.GroupeBox_EN[3];
                        Display_Settings_GroupBox.Text = LanguageText_Data_Static.GroupeBox_EN[4];
                        Settings_Display_GroupBox.Text = LanguageText_Data_Static.GroupeBox_EN[5];

                        if (MainForm.Serial_Comm_True_Ethernet_False == true)
                        {
                            RS232_Settings_Button.Text = LanguageText_Data_Static.Button_EN[0];
                        }
                        else
                        {
                            RS232_Settings_Button.Text = LanguageText_Data_Static.Button_EN[9];
                        }
                        Light_Plus_button.Text = LanguageText_Data_Static.Button_EN[1];
                        Light_Moins_button.Text = LanguageText_Data_Static.Button_EN[2];
                        Change_Language_Button.Text = LanguageText_Data_Static.Button_EN[3];
                        Export_to_XML_Button.Text = LanguageText_Data_Static.Button_EN[4];
                        Drawing_Button.Text = LanguageText_Data_Static.Button_EN[5];
                        Val_Button.Text = LanguageText_Data_Static.Button_EN[6];
                        Info_LRC_Button.Text = LanguageText_Data_Static.Button_EN[7];
                        OK_Button.Text = LanguageText_Data_Static.Button_EN[8];

                        break;
                    case "SP":
                        for (int i = 0; i <= LanguageText_Data_Static.Speed_SP.Length - 1; i++)
                        {
                            Speed_ComboBox.Items.Add(LanguageText_Data_Static.Speed_SP[i]);
                        }
                        Speed_ComboBox.Text = LanguageText_Data_Static.Speed_SP[0];

                        for (int i = 0; i <= LanguageText_Data_Static.Left_Effect_Static_SP.Length - 1; i++)
                        {
                            Text_Effet_Sortie_ComboBox.Items.Add(LanguageText_Data_Static.Left_Effect_Static_SP[i]);
                            Text_Effet_Entre_ComboBox.Items.Add(LanguageText_Data_Static.Enter_Effect_Static_SP[i]);

                        }
                        Text_Effet_Sortie_ComboBox.Text = LanguageText_Data_Static.Left_Effect_Static_SP[0];
                        Text_Effet_Entre_ComboBox.Text = LanguageText_Data_Static.Enter_Effect_Static_SP[0];

                        for (int i = 0; i <= LanguageText_Data_Static.Text_color_SP.Length - 1; i++)
                        {
                            Text_color_ComboBox.Items.Add(LanguageText_Data_Static.Text_color_SP[i]);
                        }
                        Text_color_ComboBox.Text = LanguageText_Data_Static.Text_color_SP[0];

                        Dispay_Number_Label.Text = LanguageText_Data_Static.Label_SP[0];
                        Page_of_Message_Label.Text = LanguageText_Data_Static.Label_SP[1];
                        Message_label.Text = LanguageText_Data_Static.Label_SP[2];
                        Transition_appearance_message_Label.Text = LanguageText_Data_Static.Label_SP[3];
                        Transition_Disappearance_message_label.Text = LanguageText_Data_Static.Label_SP[4];
                        Scroll_Speed_Label.Text = LanguageText_Data_Static.Label_SP[5];
                        Text_color_Label.Text = LanguageText_Data_Static.Label_SP[6];
                        Message_label.Text = LanguageText_Data_Static.Label_SP[7];


                        Page_Settings_GroupBox.Text = LanguageText_Data_Static.GroupeBox_SP[0];
                        Verbose_Serial_GroupBox.Text = LanguageText_Data_Static.GroupeBox_SP[1];
                        General_Settings_GroupBox.Text = LanguageText_Data_Static.GroupeBox_SP[2];
                        Message_GroupBox.Text = LanguageText_Data_Static.GroupeBox_SP[3];
                        Display_Settings_GroupBox.Text = LanguageText_Data_Static.GroupeBox_SP[4];
                        Settings_Display_GroupBox.Text = LanguageText_Data_Static.GroupeBox_SP[5];

                        if (MainForm.Serial_Comm_True_Ethernet_False == true)
                        {
                            RS232_Settings_Button.Text = LanguageText_Data_Static.Button_SP[0];
                        }
                        else
                        {
                            RS232_Settings_Button.Text = LanguageText_Data_Static.Button_SP[9];
                        }
                        Light_Plus_button.Text = LanguageText_Data_Static.Button_SP[1];
                        Light_Moins_button.Text = LanguageText_Data_Static.Button_SP[2];
                        Change_Language_Button.Text = LanguageText_Data_Static.Button_SP[3];
                        Export_to_XML_Button.Text = LanguageText_Data_Static.Button_SP[4];
                        Drawing_Button.Text = LanguageText_Data_Static.Button_SP[5];
                        Val_Button.Text = LanguageText_Data_Static.Button_SP[6];
                        Info_LRC_Button.Text = LanguageText_Data_Static.Button_SP[7];
                        OK_Button.Text = LanguageText_Data_Static.Button_SP[8];

                        break;
                    default:
                        break;
                }
            }

        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (command_History.Command_History_List.Count() > 3000)
            {
                command_History.Command_History_List.Clear();
                Serial_Input_TextBox.Clear();
            }

            command_History.Command_History_List.Add(new Message_Maker(Text_Message_TextBox.Text, MainForm.Enter_Effect_Index, MainForm.Leave_Effect_Index, Speed_ComboBox.Text, Text_color_ComboBox.Text, Numero_de_Page_ComboBox.Text, Numero_Afficheur_ComboBox.Text));
           // MessageBox.Show(command_History.Command_History_List[command_History.Command_History_List.Count - 1].Enter_Effect_Index.ToString());

            try
            {
                ThreadOfMessage.RunWorkerAsync(); // Démarre un thread
            }
            catch
            {
                ThreadOfMessage.CancelAsync();
                Serial_Input_TextBox.Text += "Annulation du Tread precedent et demarrage d'un nouveau thread" + "\r\n";
                ThreadOfMessage.RunWorkerAsync();
            }


        }

        private void RS232_Settings_Button_Click(object sender, EventArgs e)
        {
            //Serial_Input_TextBox.Text += "Port" + "\r\n";
            if (MainForm.Serial_Comm_True_Ethernet_False == true)
            {
                Serial_Settings_Form serial_Settings = new Serial_Settings_Form();

                if (serial_Settings.ShowDialog() == DialogResult.OK)
                {
                    //Language_Change(languageForm.Loading_MainForm_Language);
                }
            }
            else
            {
                Ethernet_Settings_Form ethernet_Settings_Form = new Ethernet_Settings_Form();

                if (ethernet_Settings_Form.ShowDialog() == DialogResult.OK)
                {
                    //Language_Change(languageForm.Loading_MainForm_Language);
                }

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Text_Text_Message_TextBox(object sender, EventArgs e)
        {
            MainForm.Message = Text_Message_TextBox.Text;

        } //bricosimple 5 minutes craft

        private void Text_Effet_Entre_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LanguageText.Effet_Entre_Static_FR[0];
            //MainForm.Enter_Effect = this.Text_Effet_Entre_ComboBox.Text;
            Enter_Effect_Index = Text_Effet_Entre_ComboBox.SelectedIndex;

        //MessageBox.Show(this.Text_Effet_Entre_ComboBox.SelectedIndex.ToString());

        }
        private void Text_Effet_Sortie_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MainForm.Leave_Effect = this.Text_Effet_Sortie_ComboBox.Text;
            Leave_Effect_Index = Text_Effet_Sortie_ComboBox.SelectedIndex;
            //MessageBox.Show(this.Text_Effet_Sortie_ComboBox.SelectedIndex.ToString());
        }


        private void Numero_Afficheur_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Numero_de_Page_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Text_Effet_Entre_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Text_Effet_Sortie_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Speed_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Text_color_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Serial_Input_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Export_to_XML_Button_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter("Historique.xml");
                new XmlSerializer(typeof(Command_History_Class)).Serialize(writer, command_History);
                writer.Close();
                Serial_Input_TextBox.Text += "Export. XML OK :)" + "\r\n";
            } catch
            {
                Serial_Input_TextBox.Text += "Error !"+  "\r\n";
            }
        }



        private void Speed_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.Speed_Display = Speed_ComboBox.Text;
        }

        private void Text_color_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.Text_Color = Text_color_ComboBox.Text;
        }

        private void Numero_Afficheur_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.Display_Number = Numero_Afficheur_ComboBox.Text;
        }

        private void Numero_de_Page_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm.Page_Number = Numero_de_Page_ComboBox.Text;
        }

        private void Verbose_Serial_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Drawing_Button_Click(object sender, EventArgs e)
        {
            Drawing serial_Settings = new Drawing();

            if (serial_Settings.ShowDialog() == DialogResult.OK)
            {

            }
        }

        //==========================================================================Thread 1========================================================
        //==========================================================================Thread 1========================================================
        //==========================================================================Thread 1========================================================
        private void ThreadOfMessage_DoWork(object sender, DoWorkEventArgs e)
        {

            string Return_Message = "Null";

            try
            {
                if (MainForm.Serial_Comm_True_Ethernet_False == true)
                {
                    Return_Message = Serial_Send.Serial_Envoi(command_History.Command_History_List[command_History.Command_History_List.Count() - 1].Message_Send_String);
                }
                else
                {
                    Return_Message = Ethernet_Send.Ethernet_Envoi(command_History.Command_History_List[command_History.Command_History_List.Count() - 1].Message_Send_String);
                }



                
                

                this.Invoke(new MethodInvoker(delegate { Serial_Input_TextBox.Text += command_History.Command_History_List[command_History.Command_History_List.Count - 1].Message_Send_String + "\r\n"; }));
                this.Invoke(new MethodInvoker(delegate { Serial_Input_TextBox.Text += "Nombre d'Octet (Byte) :" + /*Math.Ceiling(System.Convert.ToDouble(*/command_History.Command_History_List[command_History.Command_History_List.Count() - 1].Number_Of_Byte_Of_This_Command.ToString() + "\r\n"; }));

                this.Invoke(new MethodInvoker(delegate { LRC_Label.Text = command_History.Command_History_List[command_History.Command_History_List.Count - 1].LRC; }));
                this.Invoke(new MethodInvoker(delegate { Serial_Input_TextBox.Text += "Retour :" + Return_Message + "\r\n"; }));

                this.Invoke(new MethodInvoker(delegate { OK_Button.BackColor = Color.DarkOliveGreen; }));//Remove this ? 



            }
            catch
            {
                //MessageBox.Show("Le Thread N°1 à rencontré une erreur !");
                this.Invoke(new MethodInvoker(delegate { Serial_Input_TextBox.Text += "Le Thread N°1 à rencontré une erreur !" + "\r\n"; }));
                this.Invoke(new MethodInvoker(delegate { OK_Button.BackColor = Color.DarkRed; }));
            }

        }
        private void Serial_True_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Serial_Comm_True_Ethernet_False = true;

            if (LanguageText_Data_Static.CurrentLanguage_Static == "EN")
            {
                RS232_Settings_Button.Text = LanguageText_Data_Static.Button_EN[0];
                RS232_Settings_Button.BackColor = Color.DarkGreen;
            }
            else
            {
                RS232_Settings_Button.Text = LanguageText_Data_Static.Button_FR[0];
                RS232_Settings_Button.BackColor = Color.DarkGreen;
            }
        }

        private void Ethernet_True_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Serial_Comm_True_Ethernet_False = false;
            if (LanguageText_Data_Static.CurrentLanguage_Static == "EN")
            {
                RS232_Settings_Button.Text = LanguageText_Data_Static.Button_EN[9];
                //RS232_Settings_Button.BackColor = Color.DarkGreen;
            }
            else
            {
                RS232_Settings_Button.Text = LanguageText_Data_Static.Button_FR[9];
                //RS232_Settings_Button.BackColor = Color.DarkGreen;
            }
        }
        //=======================================__IP__=======================================
        //=======================================__IP__=======================================
        //=======================================__IP__=======================================
        
        private void Disconnect_button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Disconnected");
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
        }
        public void IpConnection(String PortsIP, string AddressIP)
        {
        }


        private void Info_LRC_Button_Click(object sender, EventArgs e)
        {

        }

        private void Val_Button_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Light_Plus_button_Click(object sender, EventArgs e)
        {

        }

        private void Light_Moins_button_Click(object sender, EventArgs e)
        {

        }

        private void Import_to_XML_Button_Click(object sender, EventArgs e)
        {

             try
            {


                Serial_Input_TextBox.Clear();
                Serial_Input_TextBox.Text += "Clear TextBox : OK" + "\r\n";
                StreamReader reader = new StreamReader("Historique.xml");
                Command_History_Class command_History = (Command_History_Class)new XmlSerializer(typeof(Command_History_Class)).Deserialize(reader);
                reader.Close();



                Serial_Input_TextBox.Text += "Import        : OK" + "\r\n";
                
                for (int i = 0; i <= (command_History.Command_History_List.Count - 1); i++)
                {
                    //MessageBox.Show(i.ToString());
                    Serial_Input_TextBox.Text +=  command_History.Command_History_List[i].Message_Send_String + "\r\n";
                }


            } catch
            {
                Serial_Input_TextBox.Text += "Error with Import XML!" + "\r\n";
            }

        }

        private void Text_Effet_Sortie_ComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

