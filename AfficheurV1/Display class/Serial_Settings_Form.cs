using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;

namespace AfficheurV1
{
    public partial class Serial_Settings_Form : Form
    {


        public static bool X_Init { set; get; }

        public Serial_Settings_Form()
        {
            InitializeComponent();

            //this.Avalable_COM_Port_MainForm = SerialPort.GetPortNames();


            for (int i = 0; i <= MainForm.Avalable_COM_Port.Count() - 1; i++)
            {
                COM_Port_ComboBox.Items.Add(MainForm.Avalable_COM_Port[i]);

            }



            if (MainForm.Avalable_COM_Port.Count() > 0)
            {
                    COM_Port_ComboBox.SelectedIndex = COM_Port_ComboBox.FindStringExact(MainForm.COM_Port);
            }
            else
            {
                COM_Port_ComboBox.Enabled = false;
            }




            //Serial_Settings.COM_Port = "COM1";
            if (X_Init == false)
            {



                X_Init = true;
            }
            else
            {
                //Baud_Rate_Settings_ComboBox.Items.Equals("");

                Baud_Rate_Settings_ComboBox.SelectedIndex = Baud_Rate_Settings_ComboBox.FindStringExact(MainForm.Baud_Rate.ToString());
                switch (MainForm.Parity)
                {
                    case "None":
                        Parity_None_RadioButton.Checked = true;
                        Parity_Mark_RadioButton.Checked = false;
                        Parity_Odd_RadioButton.Checked = false;
                        Parity_Even_RadioButton.Checked = false;
                        Parity_Space_RadioButton.Checked = false;

                        break;
                    case "Mark":
                        Parity_None_RadioButton.Checked = false;
                        Parity_Mark_RadioButton.Checked = true;
                        Parity_Odd_RadioButton.Checked = false;
                        Parity_Even_RadioButton.Checked = false;
                        Parity_Space_RadioButton.Checked = false;
                        break;
                    case "Odd":
                        Parity_None_RadioButton.Checked = false;
                        Parity_Mark_RadioButton.Checked = false;
                        Parity_Odd_RadioButton.Checked = true;
                        Parity_Even_RadioButton.Checked = false;
                        Parity_Space_RadioButton.Checked = false;
                        break;
                    case "Space":
                        Parity_None_RadioButton.Checked = false;
                        Parity_Mark_RadioButton.Checked = false;
                        Parity_Odd_RadioButton.Checked = false;
                        Parity_Even_RadioButton.Checked = false;
                        Parity_Space_RadioButton.Checked = true;
                        break;
                    case "Even":
                        Parity_None_RadioButton.Checked = false;
                        Parity_Mark_RadioButton.Checked = false;
                        Parity_Odd_RadioButton.Checked = false;
                        Parity_Even_RadioButton.Checked = true;
                        Parity_Space_RadioButton.Checked = false;
                        break;
                    default:
                        MessageBox.Show("Error Flow");

                        break;
                }
                switch (MainForm.Stop_Bit/*Convert.ToDouble(Serial_Settings.Stop_Bit)*/)
                {
                    case "1":
                        Stop_Bit_None_RadioButton.Checked = false;
                        Stop_Bit_15_RadioButton.Checked = false;
                        Stop_Bit_2_RadioButton.Checked = false;
                        Stop_Bit_1_RadioButton.Checked = true;
                        break;
                    case "1,5":
                        Stop_Bit_None_RadioButton.Checked = false;
                        Stop_Bit_15_RadioButton.Checked = true;
                        Stop_Bit_2_RadioButton.Checked = false;
                        Stop_Bit_1_RadioButton.Checked = false;
                        break;
                    case "0":
                        Stop_Bit_None_RadioButton.Checked = true;
                        Stop_Bit_15_RadioButton.Checked = false;
                        Stop_Bit_2_RadioButton.Checked = false;
                        Stop_Bit_1_RadioButton.Checked = false;
                        break;
                    case "2":
                        Stop_Bit_None_RadioButton.Checked = false;
                        Stop_Bit_15_RadioButton.Checked = false;
                        Stop_Bit_2_RadioButton.Checked = true;
                        Stop_Bit_1_RadioButton.Checked = false;
                        break;
                    default:
                        MessageBox.Show("Error Stop Bit");

                        break;
                }
                switch (MainForm.Data_Bits/*Convert.ToDouble(Serial_Settings.Stop_Bit)*/)
                {
                    case 4:
                        Data_Bit_4_RadioButton.Checked = true;
                        Data_Bit_5_RadioButton.Checked = false;
                        Data_Bit_6_RadioButton.Checked = false;
                        Data_Bit_7_RadioButton.Checked = false;
                        Data_Bit_8_RadioButton.Checked = false;
                        break;
                    case 5:
                        Data_Bit_4_RadioButton.Checked = false;
                        Data_Bit_5_RadioButton.Checked = true;
                        Data_Bit_6_RadioButton.Checked = false;
                        Data_Bit_7_RadioButton.Checked = false;
                        Data_Bit_8_RadioButton.Checked = false;
                        break;
                    case 6:
                        Data_Bit_4_RadioButton.Checked = false;
                        Data_Bit_5_RadioButton.Checked = false;
                        Data_Bit_6_RadioButton.Checked = true;
                        Data_Bit_7_RadioButton.Checked = false;
                        Data_Bit_8_RadioButton.Checked = false;
                        break;
                    case 7:
                        Data_Bit_4_RadioButton.Checked = false;
                        Data_Bit_5_RadioButton.Checked = false;
                        Data_Bit_6_RadioButton.Checked = false;
                        Data_Bit_7_RadioButton.Checked = true;
                        Data_Bit_8_RadioButton.Checked = false;
                        break;
                    case 8:
                        Data_Bit_4_RadioButton.Checked = false;
                        Data_Bit_5_RadioButton.Checked = false;
                        Data_Bit_6_RadioButton.Checked = false;
                        Data_Bit_7_RadioButton.Checked = false;
                        Data_Bit_8_RadioButton.Checked = true;
                        break;
                    default:
                        MessageBox.Show("Error Stop Bit");

                        break;
                }
                switch (MainForm.Flow_Control)
                {
                    case "None":
                        Flow_Control_DTR_RTS_RadioButton.Checked = false;
                        Flow_Control_None_RadioButton.Checked = true;
                        Flow_Control_Xon_Xoff_RadioButton.Checked = false;
                        break;
                    case "DTR":
                        Flow_Control_DTR_RTS_RadioButton.Checked = true;
                        Flow_Control_None_RadioButton.Checked = false;
                        Flow_Control_Xon_Xoff_RadioButton.Checked = false;
                        break;
                    case "XOnXOff":
                        Flow_Control_DTR_RTS_RadioButton.Checked = false;
                        Flow_Control_None_RadioButton.Checked = false;
                        Flow_Control_Xon_Xoff_RadioButton.Checked = true;
                        break;
                    default:
                        MessageBox.Show("Error");

                        break;
                }


            }



            /*
            foreach (string port in ports)
            {
                // MessageBox.Show(port);
            }

            */
        }



        private void Serial_Settings_Load(object sender, EventArgs e)
        {

        }

        private void Baud_Rate_Settings_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Baud_Rate_Settings_ComboBox.Text
            if (Baud_Rate_Settings_ComboBox.Text == "User")
            {
                User_Baud_Rate_Settings_TextBox.Enabled = true;
            }
            else
            {
                User_Baud_Rate_Settings_TextBox.Enabled = false;
                //Baud_Rate_No_Static = Convert.ToInt32(Baud_Rate_Settings_ComboBox.Text);
                MainForm.Baud_Rate = Baud_Rate_Settings_ComboBox.Text;
            }

            /*
            switch (Baud_Rate_Settings_ComboBox.Text)
            {
                case "User":
                    User_Baud_Rate_Settings_TextBox.Enabled = true;
                    break;
                case "110":
                    User_Baud_Rate_Settings_TextBox.Enabled = false;
                    Serial_Settings.Baud_Rate = 110;
                    break;
                case "SP":
                    
                    break;
                default:

                    break;
            }
            */
        }

        private void User_Baud_Rate_Settings_TextBox_MouseHover(object sender, EventArgs e)
        {

        }


        private void User_Baud_Rate_Settings_TextBox_TextChanged(object sender, EventArgs e)
        {

        }





        private void COM_Port_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Baud_Rate_Settings_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Stop_Bit_1_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Stop_Bit = "1";
            //Stop_Bit_No_Static = "1";

        }

        private void Stop_Bit_15_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Stop_Bit_No_Static = "1,5";
            MainForm.Stop_Bit = "1,5";
        }

        private void Stop_Bit_2_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Stop_Bit = "2";
        }

        private void Data_Bit_4_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Data_Bits = 4;
        }

        private void Data_Bit_5_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Data_Bits = 5;
        }

        private void Data_Bit_6_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Data_Bits = 6;
        }

        private void Data_Bit_7_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Data_Bits = 7;
        }

        private void Data_Bit_8_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Data_Bits = 8;
        }

        private void Parity_None_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Parity = "None";
        }

        private void Parity_Mark_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Parity = "Mark";

        }

        private void Parity_Odd_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Parity = "Odd";
        }

        private void Parity_Space_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Parity = "Space";
        }

        private void Parity_Even_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Parity = "Even";
        }

        private void Flow_Control_None_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Flow_Control = "None";
        }

        private void Flow_Control_DTR_RTS_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Flow_Control = "DTR";
        }

        private void Flow_Control_Xon_Xoff_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Flow_Control = "XOnXOff";
        }

        private void COM_Port_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            //this.COM_Port_No_Static = COM_Port_ComboBox.Text;
            MainForm.COM_Port = COM_Port_ComboBox.Text;
        }

        private void Update_Port_Button_Click(object sender, EventArgs e)
        {
            COM_Port_ComboBox.Items.Clear();
            if(MainForm.Avalable_COM_Port.Count() <= 0)
            {
                Info_toolTip.Show(LanguageText_Data_Static.Messages_ToolTip_FR[0], Update_Port_Button, 20000);
            } else
            {
                for (int i = 0; i <= MainForm.Avalable_COM_Port.Count() - 1; i++)
                {
                    COM_Port_ComboBox.Items.Add(MainForm.Avalable_COM_Port[i]);
                }
            }

            //Serial_Settings.Avalable_COM_Port.Count;
        }

        private void Stop_Bit_None_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.Stop_Bit = "0";
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {

        }

        private void User_Baud_Rate_Settings_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\b'/* pour supprimer un caractère*/ || Char.IsNumber(e.KeyChar))
            {

                MainForm.Baud_Rate = User_Baud_Rate_Settings_TextBox.Text;
                //MessageBox.Show("OK");
            }
            else
            {
                Info_toolTip_2.Show(LanguageText_Data_Static.Messages_ToolTip_FR[1], User_Baud_Rate_Settings_TextBox, 20000);
                e.Handled = true;
            }

        }

        private void User_Baud_Rate_Settings_TextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
