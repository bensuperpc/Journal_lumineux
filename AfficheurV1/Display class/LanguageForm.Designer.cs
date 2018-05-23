namespace AfficheurV1
{
    partial class LanguageForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Spansih_RadioButton = new System.Windows.Forms.RadioButton();
            this.English_RadioButton = new System.Windows.Forms.RadioButton();
            this.French_RadioButton = new System.Windows.Forms.RadioButton();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Spansih_RadioButton);
            this.groupBox1.Controls.Add(this.English_RadioButton);
            this.groupBox1.Controls.Add(this.French_RadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chose you language";
            // 
            // Spansih_RadioButton
            // 
            this.Spansih_RadioButton.AutoSize = true;
            this.Spansih_RadioButton.Location = new System.Drawing.Point(6, 66);
            this.Spansih_RadioButton.Name = "Spansih_RadioButton";
            this.Spansih_RadioButton.Size = new System.Drawing.Size(63, 17);
            this.Spansih_RadioButton.TabIndex = 5;
            this.Spansih_RadioButton.TabStop = true;
            this.Spansih_RadioButton.Text = "Español";
            this.Spansih_RadioButton.UseVisualStyleBackColor = true;
            this.Spansih_RadioButton.CheckedChanged += new System.EventHandler(this.Spansih_RadioButton_CheckedChanged);
            // 
            // English_RadioButton
            // 
            this.English_RadioButton.AutoSize = true;
            this.English_RadioButton.Location = new System.Drawing.Point(6, 42);
            this.English_RadioButton.Name = "English_RadioButton";
            this.English_RadioButton.Size = new System.Drawing.Size(59, 17);
            this.English_RadioButton.TabIndex = 4;
            this.English_RadioButton.TabStop = true;
            this.English_RadioButton.Text = "English";
            this.English_RadioButton.UseVisualStyleBackColor = true;
            this.English_RadioButton.CheckedChanged += new System.EventHandler(this.English_RadioButton_CheckedChanged);
            // 
            // French_RadioButton
            // 
            this.French_RadioButton.AutoSize = true;
            this.French_RadioButton.Location = new System.Drawing.Point(6, 19);
            this.French_RadioButton.Name = "French_RadioButton";
            this.French_RadioButton.Size = new System.Drawing.Size(65, 17);
            this.French_RadioButton.TabIndex = 3;
            this.French_RadioButton.TabStop = true;
            this.French_RadioButton.Text = "Francais";
            this.French_RadioButton.UseVisualStyleBackColor = true;
            this.French_RadioButton.CheckedChanged += new System.EventHandler(this.French_RadioButton_CheckedChanged);
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Location = new System.Drawing.Point(18, 101);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 4;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            // 
            // Exit_Button
            // 
            this.Exit_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit_Button.Location = new System.Drawing.Point(100, 101);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 5;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            // 
            // LanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 136);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.groupBox1);
            this.Name = "LanguageForm";
            this.Text = "FirstForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Spansih_RadioButton;
        private System.Windows.Forms.RadioButton English_RadioButton;
        private System.Windows.Forms.RadioButton French_RadioButton;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Exit_Button;
    }
}