namespace Contact_Tracing_App
{
    partial class ContactTracingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactTracingForm));
            this.FormTitle = new System.Windows.Forms.Label();
            this.ConsentCheckbox = new System.Windows.Forms.CheckBox();
            this.FormInstruction = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Namelabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.Nametextbox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateTextbox = new System.Windows.Forms.TextBox();
            this.TimeinLabel = new System.Windows.Forms.Label();
            this.TimeInTextbox = new System.Windows.Forms.TextBox();
            this.TimeoutLabel = new System.Windows.Forms.Label();
            this.TimeoutTextbox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.ContactNumberTextbox = new System.Windows.Forms.TextBox();
            this.VisitorInfoLabel = new System.Windows.Forms.Label();
            this.EmergencyContactInfoLabel = new System.Windows.Forms.Label();
            this.EmergencyNumberTextbox = new System.Windows.Forms.TextBox();
            this.EmergencyNumberLabel = new System.Windows.Forms.Label();
            this.EmergencyAddressTextbox = new System.Windows.Forms.TextBox();
            this.EmergencyAddressLabel = new System.Windows.Forms.Label();
            this.EmergencyNameTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmergencyNameLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.DateFormatLabel = new System.Windows.Forms.Label();
            this.DateFormatExample = new System.Windows.Forms.Label();
            this.TimeFormat = new System.Windows.Forms.Label();
            this.TimeFormatExample = new System.Windows.Forms.Label();
            this.DataListbox = new System.Windows.Forms.ListBox();
            this.Informationsubmittedlabel = new System.Windows.Forms.Label();
            this.Searchtextbox = new System.Windows.Forms.TextBox();
            this.Searchboxlabel = new System.Windows.Forms.Label();
            this.Resultsbox = new System.Windows.Forms.RichTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.QRCodelabel = new System.Windows.Forms.Label();
            this.OpenCameraButton = new System.Windows.Forms.Button();
            this.QRCodeResultsBox = new System.Windows.Forms.RichTextBox();
            this.CameraBox = new System.Windows.Forms.PictureBox();
            this.Cameralabel = new System.Windows.Forms.Label();
            this.CamComboBox = new System.Windows.Forms.ComboBox();
            this.QRCodeResultsLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CodeButton = new System.Windows.Forms.Button();
            this.QRCODEPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRCODEPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormTitle.ForeColor = System.Drawing.Color.SkyBlue;
            this.FormTitle.Location = new System.Drawing.Point(23, 25);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(870, 91);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "Covid Contact Tracing";
            this.FormTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConsentCheckbox
            // 
            this.ConsentCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConsentCheckbox.AutoSize = true;
            this.ConsentCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.ConsentCheckbox.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ConsentCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ConsentCheckbox.Font = new System.Drawing.Font("Helvetica Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsentCheckbox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.ConsentCheckbox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ConsentCheckbox.Location = new System.Drawing.Point(44, 152);
            this.ConsentCheckbox.Name = "ConsentCheckbox";
            this.ConsentCheckbox.Size = new System.Drawing.Size(840, 37);
            this.ConsentCheckbox.TabIndex = 1;
            this.ConsentCheckbox.Text = resources.GetString("ConsentCheckbox.Text");
            this.ConsentCheckbox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ConsentCheckbox.UseVisualStyleBackColor = false;
            this.ConsentCheckbox.CheckedChanged += new System.EventHandler(this.ConsentCheckbox_CheckedChanged);
            // 
            // FormInstruction
            // 
            this.FormInstruction.AutoSize = true;
            this.FormInstruction.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FormInstruction.ForeColor = System.Drawing.Color.SkyBlue;
            this.FormInstruction.Location = new System.Drawing.Point(44, 116);
            this.FormInstruction.Name = "FormInstruction";
            this.FormInstruction.Size = new System.Drawing.Size(617, 20);
            this.FormInstruction.TabIndex = 2;
            this.FormInstruction.Text = "Please accomplish this form with accurate information before entering the establi" +
    "shment.";
            this.FormInstruction.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Namelabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.Namelabel.Location = new System.Drawing.Point(23, 260);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(76, 23);
            this.Namelabel.TabIndex = 3;
            this.Namelabel.Text = "Name:";
            this.Namelabel.Click += new System.EventHandler(this.Namelabel_Click);
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SexLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.SexLabel.Location = new System.Drawing.Point(255, 290);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(0, 37);
            this.SexLabel.TabIndex = 5;
            this.SexLabel.Click += new System.EventHandler(this.SexLabel_Click);
            // 
            // Nametextbox
            // 
            this.Nametextbox.Location = new System.Drawing.Point(105, 260);
            this.Nametextbox.Name = "Nametextbox";
            this.Nametextbox.Size = new System.Drawing.Size(307, 27);
            this.Nametextbox.TabIndex = 6;
            this.Nametextbox.TextChanged += new System.EventHandler(this.Nametextbox_TextChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.DateLabel.Location = new System.Drawing.Point(431, 260);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(62, 23);
            this.DateLabel.TabIndex = 8;
            this.DateLabel.Text = "Date:";
            // 
            // DateTextbox
            // 
            this.DateTextbox.Location = new System.Drawing.Point(499, 260);
            this.DateTextbox.Name = "DateTextbox";
            this.DateTextbox.Size = new System.Drawing.Size(166, 27);
            this.DateTextbox.TabIndex = 9;
            this.DateTextbox.TextChanged += new System.EventHandler(this.DateTextbox_TextChanged);
            // 
            // TimeinLabel
            // 
            this.TimeinLabel.AutoSize = true;
            this.TimeinLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeinLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.TimeinLabel.Location = new System.Drawing.Point(665, 260);
            this.TimeinLabel.Name = "TimeinLabel";
            this.TimeinLabel.Size = new System.Drawing.Size(84, 23);
            this.TimeinLabel.TabIndex = 10;
            this.TimeinLabel.Text = "Time in:";
            this.TimeinLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // TimeInTextbox
            // 
            this.TimeInTextbox.Location = new System.Drawing.Point(755, 260);
            this.TimeInTextbox.Name = "TimeInTextbox";
            this.TimeInTextbox.Size = new System.Drawing.Size(120, 27);
            this.TimeInTextbox.TabIndex = 11;
            this.TimeInTextbox.TextChanged += new System.EventHandler(this.TimeInTextbox_TextChanged);
            // 
            // TimeoutLabel
            // 
            this.TimeoutLabel.AutoSize = true;
            this.TimeoutLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeoutLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.TimeoutLabel.Location = new System.Drawing.Point(651, 302);
            this.TimeoutLabel.Name = "TimeoutLabel";
            this.TimeoutLabel.Size = new System.Drawing.Size(98, 23);
            this.TimeoutLabel.TabIndex = 12;
            this.TimeoutLabel.Text = "Time out:";
            this.TimeoutLabel.Click += new System.EventHandler(this.TimeoutLabel_Click);
            // 
            // TimeoutTextbox
            // 
            this.TimeoutTextbox.Location = new System.Drawing.Point(755, 302);
            this.TimeoutTextbox.Name = "TimeoutTextbox";
            this.TimeoutTextbox.Size = new System.Drawing.Size(120, 27);
            this.TimeoutTextbox.TabIndex = 13;
            this.TimeoutTextbox.TextChanged += new System.EventHandler(this.TimeoutTextbox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.AddressLabel.Location = new System.Drawing.Point(23, 302);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(94, 23);
            this.AddressLabel.TabIndex = 14;
            this.AddressLabel.Text = "Address:";
            this.AddressLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(123, 302);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(501, 27);
            this.AddressTextBox.TabIndex = 15;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactNumberLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.ContactNumberLabel.Location = new System.Drawing.Point(23, 346);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(179, 23);
            this.ContactNumberLabel.TabIndex = 16;
            this.ContactNumberLabel.Text = "Contact Number:";
            this.ContactNumberLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // ContactNumberTextbox
            // 
            this.ContactNumberTextbox.Location = new System.Drawing.Point(208, 346);
            this.ContactNumberTextbox.Name = "ContactNumberTextbox";
            this.ContactNumberTextbox.Size = new System.Drawing.Size(238, 27);
            this.ContactNumberTextbox.TabIndex = 17;
            this.ContactNumberTextbox.TextChanged += new System.EventHandler(this.ContactNumberTextbox_TextChanged);
            // 
            // VisitorInfoLabel
            // 
            this.VisitorInfoLabel.AutoSize = true;
            this.VisitorInfoLabel.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.VisitorInfoLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.VisitorInfoLabel.Location = new System.Drawing.Point(23, 214);
            this.VisitorInfoLabel.Name = "VisitorInfoLabel";
            this.VisitorInfoLabel.Size = new System.Drawing.Size(335, 40);
            this.VisitorInfoLabel.TabIndex = 18;
            this.VisitorInfoLabel.Text = "Visitor\'s Information:";
            this.VisitorInfoLabel.Click += new System.EventHandler(this.VisitorInfoLabel_Click);
            // 
            // EmergencyContactInfoLabel
            // 
            this.EmergencyContactInfoLabel.AutoSize = true;
            this.EmergencyContactInfoLabel.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmergencyContactInfoLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.EmergencyContactInfoLabel.Location = new System.Drawing.Point(23, 396);
            this.EmergencyContactInfoLabel.Name = "EmergencyContactInfoLabel";
            this.EmergencyContactInfoLabel.Size = new System.Drawing.Size(539, 40);
            this.EmergencyContactInfoLabel.TabIndex = 19;
            this.EmergencyContactInfoLabel.Text = "Emergency Contact Information:";
            this.EmergencyContactInfoLabel.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // EmergencyNumberTextbox
            // 
            this.EmergencyNumberTextbox.Location = new System.Drawing.Point(637, 451);
            this.EmergencyNumberTextbox.Name = "EmergencyNumberTextbox";
            this.EmergencyNumberTextbox.Size = new System.Drawing.Size(238, 27);
            this.EmergencyNumberTextbox.TabIndex = 32;
            this.EmergencyNumberTextbox.TextChanged += new System.EventHandler(this.EmergencyNumberTextbox_TextChanged);
            // 
            // EmergencyNumberLabel
            // 
            this.EmergencyNumberLabel.AutoSize = true;
            this.EmergencyNumberLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmergencyNumberLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.EmergencyNumberLabel.Location = new System.Drawing.Point(452, 451);
            this.EmergencyNumberLabel.Name = "EmergencyNumberLabel";
            this.EmergencyNumberLabel.Size = new System.Drawing.Size(179, 23);
            this.EmergencyNumberLabel.TabIndex = 31;
            this.EmergencyNumberLabel.Text = "Contact Number:";
            this.EmergencyNumberLabel.Click += new System.EventHandler(this.EmergencyNumberLabel_Click);
            // 
            // EmergencyAddressTextbox
            // 
            this.EmergencyAddressTextbox.Location = new System.Drawing.Point(134, 497);
            this.EmergencyAddressTextbox.Name = "EmergencyAddressTextbox";
            this.EmergencyAddressTextbox.Size = new System.Drawing.Size(501, 27);
            this.EmergencyAddressTextbox.TabIndex = 30;
            this.EmergencyAddressTextbox.TextChanged += new System.EventHandler(this.EmergencyAddressTextbox_TextChanged);
            // 
            // EmergencyAddressLabel
            // 
            this.EmergencyAddressLabel.AutoSize = true;
            this.EmergencyAddressLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmergencyAddressLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.EmergencyAddressLabel.Location = new System.Drawing.Point(34, 497);
            this.EmergencyAddressLabel.Name = "EmergencyAddressLabel";
            this.EmergencyAddressLabel.Size = new System.Drawing.Size(94, 23);
            this.EmergencyAddressLabel.TabIndex = 29;
            this.EmergencyAddressLabel.Text = "Address:";
            this.EmergencyAddressLabel.Click += new System.EventHandler(this.EmergencyAddressLabel_Click);
            // 
            // EmergencyNameTextbox
            // 
            this.EmergencyNameTextbox.Location = new System.Drawing.Point(116, 455);
            this.EmergencyNameTextbox.Name = "EmergencyNameTextbox";
            this.EmergencyNameTextbox.Size = new System.Drawing.Size(307, 27);
            this.EmergencyNameTextbox.TabIndex = 22;
            this.EmergencyNameTextbox.TextChanged += new System.EventHandler(this.EmergencyNameTextbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SkyBlue;
            this.label6.Location = new System.Drawing.Point(266, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 37);
            this.label6.TabIndex = 21;
            // 
            // EmergencyNameLabel
            // 
            this.EmergencyNameLabel.AutoSize = true;
            this.EmergencyNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmergencyNameLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.EmergencyNameLabel.Location = new System.Drawing.Point(34, 455);
            this.EmergencyNameLabel.Name = "EmergencyNameLabel";
            this.EmergencyNameLabel.Size = new System.Drawing.Size(76, 23);
            this.EmergencyNameLabel.TabIndex = 20;
            this.EmergencyNameLabel.Text = "Name:";
            this.EmergencyNameLabel.Click += new System.EventHandler(this.EmergencyNameLabel_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(781, 493);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(94, 35);
            this.DoneButton.TabIndex = 33;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // DateFormatLabel
            // 
            this.DateFormatLabel.AutoSize = true;
            this.DateFormatLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DateFormatLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.DateFormatLabel.Location = new System.Drawing.Point(499, 207);
            this.DateFormatLabel.Name = "DateFormatLabel";
            this.DateFormatLabel.Size = new System.Drawing.Size(147, 25);
            this.DateFormatLabel.TabIndex = 34;
            this.DateFormatLabel.Text = "Month/Day/Year";
            this.DateFormatLabel.Click += new System.EventHandler(this.label1_Click_5);
            // 
            // DateFormatExample
            // 
            this.DateFormatExample.AutoSize = true;
            this.DateFormatExample.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DateFormatExample.ForeColor = System.Drawing.Color.SkyBlue;
            this.DateFormatExample.Location = new System.Drawing.Point(499, 232);
            this.DateFormatExample.Name = "DateFormatExample";
            this.DateFormatExample.Size = new System.Drawing.Size(106, 25);
            this.DateFormatExample.TabIndex = 35;
            this.DateFormatExample.Text = "00-00-0000";
            // 
            // TimeFormat
            // 
            this.TimeFormat.AutoSize = true;
            this.TimeFormat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TimeFormat.ForeColor = System.Drawing.Color.SkyBlue;
            this.TimeFormat.Location = new System.Drawing.Point(728, 207);
            this.TimeFormat.Name = "TimeFormat";
            this.TimeFormat.Size = new System.Drawing.Size(156, 25);
            this.TimeFormat.TabIndex = 36;
            this.TimeFormat.Text = "Use 24 hour value";
            this.TimeFormat.Click += new System.EventHandler(this.label1_Click_6);
            // 
            // TimeFormatExample
            // 
            this.TimeFormatExample.AutoSize = true;
            this.TimeFormatExample.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TimeFormatExample.ForeColor = System.Drawing.Color.SkyBlue;
            this.TimeFormatExample.Location = new System.Drawing.Point(819, 232);
            this.TimeFormatExample.Name = "TimeFormatExample";
            this.TimeFormatExample.Size = new System.Drawing.Size(56, 25);
            this.TimeFormatExample.TabIndex = 37;
            this.TimeFormatExample.Text = "00:00";
            // 
            // DataListbox
            // 
            this.DataListbox.FormattingEnabled = true;
            this.DataListbox.ItemHeight = 20;
            this.DataListbox.Location = new System.Drawing.Point(916, 37);
            this.DataListbox.Name = "DataListbox";
            this.DataListbox.Size = new System.Drawing.Size(532, 244);
            this.DataListbox.TabIndex = 38;
            this.DataListbox.SelectedIndexChanged += new System.EventHandler(this.DataSubmitted_SelectedIndexChanged);
            // 
            // Informationsubmittedlabel
            // 
            this.Informationsubmittedlabel.AutoSize = true;
            this.Informationsubmittedlabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Informationsubmittedlabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.Informationsubmittedlabel.Location = new System.Drawing.Point(916, 11);
            this.Informationsubmittedlabel.Name = "Informationsubmittedlabel";
            this.Informationsubmittedlabel.Size = new System.Drawing.Size(229, 23);
            this.Informationsubmittedlabel.TabIndex = 39;
            this.Informationsubmittedlabel.Text = "Information submitted:";
            // 
            // Searchtextbox
            // 
            this.Searchtextbox.Location = new System.Drawing.Point(1065, 300);
            this.Searchtextbox.Name = "Searchtextbox";
            this.Searchtextbox.Size = new System.Drawing.Size(238, 27);
            this.Searchtextbox.TabIndex = 40;
            // 
            // Searchboxlabel
            // 
            this.Searchboxlabel.AutoSize = true;
            this.Searchboxlabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Searchboxlabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.Searchboxlabel.Location = new System.Drawing.Point(916, 300);
            this.Searchboxlabel.Name = "Searchboxlabel";
            this.Searchboxlabel.Size = new System.Drawing.Size(134, 46);
            this.Searchboxlabel.TabIndex = 41;
            this.Searchboxlabel.Text = "Search date:\r\n00-00-0000";
            // 
            // Resultsbox
            // 
            this.Resultsbox.Location = new System.Drawing.Point(925, 357);
            this.Resultsbox.Name = "Resultsbox";
            this.Resultsbox.Size = new System.Drawing.Size(511, 260);
            this.Resultsbox.TabIndex = 42;
            this.Resultsbox.Text = "";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1309, 300);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(94, 29);
            this.SearchButton.TabIndex = 43;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // QRCodelabel
            // 
            this.QRCodelabel.AutoSize = true;
            this.QRCodelabel.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QRCodelabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.QRCodelabel.Location = new System.Drawing.Point(23, 551);
            this.QRCodelabel.Name = "QRCodelabel";
            this.QRCodelabel.Size = new System.Drawing.Size(338, 56);
            this.QRCodelabel.TabIndex = 44;
            this.QRCodelabel.Text = "Use QR Code:";
            // 
            // OpenCameraButton
            // 
            this.OpenCameraButton.Location = new System.Drawing.Point(651, 567);
            this.OpenCameraButton.Name = "OpenCameraButton";
            this.OpenCameraButton.Size = new System.Drawing.Size(128, 35);
            this.OpenCameraButton.TabIndex = 45;
            this.OpenCameraButton.Text = "Open Camera";
            this.OpenCameraButton.UseVisualStyleBackColor = true;
            this.OpenCameraButton.Click += new System.EventHandler(this.OpenCameraButton_Click);
            // 
            // QRCodeResultsBox
            // 
            this.QRCodeResultsBox.Location = new System.Drawing.Point(925, 668);
            this.QRCodeResultsBox.Name = "QRCodeResultsBox";
            this.QRCodeResultsBox.Size = new System.Drawing.Size(511, 331);
            this.QRCodeResultsBox.TabIndex = 46;
            this.QRCodeResultsBox.Text = "";
            this.QRCodeResultsBox.TextChanged += new System.EventHandler(this.QRCodeResultsBox_TextChanged);
            // 
            // CameraBox
            // 
            this.CameraBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CameraBox.Location = new System.Drawing.Point(34, 621);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(459, 389);
            this.CameraBox.TabIndex = 47;
            this.CameraBox.TabStop = false;
            this.CameraBox.Click += new System.EventHandler(this.CameraBox_Click);
            // 
            // Cameralabel
            // 
            this.Cameralabel.AutoSize = true;
            this.Cameralabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cameralabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.Cameralabel.Location = new System.Drawing.Point(367, 571);
            this.Cameralabel.Name = "Cameralabel";
            this.Cameralabel.Size = new System.Drawing.Size(96, 23);
            this.Cameralabel.TabIndex = 48;
            this.Cameralabel.Text = "Camera:";
            // 
            // CamComboBox
            // 
            this.CamComboBox.FormattingEnabled = true;
            this.CamComboBox.Location = new System.Drawing.Point(469, 571);
            this.CamComboBox.Name = "CamComboBox";
            this.CamComboBox.Size = new System.Drawing.Size(177, 28);
            this.CamComboBox.TabIndex = 49;
            // 
            // QRCodeResultsLabel
            // 
            this.QRCodeResultsLabel.AutoSize = true;
            this.QRCodeResultsLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QRCodeResultsLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.QRCodeResultsLabel.Location = new System.Drawing.Point(925, 632);
            this.QRCodeResultsLabel.Name = "QRCodeResultsLabel";
            this.QRCodeResultsLabel.Size = new System.Drawing.Size(217, 23);
            this.QRCodeResultsLabel.TabIndex = 50;
            this.QRCodeResultsLabel.Text = "QR Code Information";
            this.QRCodeResultsLabel.Click += new System.EventHandler(this.label1_Click_7);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CodeButton
            // 
            this.CodeButton.Location = new System.Drawing.Point(781, 567);
            this.CodeButton.Name = "CodeButton";
            this.CodeButton.Size = new System.Drawing.Size(128, 35);
            this.CodeButton.TabIndex = 51;
            this.CodeButton.Text = "Generate Code";
            this.CodeButton.UseVisualStyleBackColor = true;
            this.CodeButton.Click += new System.EventHandler(this.CodeButton_Click);
            // 
            // QRCODEPictureBox
            // 
            this.QRCODEPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QRCODEPictureBox.Location = new System.Drawing.Point(517, 621);
            this.QRCODEPictureBox.Name = "QRCODEPictureBox";
            this.QRCODEPictureBox.Size = new System.Drawing.Size(376, 389);
            this.QRCODEPictureBox.TabIndex = 52;
            this.QRCODEPictureBox.TabStop = false;
            // 
            // ContactTracingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1460, 1022);
            this.Controls.Add(this.QRCODEPictureBox);
            this.Controls.Add(this.CodeButton);
            this.Controls.Add(this.QRCodeResultsLabel);
            this.Controls.Add(this.CamComboBox);
            this.Controls.Add(this.Cameralabel);
            this.Controls.Add(this.CameraBox);
            this.Controls.Add(this.QRCodeResultsBox);
            this.Controls.Add(this.OpenCameraButton);
            this.Controls.Add(this.QRCodelabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Resultsbox);
            this.Controls.Add(this.Searchboxlabel);
            this.Controls.Add(this.Searchtextbox);
            this.Controls.Add(this.Informationsubmittedlabel);
            this.Controls.Add(this.DataListbox);
            this.Controls.Add(this.TimeFormatExample);
            this.Controls.Add(this.TimeFormat);
            this.Controls.Add(this.DateFormatExample);
            this.Controls.Add(this.DateFormatLabel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.EmergencyNumberTextbox);
            this.Controls.Add(this.EmergencyNumberLabel);
            this.Controls.Add(this.EmergencyAddressTextbox);
            this.Controls.Add(this.EmergencyAddressLabel);
            this.Controls.Add(this.EmergencyNameTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmergencyNameLabel);
            this.Controls.Add(this.EmergencyContactInfoLabel);
            this.Controls.Add(this.VisitorInfoLabel);
            this.Controls.Add(this.ContactNumberTextbox);
            this.Controls.Add(this.ContactNumberLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.TimeoutTextbox);
            this.Controls.Add(this.TimeoutLabel);
            this.Controls.Add(this.TimeInTextbox);
            this.Controls.Add(this.TimeinLabel);
            this.Controls.Add(this.DateTextbox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.Nametextbox);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.FormInstruction);
            this.Controls.Add(this.ConsentCheckbox);
            this.Controls.Add(this.FormTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactTracingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Contact Tracing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.ContactTracingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRCODEPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FormTitle;
        private CheckBox ConsentCheckbox;
        private Label FormInstruction;
        private BindingSource bindingSource1;
        private Label Namelabel;
        private Label SexLabel;
        private TextBox Nametextbox;
        private Label DateLabel;
        private TextBox DateTextbox;
        private Label TimeinLabel;
        private TextBox TimeInTextbox;
        private Label TimeoutLabel;
        private TextBox TimeoutTextbox;
        private Label AddressLabel;
        private TextBox AddressTextBox;
        private Label ContactNumberLabel;
        private TextBox ContactNumberTextbox;
        private Label VisitorInfoLabel;
        private Label EmergencyContactInfoLabel;
        private TextBox EmergencyNumberTextbox;
        private Label EmergencyNumberLabel;
        private TextBox EmergencyAddressTextbox;
        private Label EmergencyAddressLabel;
        private TextBox EmergencyNameTextbox;
        private Label label6;
        private Label EmergencyNameLabel;
        private Button DoneButton;
        private Label DateFormatLabel;
        private Label DateFormatExample;
        private Label TimeFormat;
        private Label TimeFormatExample;
        private ListBox DataListbox;
        private Label Informationsubmittedlabel;
        private TextBox Searchtextbox;
        private Label Searchboxlabel;
        private RichTextBox Resultsbox;
        private Button SearchButton;
        private Label QRCodelabel;
        private Button OpenCameraButton;
        private RichTextBox QRCodeResultsBox;
        private PictureBox CameraBox;
        private Label Cameralabel;
        private ComboBox CamComboBox;
        private Label QRCodeResultsLabel;
        private System.Windows.Forms.Timer timer1;
        private Button CodeButton;
        private PictureBox QRCODEPictureBox;
    }
}