namespace AfficheurV1
{
    partial class Serial_Settings_Form
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
            this.components = new System.ComponentModel.Container();
            this.OK_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Stop_Bit_None_RadioButton = new System.Windows.Forms.RadioButton();
            this.Stop_Bit_2_RadioButton = new System.Windows.Forms.RadioButton();
            this.Stop_Bit_15_RadioButton = new System.Windows.Forms.RadioButton();
            this.Stop_Bit_1_RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Flow_Control_Xon_Xoff_RadioButton = new System.Windows.Forms.RadioButton();
            this.Flow_Control_DTR_RTS_RadioButton = new System.Windows.Forms.RadioButton();
            this.Flow_Control_None_RadioButton = new System.Windows.Forms.RadioButton();
            this.COM_Port_ComboBox = new System.Windows.Forms.ComboBox();
            this.Baud_Rate_Settings_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.User_Baud_Rate_Settings_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Data_Bit_8_RadioButton = new System.Windows.Forms.RadioButton();
            this.Data_Bit_7_RadioButton = new System.Windows.Forms.RadioButton();
            this.Data_Bit_6_RadioButton = new System.Windows.Forms.RadioButton();
            this.Data_Bit_5_RadioButton = new System.Windows.Forms.RadioButton();
            this.Data_Bit_4_RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Parity_Space_RadioButton = new System.Windows.Forms.RadioButton();
            this.Parity_Mark_RadioButton = new System.Windows.Forms.RadioButton();
            this.Parity_Even_RadioButton = new System.Windows.Forms.RadioButton();
            this.Parity_Odd_RadioButton = new System.Windows.Forms.RadioButton();
            this.Parity_None_RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Update_Port_Button = new System.Windows.Forms.Button();
            this.Info_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Info_toolTip_2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Location = new System.Drawing.Point(214, 277);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(100, 50);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Stop_Bit_None_RadioButton);
            this.groupBox1.Controls.Add(this.Stop_Bit_2_RadioButton);
            this.groupBox1.Controls.Add(this.Stop_Bit_15_RadioButton);
            this.groupBox1.Controls.Add(this.Stop_Bit_1_RadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bits de stop";
            // 
            // Stop_Bit_None_RadioButton
            // 
            this.Stop_Bit_None_RadioButton.AutoSize = true;
            this.Stop_Bit_None_RadioButton.Location = new System.Drawing.Point(7, 20);
            this.Stop_Bit_None_RadioButton.Name = "Stop_Bit_None_RadioButton";
            this.Stop_Bit_None_RadioButton.Size = new System.Drawing.Size(51, 17);
            this.Stop_Bit_None_RadioButton.TabIndex = 3;
            this.Stop_Bit_None_RadioButton.TabStop = true;
            this.Stop_Bit_None_RadioButton.Text = "None";
            this.Stop_Bit_None_RadioButton.UseVisualStyleBackColor = true;
            this.Stop_Bit_None_RadioButton.CheckedChanged += new System.EventHandler(this.Stop_Bit_None_RadioButton_CheckedChanged);
            // 
            // Stop_Bit_2_RadioButton
            // 
            this.Stop_Bit_2_RadioButton.AutoSize = true;
            this.Stop_Bit_2_RadioButton.Location = new System.Drawing.Point(155, 20);
            this.Stop_Bit_2_RadioButton.Name = "Stop_Bit_2_RadioButton";
            this.Stop_Bit_2_RadioButton.Size = new System.Drawing.Size(31, 17);
            this.Stop_Bit_2_RadioButton.TabIndex = 2;
            this.Stop_Bit_2_RadioButton.TabStop = true;
            this.Stop_Bit_2_RadioButton.Text = "2";
            this.Stop_Bit_2_RadioButton.UseVisualStyleBackColor = true;
            this.Stop_Bit_2_RadioButton.CheckedChanged += new System.EventHandler(this.Stop_Bit_2_RadioButton_CheckedChanged);
            // 
            // Stop_Bit_15_RadioButton
            // 
            this.Stop_Bit_15_RadioButton.AutoSize = true;
            this.Stop_Bit_15_RadioButton.Location = new System.Drawing.Point(98, 20);
            this.Stop_Bit_15_RadioButton.Name = "Stop_Bit_15_RadioButton";
            this.Stop_Bit_15_RadioButton.Size = new System.Drawing.Size(40, 17);
            this.Stop_Bit_15_RadioButton.TabIndex = 1;
            this.Stop_Bit_15_RadioButton.TabStop = true;
            this.Stop_Bit_15_RadioButton.Text = "1,5";
            this.Stop_Bit_15_RadioButton.UseVisualStyleBackColor = true;
            this.Stop_Bit_15_RadioButton.CheckedChanged += new System.EventHandler(this.Stop_Bit_15_RadioButton_CheckedChanged);
            // 
            // Stop_Bit_1_RadioButton
            // 
            this.Stop_Bit_1_RadioButton.AutoSize = true;
            this.Stop_Bit_1_RadioButton.Checked = true;
            this.Stop_Bit_1_RadioButton.Location = new System.Drawing.Point(61, 19);
            this.Stop_Bit_1_RadioButton.Name = "Stop_Bit_1_RadioButton";
            this.Stop_Bit_1_RadioButton.Size = new System.Drawing.Size(31, 17);
            this.Stop_Bit_1_RadioButton.TabIndex = 0;
            this.Stop_Bit_1_RadioButton.TabStop = true;
            this.Stop_Bit_1_RadioButton.Text = "1";
            this.Stop_Bit_1_RadioButton.UseVisualStyleBackColor = true;
            this.Stop_Bit_1_RadioButton.CheckedChanged += new System.EventHandler(this.Stop_Bit_1_RadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Flow_Control_Xon_Xoff_RadioButton);
            this.groupBox2.Controls.Add(this.Flow_Control_DTR_RTS_RadioButton);
            this.groupBox2.Controls.Add(this.Flow_Control_None_RadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 47);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flow control";
            // 
            // Flow_Control_Xon_Xoff_RadioButton
            // 
            this.Flow_Control_Xon_Xoff_RadioButton.AutoSize = true;
            this.Flow_Control_Xon_Xoff_RadioButton.Location = new System.Drawing.Point(234, 19);
            this.Flow_Control_Xon_Xoff_RadioButton.Name = "Flow_Control_Xon_Xoff_RadioButton";
            this.Flow_Control_Xon_Xoff_RadioButton.Size = new System.Drawing.Size(67, 17);
            this.Flow_Control_Xon_Xoff_RadioButton.TabIndex = 2;
            this.Flow_Control_Xon_Xoff_RadioButton.TabStop = true;
            this.Flow_Control_Xon_Xoff_RadioButton.Text = "XOnXOff";
            this.Flow_Control_Xon_Xoff_RadioButton.UseVisualStyleBackColor = true;
            this.Flow_Control_Xon_Xoff_RadioButton.CheckedChanged += new System.EventHandler(this.Flow_Control_Xon_Xoff_RadioButton_CheckedChanged);
            // 
            // Flow_Control_DTR_RTS_RadioButton
            // 
            this.Flow_Control_DTR_RTS_RadioButton.AutoSize = true;
            this.Flow_Control_DTR_RTS_RadioButton.Location = new System.Drawing.Point(98, 19);
            this.Flow_Control_DTR_RTS_RadioButton.Name = "Flow_Control_DTR_RTS_RadioButton";
            this.Flow_Control_DTR_RTS_RadioButton.Size = new System.Drawing.Size(75, 17);
            this.Flow_Control_DTR_RTS_RadioButton.TabIndex = 1;
            this.Flow_Control_DTR_RTS_RadioButton.TabStop = true;
            this.Flow_Control_DTR_RTS_RadioButton.Text = "DTR/RTS";
            this.Flow_Control_DTR_RTS_RadioButton.UseVisualStyleBackColor = true;
            this.Flow_Control_DTR_RTS_RadioButton.CheckedChanged += new System.EventHandler(this.Flow_Control_DTR_RTS_RadioButton_CheckedChanged);
            // 
            // Flow_Control_None_RadioButton
            // 
            this.Flow_Control_None_RadioButton.AutoSize = true;
            this.Flow_Control_None_RadioButton.Checked = true;
            this.Flow_Control_None_RadioButton.Location = new System.Drawing.Point(7, 19);
            this.Flow_Control_None_RadioButton.Name = "Flow_Control_None_RadioButton";
            this.Flow_Control_None_RadioButton.Size = new System.Drawing.Size(51, 17);
            this.Flow_Control_None_RadioButton.TabIndex = 0;
            this.Flow_Control_None_RadioButton.TabStop = true;
            this.Flow_Control_None_RadioButton.Text = "None";
            this.Flow_Control_None_RadioButton.UseVisualStyleBackColor = true;
            this.Flow_Control_None_RadioButton.CheckedChanged += new System.EventHandler(this.Flow_Control_None_RadioButton_CheckedChanged);
            // 
            // COM_Port_ComboBox
            // 
            this.COM_Port_ComboBox.FormattingEnabled = true;
            this.COM_Port_ComboBox.Location = new System.Drawing.Point(65, 19);
            this.COM_Port_ComboBox.Name = "COM_Port_ComboBox";
            this.COM_Port_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.COM_Port_ComboBox.TabIndex = 3;
            this.COM_Port_ComboBox.SelectedIndexChanged += new System.EventHandler(this.COM_Port_ComboBox_SelectedIndexChanged);
            this.COM_Port_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.COM_Port_ComboBox_KeyPress);
            // 
            // Baud_Rate_Settings_ComboBox
            // 
            this.Baud_Rate_Settings_ComboBox.FormattingEnabled = true;
            this.Baud_Rate_Settings_ComboBox.Items.AddRange(new object[] {
            "User",
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.Baud_Rate_Settings_ComboBox.Location = new System.Drawing.Point(65, 46);
            this.Baud_Rate_Settings_ComboBox.Name = "Baud_Rate_Settings_ComboBox";
            this.Baud_Rate_Settings_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Baud_Rate_Settings_ComboBox.TabIndex = 4;
            this.Baud_Rate_Settings_ComboBox.Text = "9600";
            this.Baud_Rate_Settings_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Baud_Rate_Settings_ComboBox_SelectedIndexChanged);
            this.Baud_Rate_Settings_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Baud_Rate_Settings_ComboBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud rate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.User_Baud_Rate_Settings_TextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Baud_Rate_Settings_ComboBox);
            this.groupBox3.Controls.Add(this.COM_Port_ComboBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General settings";
            // 
            // User_Baud_Rate_Settings_TextBox
            // 
            this.User_Baud_Rate_Settings_TextBox.Enabled = false;
            this.User_Baud_Rate_Settings_TextBox.Location = new System.Drawing.Point(65, 72);
            this.User_Baud_Rate_Settings_TextBox.Name = "User_Baud_Rate_Settings_TextBox";
            this.User_Baud_Rate_Settings_TextBox.Size = new System.Drawing.Size(121, 20);
            this.User_Baud_Rate_Settings_TextBox.TabIndex = 8;
            this.User_Baud_Rate_Settings_TextBox.TextChanged += new System.EventHandler(this.User_Baud_Rate_Settings_TextBox_TextChanged_1);
            this.User_Baud_Rate_Settings_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.User_Baud_Rate_Settings_TextBox_KeyPress);
            this.User_Baud_Rate_Settings_TextBox.MouseHover += new System.EventHandler(this.User_Baud_Rate_Settings_TextBox_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "User Bps";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(320, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Data_Bit_8_RadioButton);
            this.groupBox4.Controls.Add(this.Data_Bit_7_RadioButton);
            this.groupBox4.Controls.Add(this.Data_Bit_6_RadioButton);
            this.groupBox4.Controls.Add(this.Data_Bit_5_RadioButton);
            this.groupBox4.Controls.Add(this.Data_Bit_4_RadioButton);
            this.groupBox4.Location = new System.Drawing.Point(12, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 47);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Bits";
            // 
            // Data_Bit_8_RadioButton
            // 
            this.Data_Bit_8_RadioButton.AutoSize = true;
            this.Data_Bit_8_RadioButton.Checked = true;
            this.Data_Bit_8_RadioButton.Location = new System.Drawing.Point(155, 20);
            this.Data_Bit_8_RadioButton.Name = "Data_Bit_8_RadioButton";
            this.Data_Bit_8_RadioButton.Size = new System.Drawing.Size(31, 17);
            this.Data_Bit_8_RadioButton.TabIndex = 4;
            this.Data_Bit_8_RadioButton.TabStop = true;
            this.Data_Bit_8_RadioButton.Text = "8";
            this.Data_Bit_8_RadioButton.UseVisualStyleBackColor = true;
            this.Data_Bit_8_RadioButton.CheckedChanged += new System.EventHandler(this.Data_Bit_8_RadioButton_CheckedChanged);
            // 
            // Data_Bit_7_RadioButton
            // 
            this.Data_Bit_7_RadioButton.AutoSize = true;
            this.Data_Bit_7_RadioButton.Location = new System.Drawing.Point(118, 20);
            this.Data_Bit_7_RadioButton.Name = "Data_Bit_7_RadioButton";
            this.Data_Bit_7_RadioButton.Size = new System.Drawing.Size(31, 17);
            this.Data_Bit_7_RadioButton.TabIndex = 3;
            this.Data_Bit_7_RadioButton.TabStop = true;
            this.Data_Bit_7_RadioButton.Text = "7";
            this.Data_Bit_7_RadioButton.UseVisualStyleBackColor = true;
            this.Data_Bit_7_RadioButton.CheckedChanged += new System.EventHandler(this.Data_Bit_7_RadioButton_CheckedChanged);
            // 
            // Data_Bit_6_RadioButton
            // 
            this.Data_Bit_6_RadioButton.AutoSize = true;
            this.Data_Bit_6_RadioButton.Location = new System.Drawing.Point(81, 20);
            this.Data_Bit_6_RadioButton.Name = "Data_Bit_6_RadioButton";
            this.Data_Bit_6_RadioButton.Size = new System.Drawing.Size(31, 17);
            this.Data_Bit_6_RadioButton.TabIndex = 2;
            this.Data_Bit_6_RadioButton.TabStop = true;
            this.Data_Bit_6_RadioButton.Text = "6";
            this.Data_Bit_6_RadioButton.UseVisualStyleBackColor = true;
            this.Data_Bit_6_RadioButton.CheckedChanged += new System.EventHandler(this.Data_Bit_6_RadioButton_CheckedChanged);
            // 
            // Data_Bit_5_RadioButton
            // 
            this.Data_Bit_5_RadioButton.AutoSize = true;
            this.Data_Bit_5_RadioButton.Location = new System.Drawing.Point(44, 19);
            this.Data_Bit_5_RadioButton.Name = "Data_Bit_5_RadioButton";
            this.Data_Bit_5_RadioButton.Size = new System.Drawing.Size(31, 17);
            this.Data_Bit_5_RadioButton.TabIndex = 1;
            this.Data_Bit_5_RadioButton.TabStop = true;
            this.Data_Bit_5_RadioButton.Text = "5";
            this.Data_Bit_5_RadioButton.UseVisualStyleBackColor = true;
            this.Data_Bit_5_RadioButton.CheckedChanged += new System.EventHandler(this.Data_Bit_5_RadioButton_CheckedChanged);
            // 
            // Data_Bit_4_RadioButton
            // 
            this.Data_Bit_4_RadioButton.AutoSize = true;
            this.Data_Bit_4_RadioButton.Location = new System.Drawing.Point(7, 20);
            this.Data_Bit_4_RadioButton.Name = "Data_Bit_4_RadioButton";
            this.Data_Bit_4_RadioButton.Size = new System.Drawing.Size(31, 17);
            this.Data_Bit_4_RadioButton.TabIndex = 0;
            this.Data_Bit_4_RadioButton.TabStop = true;
            this.Data_Bit_4_RadioButton.Text = "4";
            this.Data_Bit_4_RadioButton.UseVisualStyleBackColor = true;
            this.Data_Bit_4_RadioButton.CheckedChanged += new System.EventHandler(this.Data_Bit_4_RadioButton_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Parity_Space_RadioButton);
            this.groupBox5.Controls.Add(this.Parity_Mark_RadioButton);
            this.groupBox5.Controls.Add(this.Parity_Even_RadioButton);
            this.groupBox5.Controls.Add(this.Parity_Odd_RadioButton);
            this.groupBox5.Controls.Add(this.Parity_None_RadioButton);
            this.groupBox5.Location = new System.Drawing.Point(218, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parity";
            // 
            // Parity_Space_RadioButton
            // 
            this.Parity_Space_RadioButton.AutoSize = true;
            this.Parity_Space_RadioButton.Location = new System.Drawing.Point(64, 44);
            this.Parity_Space_RadioButton.Name = "Parity_Space_RadioButton";
            this.Parity_Space_RadioButton.Size = new System.Drawing.Size(56, 17);
            this.Parity_Space_RadioButton.TabIndex = 4;
            this.Parity_Space_RadioButton.TabStop = true;
            this.Parity_Space_RadioButton.Text = "Space";
            this.Parity_Space_RadioButton.UseVisualStyleBackColor = true;
            this.Parity_Space_RadioButton.CheckedChanged += new System.EventHandler(this.Parity_Space_RadioButton_CheckedChanged);
            // 
            // Parity_Mark_RadioButton
            // 
            this.Parity_Mark_RadioButton.AutoSize = true;
            this.Parity_Mark_RadioButton.Location = new System.Drawing.Point(64, 21);
            this.Parity_Mark_RadioButton.Name = "Parity_Mark_RadioButton";
            this.Parity_Mark_RadioButton.Size = new System.Drawing.Size(49, 17);
            this.Parity_Mark_RadioButton.TabIndex = 3;
            this.Parity_Mark_RadioButton.TabStop = true;
            this.Parity_Mark_RadioButton.Text = "Mark";
            this.Parity_Mark_RadioButton.UseVisualStyleBackColor = true;
            this.Parity_Mark_RadioButton.CheckedChanged += new System.EventHandler(this.Parity_Mark_RadioButton_CheckedChanged);
            // 
            // Parity_Even_RadioButton
            // 
            this.Parity_Even_RadioButton.AutoSize = true;
            this.Parity_Even_RadioButton.Location = new System.Drawing.Point(6, 68);
            this.Parity_Even_RadioButton.Name = "Parity_Even_RadioButton";
            this.Parity_Even_RadioButton.Size = new System.Drawing.Size(50, 17);
            this.Parity_Even_RadioButton.TabIndex = 2;
            this.Parity_Even_RadioButton.TabStop = true;
            this.Parity_Even_RadioButton.Text = "Even";
            this.Parity_Even_RadioButton.UseVisualStyleBackColor = true;
            this.Parity_Even_RadioButton.CheckedChanged += new System.EventHandler(this.Parity_Even_RadioButton_CheckedChanged);
            // 
            // Parity_Odd_RadioButton
            // 
            this.Parity_Odd_RadioButton.AutoSize = true;
            this.Parity_Odd_RadioButton.Location = new System.Drawing.Point(7, 44);
            this.Parity_Odd_RadioButton.Name = "Parity_Odd_RadioButton";
            this.Parity_Odd_RadioButton.Size = new System.Drawing.Size(45, 17);
            this.Parity_Odd_RadioButton.TabIndex = 1;
            this.Parity_Odd_RadioButton.TabStop = true;
            this.Parity_Odd_RadioButton.Text = "Odd";
            this.Parity_Odd_RadioButton.UseVisualStyleBackColor = true;
            this.Parity_Odd_RadioButton.CheckedChanged += new System.EventHandler(this.Parity_Odd_RadioButton_CheckedChanged);
            // 
            // Parity_None_RadioButton
            // 
            this.Parity_None_RadioButton.AutoSize = true;
            this.Parity_None_RadioButton.Checked = true;
            this.Parity_None_RadioButton.Location = new System.Drawing.Point(6, 20);
            this.Parity_None_RadioButton.Name = "Parity_None_RadioButton";
            this.Parity_None_RadioButton.Size = new System.Drawing.Size(51, 17);
            this.Parity_None_RadioButton.TabIndex = 0;
            this.Parity_None_RadioButton.TabStop = true;
            this.Parity_None_RadioButton.Text = "None";
            this.Parity_None_RadioButton.UseVisualStyleBackColor = true;
            this.Parity_None_RadioButton.CheckedChanged += new System.EventHandler(this.Parity_None_RadioButton_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Update_Port_Button);
            this.groupBox6.Location = new System.Drawing.Point(219, 119);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            // 
            // Update_Port_Button
            // 
            this.Update_Port_Button.Location = new System.Drawing.Point(6, 19);
            this.Update_Port_Button.Name = "Update_Port_Button";
            this.Update_Port_Button.Size = new System.Drawing.Size(75, 23);
            this.Update_Port_Button.TabIndex = 0;
            this.Update_Port_Button.Text = "Update Port";
            this.Update_Port_Button.UseVisualStyleBackColor = true;
            this.Update_Port_Button.Click += new System.EventHandler(this.Update_Port_Button_Click);
            // 
            // Info_toolTip
            // 
            this.Info_toolTip.AutomaticDelay = 200;
            // 
            // Info_toolTip_2
            // 
            this.Info_toolTip_2.AutomaticDelay = 200;
            // 
            // Serial_Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 334);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OK_Button);
            this.Name = "Serial_Settings_Form";
            this.Text = "Serial_Settings";
            this.Load += new System.EventHandler(this.Serial_Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Stop_Bit_2_RadioButton;
        private System.Windows.Forms.RadioButton Stop_Bit_15_RadioButton;
        private System.Windows.Forms.RadioButton Stop_Bit_1_RadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Flow_Control_Xon_Xoff_RadioButton;
        private System.Windows.Forms.RadioButton Flow_Control_DTR_RTS_RadioButton;
        private System.Windows.Forms.RadioButton Flow_Control_None_RadioButton;
        private System.Windows.Forms.ComboBox COM_Port_ComboBox;
        private System.Windows.Forms.ComboBox Baud_Rate_Settings_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Data_Bit_8_RadioButton;
        private System.Windows.Forms.RadioButton Data_Bit_7_RadioButton;
        private System.Windows.Forms.RadioButton Data_Bit_6_RadioButton;
        private System.Windows.Forms.RadioButton Data_Bit_5_RadioButton;
        private System.Windows.Forms.RadioButton Data_Bit_4_RadioButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton Parity_None_RadioButton;
        private System.Windows.Forms.RadioButton Parity_Space_RadioButton;
        private System.Windows.Forms.RadioButton Parity_Mark_RadioButton;
        private System.Windows.Forms.RadioButton Parity_Even_RadioButton;
        private System.Windows.Forms.RadioButton Parity_Odd_RadioButton;
        private System.Windows.Forms.TextBox User_Baud_Rate_Settings_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Update_Port_Button;
        private System.Windows.Forms.RadioButton Stop_Bit_None_RadioButton;
        private System.Windows.Forms.ToolTip Info_toolTip;
        private System.Windows.Forms.ToolTip Info_toolTip_2;
    }
}