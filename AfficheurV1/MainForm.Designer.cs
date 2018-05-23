namespace AfficheurV1
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Text_Effet_Entre_ComboBox = new System.Windows.Forms.ComboBox();
            this.Light_Plus_button = new System.Windows.Forms.Button();
            this.Light_Moins_button = new System.Windows.Forms.Button();
            this.Text_Effet_Sortie_ComboBox = new System.Windows.Forms.ComboBox();
            this.Text_Message_TextBox = new System.Windows.Forms.TextBox();
            this.Numero_de_Page_ComboBox = new System.Windows.Forms.ComboBox();
            this.Numero_Afficheur_ComboBox = new System.Windows.Forms.ComboBox();
            this.Change_Language_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.RS232_Settings_Button = new System.Windows.Forms.Button();
            this.Serial_Input_TextBox = new System.Windows.Forms.TextBox();
            this.Dispay_Number_Label = new System.Windows.Forms.Label();
            this.Page_of_Message_Label = new System.Windows.Forms.Label();
            this.Message_label = new System.Windows.Forms.Label();
            this.Speed_ComboBox = new System.Windows.Forms.ComboBox();
            this.Transition_appearance_message_Label = new System.Windows.Forms.Label();
            this.Transition_Disappearance_message_label = new System.Windows.Forms.Label();
            this.Export_to_XML_Button = new System.Windows.Forms.Button();
            this.Scroll_Speed_Label = new System.Windows.Forms.Label();
            this.Display_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.Text_color_Label = new System.Windows.Forms.Label();
            this.Text_color_ComboBox = new System.Windows.Forms.ComboBox();
            this.General_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.Import_to_XML_Button = new System.Windows.Forms.Button();
            this.Drawing_Button = new System.Windows.Forms.Button();
            this.Page_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.Message_GroupBox = new System.Windows.Forms.GroupBox();
            this.LRC_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Verbose_Serial_GroupBox = new System.Windows.Forms.GroupBox();
            this.Info_LRC_Button = new System.Windows.Forms.Button();
            this.Settings_Display_GroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Val_Button = new System.Windows.Forms.Button();
            this.ThreadOfMessage = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Serial_True_RadioButton = new System.Windows.Forms.RadioButton();
            this.Ethernet_True_RadioButton = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Display_Settings_GroupBox.SuspendLayout();
            this.General_Settings_GroupBox.SuspendLayout();
            this.Page_Settings_GroupBox.SuspendLayout();
            this.Message_GroupBox.SuspendLayout();
            this.Verbose_Serial_GroupBox.SuspendLayout();
            this.Settings_Display_GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_Effet_Entre_ComboBox
            // 
            this.Text_Effet_Entre_ComboBox.FormattingEnabled = true;
            this.Text_Effet_Entre_ComboBox.Items.AddRange(new object[] {
            "Aucune transition",
            "Bas vers le haut",
            "Haut vers le bas",
            "Defilement vers la gauche",
            "Defilement vers la droite",
            "Defilement vers le haut",
            "Defilement vers le bas",
            "Effet neige"});
            this.Text_Effet_Entre_ComboBox.Location = new System.Drawing.Point(11, 32);
            this.Text_Effet_Entre_ComboBox.Name = "Text_Effet_Entre_ComboBox";
            this.Text_Effet_Entre_ComboBox.Size = new System.Drawing.Size(150, 21);
            this.Text_Effet_Entre_ComboBox.TabIndex = 0;
            this.Text_Effet_Entre_ComboBox.Text = "Aucune transition";
            this.Text_Effet_Entre_ComboBox.SelectionChangeCommitted += new System.EventHandler(this.Text_Effet_Entre_ComboBox_SelectedIndexChanged);
            this.Text_Effet_Entre_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Effet_Entre_ComboBox_KeyPress);
            // 
            // Light_Plus_button
            // 
            this.Light_Plus_button.Location = new System.Drawing.Point(20, 41);
            this.Light_Plus_button.Name = "Light_Plus_button";
            this.Light_Plus_button.Size = new System.Drawing.Size(75, 23);
            this.Light_Plus_button.TabIndex = 1;
            this.Light_Plus_button.Text = "Luminosité +";
            this.Light_Plus_button.UseVisualStyleBackColor = true;
            this.Light_Plus_button.Click += new System.EventHandler(this.Light_Plus_button_Click);
            // 
            // Light_Moins_button
            // 
            this.Light_Moins_button.Location = new System.Drawing.Point(101, 41);
            this.Light_Moins_button.Name = "Light_Moins_button";
            this.Light_Moins_button.Size = new System.Drawing.Size(75, 23);
            this.Light_Moins_button.TabIndex = 2;
            this.Light_Moins_button.Text = "Luminosité +";
            this.Light_Moins_button.UseVisualStyleBackColor = true;
            this.Light_Moins_button.Click += new System.EventHandler(this.Light_Moins_button_Click);
            // 
            // Text_Effet_Sortie_ComboBox
            // 
            this.Text_Effet_Sortie_ComboBox.FormattingEnabled = true;
            this.Text_Effet_Sortie_ComboBox.Items.AddRange(new object[] {
            "Aucune transition",
            "Bas vers le haut",
            "Haut vers le bas",
            "Defilement vers la gauche",
            "Defilement vers la droite",
            "Defilement vers le haut",
            "Defilement vers le bas",
            "Effet neige"});
            this.Text_Effet_Sortie_ComboBox.Location = new System.Drawing.Point(167, 32);
            this.Text_Effet_Sortie_ComboBox.Name = "Text_Effet_Sortie_ComboBox";
            this.Text_Effet_Sortie_ComboBox.Size = new System.Drawing.Size(150, 21);
            this.Text_Effet_Sortie_ComboBox.TabIndex = 3;
            this.Text_Effet_Sortie_ComboBox.Text = "Aucune transition";
            this.Text_Effet_Sortie_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Text_Effet_Sortie_ComboBox_SelectedIndexChanged_1);
            this.Text_Effet_Sortie_ComboBox.SelectionChangeCommitted += new System.EventHandler(this.Text_Effet_Sortie_ComboBox_SelectedIndexChanged);
            this.Text_Effet_Sortie_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Effet_Sortie_ComboBox_KeyPress);
            // 
            // Text_Message_TextBox
            // 
            this.Text_Message_TextBox.Location = new System.Drawing.Point(11, 42);
            this.Text_Message_TextBox.Name = "Text_Message_TextBox";
            this.Text_Message_TextBox.Size = new System.Drawing.Size(207, 20);
            this.Text_Message_TextBox.TabIndex = 4;
            this.Text_Message_TextBox.TextChanged += new System.EventHandler(this.Text_Text_Message_TextBox);
            // 
            // Numero_de_Page_ComboBox
            // 
            this.Numero_de_Page_ComboBox.FormattingEnabled = true;
            this.Numero_de_Page_ComboBox.Items.AddRange(new object[] {
            "Page 1",
            "Page 2",
            "Page 3",
            "Page 4",
            "Page 5"});
            this.Numero_de_Page_ComboBox.Location = new System.Drawing.Point(108, 47);
            this.Numero_de_Page_ComboBox.Name = "Numero_de_Page_ComboBox";
            this.Numero_de_Page_ComboBox.Size = new System.Drawing.Size(62, 21);
            this.Numero_de_Page_ComboBox.TabIndex = 5;
            this.Numero_de_Page_ComboBox.Text = "Page 1";
            this.Numero_de_Page_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Numero_de_Page_ComboBox_SelectedIndexChanged);
            this.Numero_de_Page_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_de_Page_ComboBox_KeyPress);
            // 
            // Numero_Afficheur_ComboBox
            // 
            this.Numero_Afficheur_ComboBox.FormattingEnabled = true;
            this.Numero_Afficheur_ComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06"});
            this.Numero_Afficheur_ComboBox.Location = new System.Drawing.Point(108, 20);
            this.Numero_Afficheur_ComboBox.Name = "Numero_Afficheur_ComboBox";
            this.Numero_Afficheur_ComboBox.Size = new System.Drawing.Size(62, 21);
            this.Numero_Afficheur_ComboBox.TabIndex = 6;
            this.Numero_Afficheur_ComboBox.Text = "01";
            this.Numero_Afficheur_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Numero_Afficheur_ComboBox_SelectedIndexChanged);
            this.Numero_Afficheur_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_Afficheur_ComboBox_KeyPress);
            // 
            // Change_Language_Button
            // 
            this.Change_Language_Button.Location = new System.Drawing.Point(20, 70);
            this.Change_Language_Button.Name = "Change_Language_Button";
            this.Change_Language_Button.Size = new System.Drawing.Size(156, 23);
            this.Change_Language_Button.TabIndex = 7;
            this.Change_Language_Button.Text = "Changer de Langue";
            this.Change_Language_Button.UseVisualStyleBackColor = true;
            this.Change_Language_Button.Click += new System.EventHandler(this.Language_Change_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(12, 358);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(238, 66);
            this.OK_Button.TabIndex = 9;
            this.OK_Button.Text = "Envoyer";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // RS232_Settings_Button
            // 
            this.RS232_Settings_Button.Location = new System.Drawing.Point(20, 16);
            this.RS232_Settings_Button.Name = "RS232_Settings_Button";
            this.RS232_Settings_Button.Size = new System.Drawing.Size(156, 23);
            this.RS232_Settings_Button.TabIndex = 10;
            this.RS232_Settings_Button.Text = "Paramètres RS232";
            this.RS232_Settings_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RS232_Settings_Button.UseVisualStyleBackColor = true;
            this.RS232_Settings_Button.Click += new System.EventHandler(this.RS232_Settings_Button_Click);
            // 
            // Serial_Input_TextBox
            // 
            this.Serial_Input_TextBox.Location = new System.Drawing.Point(6, 17);
            this.Serial_Input_TextBox.Multiline = true;
            this.Serial_Input_TextBox.Name = "Serial_Input_TextBox";
            this.Serial_Input_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Serial_Input_TextBox.Size = new System.Drawing.Size(521, 402);
            this.Serial_Input_TextBox.TabIndex = 11;
            this.Serial_Input_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Serial_Input_TextBox_KeyPress);
            // 
            // Dispay_Number_Label
            // 
            this.Dispay_Number_Label.AutoSize = true;
            this.Dispay_Number_Label.Location = new System.Drawing.Point(6, 21);
            this.Dispay_Number_Label.Name = "Dispay_Number_Label";
            this.Dispay_Number_Label.Size = new System.Drawing.Size(96, 13);
            this.Dispay_Number_Label.TabIndex = 13;
            this.Dispay_Number_Label.Text = "Numéro d\'afficheur";
            // 
            // Page_of_Message_Label
            // 
            this.Page_of_Message_Label.AutoSize = true;
            this.Page_of_Message_Label.Location = new System.Drawing.Point(6, 50);
            this.Page_of_Message_Label.Name = "Page_of_Message_Label";
            this.Page_of_Message_Label.Size = new System.Drawing.Size(93, 13);
            this.Page_of_Message_Label.TabIndex = 14;
            this.Page_of_Message_Label.Text = "Page de Message";
            // 
            // Message_label
            // 
            this.Message_label.AutoSize = true;
            this.Message_label.Location = new System.Drawing.Point(8, 26);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(104, 13);
            this.Message_label.TabIndex = 15;
            this.Message_label.Text = "Message a Afficher :";
            // 
            // Speed_ComboBox
            // 
            this.Speed_ComboBox.FormattingEnabled = true;
            this.Speed_ComboBox.Items.AddRange(new object[] {
            "Vitesse 1 (Lent)",
            "Vitesse 2",
            "Vitesse 3",
            "Vitesse 4 (Rapide)"});
            this.Speed_ComboBox.Location = new System.Drawing.Point(8, 102);
            this.Speed_ComboBox.Name = "Speed_ComboBox";
            this.Speed_ComboBox.Size = new System.Drawing.Size(150, 21);
            this.Speed_ComboBox.TabIndex = 16;
            this.Speed_ComboBox.Text = "Vitesse 2";
            this.Speed_ComboBox.SelectionChangeCommitted += new System.EventHandler(this.Speed_ComboBox_SelectedIndexChanged);
            this.Speed_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Speed_ComboBox_KeyPress);
            // 
            // Transition_appearance_message_Label
            // 
            this.Transition_appearance_message_Label.AutoSize = true;
            this.Transition_appearance_message_Label.Location = new System.Drawing.Point(8, 16);
            this.Transition_appearance_message_Label.Name = "Transition_appearance_message_Label";
            this.Transition_appearance_message_Label.Size = new System.Drawing.Size(147, 13);
            this.Transition_appearance_message_Label.TabIndex = 17;
            this.Transition_appearance_message_Label.Text = "Transition apparition message";
            // 
            // Transition_Disappearance_message_label
            // 
            this.Transition_Disappearance_message_label.AutoSize = true;
            this.Transition_Disappearance_message_label.Location = new System.Drawing.Point(164, 16);
            this.Transition_Disappearance_message_label.Name = "Transition_Disappearance_message_label";
            this.Transition_Disappearance_message_label.Size = new System.Drawing.Size(150, 13);
            this.Transition_Disappearance_message_label.TabIndex = 18;
            this.Transition_Disappearance_message_label.Text = "Transition Disparition message";
            // 
            // Export_to_XML_Button
            // 
            this.Export_to_XML_Button.Location = new System.Drawing.Point(20, 99);
            this.Export_to_XML_Button.Name = "Export_to_XML_Button";
            this.Export_to_XML_Button.Size = new System.Drawing.Size(156, 23);
            this.Export_to_XML_Button.TabIndex = 20;
            this.Export_to_XML_Button.Text = "Export Historique com. XML ";
            this.Export_to_XML_Button.UseVisualStyleBackColor = true;
            this.Export_to_XML_Button.Click += new System.EventHandler(this.Export_to_XML_Button_Click);
            // 
            // Scroll_Speed_Label
            // 
            this.Scroll_Speed_Label.AutoSize = true;
            this.Scroll_Speed_Label.Location = new System.Drawing.Point(7, 86);
            this.Scroll_Speed_Label.Name = "Scroll_Speed_Label";
            this.Scroll_Speed_Label.Size = new System.Drawing.Size(107, 13);
            this.Scroll_Speed_Label.TabIndex = 21;
            this.Scroll_Speed_Label.Text = "Vitesse de defilement";
            // 
            // Display_Settings_GroupBox
            // 
            this.Display_Settings_GroupBox.Controls.Add(this.Text_color_Label);
            this.Display_Settings_GroupBox.Controls.Add(this.Text_color_ComboBox);
            this.Display_Settings_GroupBox.Controls.Add(this.Transition_Disappearance_message_label);
            this.Display_Settings_GroupBox.Controls.Add(this.Scroll_Speed_Label);
            this.Display_Settings_GroupBox.Controls.Add(this.Text_Effet_Entre_ComboBox);
            this.Display_Settings_GroupBox.Controls.Add(this.Text_Effet_Sortie_ComboBox);
            this.Display_Settings_GroupBox.Controls.Add(this.Speed_ComboBox);
            this.Display_Settings_GroupBox.Controls.Add(this.Transition_appearance_message_Label);
            this.Display_Settings_GroupBox.Location = new System.Drawing.Point(12, 220);
            this.Display_Settings_GroupBox.Name = "Display_Settings_GroupBox";
            this.Display_Settings_GroupBox.Size = new System.Drawing.Size(336, 132);
            this.Display_Settings_GroupBox.TabIndex = 22;
            this.Display_Settings_GroupBox.TabStop = false;
            this.Display_Settings_GroupBox.Text = "Parametre de l\'affichage";
            // 
            // Text_color_Label
            // 
            this.Text_color_Label.AutoSize = true;
            this.Text_color_Label.Location = new System.Drawing.Point(166, 84);
            this.Text_color_Label.Name = "Text_color_Label";
            this.Text_color_Label.Size = new System.Drawing.Size(72, 13);
            this.Text_color_Label.TabIndex = 23;
            this.Text_color_Label.Text = "Coleur du text";
            // 
            // Text_color_ComboBox
            // 
            this.Text_color_ComboBox.FormattingEnabled = true;
            this.Text_color_ComboBox.Items.AddRange(new object[] {
            "Rouge",
            "Vert",
            "Orange",
            "Rouge inversé",
            "Vert inversé",
            "Orange inversé",
            "Rouge font Vert",
            "Vert font Rouge",
            "Rouge Vert Orange",
            "Arc en ciel"});
            this.Text_color_ComboBox.Location = new System.Drawing.Point(164, 102);
            this.Text_color_ComboBox.Name = "Text_color_ComboBox";
            this.Text_color_ComboBox.Size = new System.Drawing.Size(147, 21);
            this.Text_color_ComboBox.TabIndex = 22;
            this.Text_color_ComboBox.Text = "Rouge";
            this.Text_color_ComboBox.SelectionChangeCommitted += new System.EventHandler(this.Text_color_ComboBox_SelectedIndexChanged);
            this.Text_color_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_color_ComboBox_KeyPress);
            // 
            // General_Settings_GroupBox
            // 
            this.General_Settings_GroupBox.Controls.Add(this.Import_to_XML_Button);
            this.General_Settings_GroupBox.Controls.Add(this.RS232_Settings_Button);
            this.General_Settings_GroupBox.Controls.Add(this.Drawing_Button);
            this.General_Settings_GroupBox.Controls.Add(this.Light_Plus_button);
            this.General_Settings_GroupBox.Controls.Add(this.Export_to_XML_Button);
            this.General_Settings_GroupBox.Controls.Add(this.Light_Moins_button);
            this.General_Settings_GroupBox.Controls.Add(this.Change_Language_Button);
            this.General_Settings_GroupBox.Location = new System.Drawing.Point(259, 13);
            this.General_Settings_GroupBox.Name = "General_Settings_GroupBox";
            this.General_Settings_GroupBox.Size = new System.Drawing.Size(195, 201);
            this.General_Settings_GroupBox.TabIndex = 23;
            this.General_Settings_GroupBox.TabStop = false;
            this.General_Settings_GroupBox.Text = "Parametres Genéraux et Dessin";
            // 
            // Import_to_XML_Button
            // 
            this.Import_to_XML_Button.Location = new System.Drawing.Point(20, 128);
            this.Import_to_XML_Button.Name = "Import_to_XML_Button";
            this.Import_to_XML_Button.Size = new System.Drawing.Size(156, 23);
            this.Import_to_XML_Button.TabIndex = 21;
            this.Import_to_XML_Button.Text = "Import Historique com. XML ";
            this.Import_to_XML_Button.UseVisualStyleBackColor = true;
            this.Import_to_XML_Button.Click += new System.EventHandler(this.Import_to_XML_Button_Click);
            // 
            // Drawing_Button
            // 
            this.Drawing_Button.Enabled = false;
            this.Drawing_Button.Location = new System.Drawing.Point(20, 161);
            this.Drawing_Button.Name = "Drawing_Button";
            this.Drawing_Button.Size = new System.Drawing.Size(156, 23);
            this.Drawing_Button.TabIndex = 19;
            this.Drawing_Button.Text = "Dessin";
            this.Drawing_Button.UseVisualStyleBackColor = true;
            this.Drawing_Button.Click += new System.EventHandler(this.Drawing_Button_Click);
            // 
            // Page_Settings_GroupBox
            // 
            this.Page_Settings_GroupBox.Controls.Add(this.Dispay_Number_Label);
            this.Page_Settings_GroupBox.Controls.Add(this.Numero_de_Page_ComboBox);
            this.Page_Settings_GroupBox.Controls.Add(this.Numero_Afficheur_ComboBox);
            this.Page_Settings_GroupBox.Controls.Add(this.Page_of_Message_Label);
            this.Page_Settings_GroupBox.Location = new System.Drawing.Point(12, 12);
            this.Page_Settings_GroupBox.Name = "Page_Settings_GroupBox";
            this.Page_Settings_GroupBox.Size = new System.Drawing.Size(238, 97);
            this.Page_Settings_GroupBox.TabIndex = 24;
            this.Page_Settings_GroupBox.TabStop = false;
            this.Page_Settings_GroupBox.Text = "Paramètre de Page";
            // 
            // Message_GroupBox
            // 
            this.Message_GroupBox.Controls.Add(this.LRC_Label);
            this.Message_GroupBox.Controls.Add(this.label7);
            this.Message_GroupBox.Controls.Add(this.Message_label);
            this.Message_GroupBox.Controls.Add(this.Text_Message_TextBox);
            this.Message_GroupBox.Location = new System.Drawing.Point(12, 115);
            this.Message_GroupBox.Name = "Message_GroupBox";
            this.Message_GroupBox.Size = new System.Drawing.Size(238, 101);
            this.Message_GroupBox.TabIndex = 25;
            this.Message_GroupBox.TabStop = false;
            this.Message_GroupBox.Text = "Message";
            // 
            // LRC_Label
            // 
            this.LRC_Label.AutoSize = true;
            this.LRC_Label.Location = new System.Drawing.Point(48, 69);
            this.LRC_Label.Name = "LRC_Label";
            this.LRC_Label.Size = new System.Drawing.Size(14, 13);
            this.LRC_Label.TabIndex = 17;
            this.LRC_Label.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "LRC :";
            // 
            // Verbose_Serial_GroupBox
            // 
            this.Verbose_Serial_GroupBox.Controls.Add(this.Serial_Input_TextBox);
            this.Verbose_Serial_GroupBox.Location = new System.Drawing.Point(460, 13);
            this.Verbose_Serial_GroupBox.Name = "Verbose_Serial_GroupBox";
            this.Verbose_Serial_GroupBox.Size = new System.Drawing.Size(533, 425);
            this.Verbose_Serial_GroupBox.TabIndex = 26;
            this.Verbose_Serial_GroupBox.TabStop = false;
            this.Verbose_Serial_GroupBox.Text = "Dialogue sur la ligne Serial";
            this.Verbose_Serial_GroupBox.Enter += new System.EventHandler(this.Verbose_Serial_GroupBox_Enter);
            // 
            // Info_LRC_Button
            // 
            this.Info_LRC_Button.Enabled = false;
            this.Info_LRC_Button.Location = new System.Drawing.Point(354, 306);
            this.Info_LRC_Button.Name = "Info_LRC_Button";
            this.Info_LRC_Button.Size = new System.Drawing.Size(100, 46);
            this.Info_LRC_Button.TabIndex = 27;
            this.Info_LRC_Button.Text = "Info LRC";
            this.Info_LRC_Button.UseVisualStyleBackColor = true;
            this.Info_LRC_Button.Click += new System.EventHandler(this.Info_LRC_Button_Click);
            // 
            // Settings_Display_GroupBox
            // 
            this.Settings_Display_GroupBox.Controls.Add(this.comboBox2);
            this.Settings_Display_GroupBox.Controls.Add(this.Val_Button);
            this.Settings_Display_GroupBox.Location = new System.Drawing.Point(354, 221);
            this.Settings_Display_GroupBox.Name = "Settings_Display_GroupBox";
            this.Settings_Display_GroupBox.Size = new System.Drawing.Size(100, 79);
            this.Settings_Display_GroupBox.TabIndex = 28;
            this.Settings_Display_GroupBox.TabStop = false;
            this.Settings_Display_GroupBox.Text = "Jusqu\'a la Page";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06"});
            this.comboBox2.Location = new System.Drawing.Point(7, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(87, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "01";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // Val_Button
            // 
            this.Val_Button.Location = new System.Drawing.Point(7, 45);
            this.Val_Button.Name = "Val_Button";
            this.Val_Button.Size = new System.Drawing.Size(87, 23);
            this.Val_Button.TabIndex = 0;
            this.Val_Button.Text = "Valider";
            this.Val_Button.UseVisualStyleBackColor = true;
            this.Val_Button.Click += new System.EventHandler(this.Val_Button_Click);
            // 
            // ThreadOfMessage
            // 
            this.ThreadOfMessage.WorkerReportsProgress = true;
            this.ThreadOfMessage.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ThreadOfMessage_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "By Benoit de Marion (Bensuperpc) , 2018";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Serial_True_RadioButton);
            this.groupBox1.Controls.Add(this.Ethernet_True_RadioButton);
            this.groupBox1.Location = new System.Drawing.Point(354, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 64);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication";
            // 
            // Serial_True_RadioButton
            // 
            this.Serial_True_RadioButton.AutoSize = true;
            this.Serial_True_RadioButton.Checked = true;
            this.Serial_True_RadioButton.Location = new System.Drawing.Point(7, 18);
            this.Serial_True_RadioButton.Name = "Serial_True_RadioButton";
            this.Serial_True_RadioButton.Size = new System.Drawing.Size(51, 17);
            this.Serial_True_RadioButton.TabIndex = 1;
            this.Serial_True_RadioButton.TabStop = true;
            this.Serial_True_RadioButton.Text = "Serial";
            this.Serial_True_RadioButton.UseVisualStyleBackColor = true;
            this.Serial_True_RadioButton.CheckedChanged += new System.EventHandler(this.Serial_True_RadioButton_CheckedChanged);
            // 
            // Ethernet_True_RadioButton
            // 
            this.Ethernet_True_RadioButton.AutoSize = true;
            this.Ethernet_True_RadioButton.Location = new System.Drawing.Point(7, 41);
            this.Ethernet_True_RadioButton.Name = "Ethernet_True_RadioButton";
            this.Ethernet_True_RadioButton.Size = new System.Drawing.Size(65, 17);
            this.Ethernet_True_RadioButton.TabIndex = 0;
            this.Ethernet_True_RadioButton.Text = "Ethernet";
            this.Ethernet_True_RadioButton.UseVisualStyleBackColor = true;
            this.Ethernet_True_RadioButton.CheckedChanged += new System.EventHandler(this.Ethernet_True_RadioButton_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Settings_Display_GroupBox);
            this.Controls.Add(this.Info_LRC_Button);
            this.Controls.Add(this.Verbose_Serial_GroupBox);
            this.Controls.Add(this.Message_GroupBox);
            this.Controls.Add(this.Page_Settings_GroupBox);
            this.Controls.Add(this.General_Settings_GroupBox);
            this.Controls.Add(this.Display_Settings_GroupBox);
            this.Controls.Add(this.OK_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Afficheur V1.0b";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Display_Settings_GroupBox.ResumeLayout(false);
            this.Display_Settings_GroupBox.PerformLayout();
            this.General_Settings_GroupBox.ResumeLayout(false);
            this.Page_Settings_GroupBox.ResumeLayout(false);
            this.Page_Settings_GroupBox.PerformLayout();
            this.Message_GroupBox.ResumeLayout(false);
            this.Message_GroupBox.PerformLayout();
            this.Verbose_Serial_GroupBox.ResumeLayout(false);
            this.Verbose_Serial_GroupBox.PerformLayout();
            this.Settings_Display_GroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Text_Effet_Entre_ComboBox;
        private System.Windows.Forms.Button Light_Plus_button;
        private System.Windows.Forms.Button Light_Moins_button;
        private System.Windows.Forms.ComboBox Text_Effet_Sortie_ComboBox;
        private System.Windows.Forms.TextBox Text_Message_TextBox;
        private System.Windows.Forms.ComboBox Numero_de_Page_ComboBox;
        private System.Windows.Forms.ComboBox Numero_Afficheur_ComboBox;
        private System.Windows.Forms.Button Change_Language_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button RS232_Settings_Button;
        private System.Windows.Forms.TextBox Serial_Input_TextBox;
        private System.Windows.Forms.Label Dispay_Number_Label;
        private System.Windows.Forms.Label Page_of_Message_Label;
        private System.Windows.Forms.Label Message_label;
        private System.Windows.Forms.ComboBox Speed_ComboBox;
        private System.Windows.Forms.Label Transition_appearance_message_Label;
        private System.Windows.Forms.Label Transition_Disappearance_message_label;
        private System.Windows.Forms.Button Export_to_XML_Button;
        private System.Windows.Forms.Label Scroll_Speed_Label;
        private System.Windows.Forms.GroupBox Display_Settings_GroupBox;
        private System.Windows.Forms.GroupBox General_Settings_GroupBox;
        private System.Windows.Forms.GroupBox Page_Settings_GroupBox;
        private System.Windows.Forms.GroupBox Message_GroupBox;
        private System.Windows.Forms.Label LRC_Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Verbose_Serial_GroupBox;
        private System.Windows.Forms.Button Info_LRC_Button;
        private System.Windows.Forms.GroupBox Settings_Display_GroupBox;
        private System.Windows.Forms.Button Val_Button;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.ComponentModel.BackgroundWorker ThreadOfMessage;
        private System.Windows.Forms.Label Text_color_Label;
        private System.Windows.Forms.ComboBox Text_color_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Serial_True_RadioButton;
        private System.Windows.Forms.RadioButton Ethernet_True_RadioButton;
        private System.Windows.Forms.Button Drawing_Button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Import_to_XML_Button;
    }
}

