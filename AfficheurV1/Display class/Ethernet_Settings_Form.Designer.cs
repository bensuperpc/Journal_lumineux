namespace AfficheurV1
{
    partial class Ethernet_Settings_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.IP_TextBox = new System.Windows.Forms.TextBox();
            this.Port_TextBox = new System.Windows.Forms.TextBox();
            this.Ip_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IP_TextBox
            // 
            this.IP_TextBox.Location = new System.Drawing.Point(47, 9);
            this.IP_TextBox.MaxLength = 15;
            this.IP_TextBox.Name = "IP_TextBox";
            this.IP_TextBox.Size = new System.Drawing.Size(100, 20);
            this.IP_TextBox.TabIndex = 4;
            this.IP_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ip_KeyPress);
            // 
            // Port_TextBox
            // 
            this.Port_TextBox.Location = new System.Drawing.Point(47, 35);
            this.Port_TextBox.MaxLength = 5;
            this.Port_TextBox.Name = "Port_TextBox";
            this.Port_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Port_TextBox.TabIndex = 5;
            this.Port_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Port_Text_KeyPress);
            // 
            // Ip_Label
            // 
            this.Ip_Label.AutoSize = true;
            this.Ip_Label.Location = new System.Drawing.Point(9, 9);
            this.Ip_Label.Name = "Ip_Label";
            this.Ip_Label.Size = new System.Drawing.Size(23, 13);
            this.Ip_Label.TabIndex = 6;
            this.Ip_Label.Text = "IP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port :";
            // 
            // Ethernet_Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 139);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ip_Label);
            this.Controls.Add(this.Port_TextBox);
            this.Controls.Add(this.IP_TextBox);
            this.Controls.Add(this.button1);
            this.Name = "Ethernet_Settings_Form";
            this.Text = "Ethernet_Settings_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IP_TextBox;
        private System.Windows.Forms.TextBox Port_TextBox;
        private System.Windows.Forms.Label Ip_Label;
        private System.Windows.Forms.Label label2;
    }
}