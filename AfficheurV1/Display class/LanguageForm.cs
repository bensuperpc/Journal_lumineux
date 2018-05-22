using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfficheurV1
{
    public partial class LanguageForm : Form
    {
        //private static string Language;
        

        public LanguageForm(string message)
        {
            InitializeComponent();
            this.Text = message;
            //MessageBox.Show(LanguageText_Data.CurrentLanguage_Static);

            switch (LanguageText_Data_Static.CurrentLanguage_Static)
            {
                case "FR":
                    French_RadioButton.Checked = true;
                    break;
                case "EN":
                    English_RadioButton.Checked = true;
                    break;
                case "SP":
                    Spansih_RadioButton.Checked = true;
                    break;
                default:
                    MessageBox.Show("Value is Missing or wrong value, turn to default Language 'FR'");
                    LanguageText_Data_Static.CurrentLanguage_Static = "FR";
                    this.Close();
                    break;
            }
        }
        /*
        private void English_button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.GetType().Name + this.Name);
            //Loading_MainForm("EN");
        }
        */

        public string Loading_MainForm_Language
        {
            get { return LanguageText_Data_Static.CurrentLanguage_Static; }
        }

        private void French_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Language = "FR";
            LanguageText_Data_Static.CurrentLanguage_Static = "FR";
        }

        private void English_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Language = "EN";
            LanguageText_Data_Static.CurrentLanguage_Static = "EN";
        }

        private void Spansih_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Language = "SP";
            LanguageText_Data_Static.CurrentLanguage_Static = "SP";
        }
    }
}
