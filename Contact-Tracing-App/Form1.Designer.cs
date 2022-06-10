﻿namespace Contact_Tracing_App
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SaveButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.ConsentCheckbox.Location = new System.Drawing.Point(44, 154);
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
            this.Namelabel.Location = new System.Drawing.Point(23, 267);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(76, 23);
            this.Namelabel.TabIndex = 3;
            this.Namelabel.Text = "Name:";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SexLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.SexLabel.Location = new System.Drawing.Point(255, 297);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(0, 37);
            this.SexLabel.TabIndex = 5;
            this.SexLabel.Click += new System.EventHandler(this.SexLabel_Click);
            // 
            // Nametextbox
            // 
            this.Nametextbox.Location = new System.Drawing.Point(105, 267);
            this.Nametextbox.Name = "Nametextbox";
            this.Nametextbox.Size = new System.Drawing.Size(307, 27);
            this.Nametextbox.TabIndex = 6;
            this.Nametextbox.TextChanged += new System.EventHandler(this.Nametextbox_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(799, 598);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.DateLabel.Location = new System.Drawing.Point(431, 267);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(62, 23);
            this.DateLabel.TabIndex = 8;
            this.DateLabel.Text = "Date:";
            // 
            // DateTextbox
            // 
            this.DateTextbox.Location = new System.Drawing.Point(499, 267);
            this.DateTextbox.Name = "DateTextbox";
            this.DateTextbox.Size = new System.Drawing.Size(125, 27);
            this.DateTextbox.TabIndex = 9;
            // 
            // TimeinLabel
            // 
            this.TimeinLabel.AutoSize = true;
            this.TimeinLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeinLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.TimeinLabel.Location = new System.Drawing.Point(644, 267);
            this.TimeinLabel.Name = "TimeinLabel";
            this.TimeinLabel.Size = new System.Drawing.Size(84, 23);
            this.TimeinLabel.TabIndex = 10;
            this.TimeinLabel.Text = "Time in:";
            this.TimeinLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // TimeInTextbox
            // 
            this.TimeInTextbox.Location = new System.Drawing.Point(734, 267);
            this.TimeInTextbox.Name = "TimeInTextbox";
            this.TimeInTextbox.Size = new System.Drawing.Size(141, 27);
            this.TimeInTextbox.TabIndex = 11;
            this.TimeInTextbox.TextChanged += new System.EventHandler(this.TimeInTextbox_TextChanged);
            // 
            // TimeoutLabel
            // 
            this.TimeoutLabel.AutoSize = true;
            this.TimeoutLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeoutLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.TimeoutLabel.Location = new System.Drawing.Point(630, 309);
            this.TimeoutLabel.Name = "TimeoutLabel";
            this.TimeoutLabel.Size = new System.Drawing.Size(98, 23);
            this.TimeoutLabel.TabIndex = 12;
            this.TimeoutLabel.Text = "Time out:";
            // 
            // TimeoutTextbox
            // 
            this.TimeoutTextbox.Location = new System.Drawing.Point(734, 309);
            this.TimeoutTextbox.Name = "TimeoutTextbox";
            this.TimeoutTextbox.Size = new System.Drawing.Size(141, 27);
            this.TimeoutTextbox.TabIndex = 13;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.AddressLabel.Location = new System.Drawing.Point(23, 309);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(94, 23);
            this.AddressLabel.TabIndex = 14;
            this.AddressLabel.Text = "Address:";
            this.AddressLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(123, 309);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(501, 27);
            this.AddressTextBox.TabIndex = 15;
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactNumberLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.ContactNumberLabel.Location = new System.Drawing.Point(23, 353);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(179, 23);
            this.ContactNumberLabel.TabIndex = 16;
            this.ContactNumberLabel.Text = "Contact Number:";
            this.ContactNumberLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // ContactNumberTextbox
            // 
            this.ContactNumberTextbox.Location = new System.Drawing.Point(208, 353);
            this.ContactNumberTextbox.Name = "ContactNumberTextbox";
            this.ContactNumberTextbox.Size = new System.Drawing.Size(238, 27);
            this.ContactNumberTextbox.TabIndex = 17;
            // 
            // VisitorInfoLabel
            // 
            this.VisitorInfoLabel.AutoSize = true;
            this.VisitorInfoLabel.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.VisitorInfoLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.VisitorInfoLabel.Location = new System.Drawing.Point(23, 221);
            this.VisitorInfoLabel.Name = "VisitorInfoLabel";
            this.VisitorInfoLabel.Size = new System.Drawing.Size(344, 40);
            this.VisitorInfoLabel.TabIndex = 18;
            this.VisitorInfoLabel.Text = "Visitor\'s Information:";
            // 
            // EmergencyContactInfoLabel
            // 
            this.EmergencyContactInfoLabel.AutoSize = true;
            this.EmergencyContactInfoLabel.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmergencyContactInfoLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.EmergencyContactInfoLabel.Location = new System.Drawing.Point(23, 420);
            this.EmergencyContactInfoLabel.Name = "EmergencyContactInfoLabel";
            this.EmergencyContactInfoLabel.Size = new System.Drawing.Size(556, 40);
            this.EmergencyContactInfoLabel.TabIndex = 19;
            this.EmergencyContactInfoLabel.Text = "Emergency Contact Information:";
            this.EmergencyContactInfoLabel.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // EmergencyNumberTextbox
            // 
            this.EmergencyNumberTextbox.Location = new System.Drawing.Point(637, 475);
            this.EmergencyNumberTextbox.Name = "EmergencyNumberTextbox";
            this.EmergencyNumberTextbox.Size = new System.Drawing.Size(238, 27);
            this.EmergencyNumberTextbox.TabIndex = 32;
            // 
            // EmergencyNumberLabel
            // 
            this.EmergencyNumberLabel.AutoSize = true;
            this.EmergencyNumberLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmergencyNumberLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.EmergencyNumberLabel.Location = new System.Drawing.Point(452, 475);
            this.EmergencyNumberLabel.Name = "EmergencyNumberLabel";
            this.EmergencyNumberLabel.Size = new System.Drawing.Size(179, 23);
            this.EmergencyNumberLabel.TabIndex = 31;
            this.EmergencyNumberLabel.Text = "Contact Number:";
            // 
            // EmergencyAddressTextbox
            // 
            this.EmergencyAddressTextbox.Location = new System.Drawing.Point(134, 521);
            this.EmergencyAddressTextbox.Name = "EmergencyAddressTextbox";
            this.EmergencyAddressTextbox.Size = new System.Drawing.Size(501, 27);
            this.EmergencyAddressTextbox.TabIndex = 30;
            // 
            // EmergencyAddressLabel
            // 
            this.EmergencyAddressLabel.AutoSize = true;
            this.EmergencyAddressLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmergencyAddressLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.EmergencyAddressLabel.Location = new System.Drawing.Point(34, 521);
            this.EmergencyAddressLabel.Name = "EmergencyAddressLabel";
            this.EmergencyAddressLabel.Size = new System.Drawing.Size(94, 23);
            this.EmergencyAddressLabel.TabIndex = 29;
            this.EmergencyAddressLabel.Text = "Address:";
            // 
            // EmergencyNameTextbox
            // 
            this.EmergencyNameTextbox.Location = new System.Drawing.Point(116, 479);
            this.EmergencyNameTextbox.Name = "EmergencyNameTextbox";
            this.EmergencyNameTextbox.Size = new System.Drawing.Size(307, 27);
            this.EmergencyNameTextbox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SkyBlue;
            this.label6.Location = new System.Drawing.Point(266, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 37);
            this.label6.TabIndex = 21;
            // 
            // EmergencyNameLabel
            // 
            this.EmergencyNameLabel.AutoSize = true;
            this.EmergencyNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmergencyNameLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.EmergencyNameLabel.Location = new System.Drawing.Point(34, 479);
            this.EmergencyNameLabel.Name = "EmergencyNameLabel";
            this.EmergencyNameLabel.Size = new System.Drawing.Size(76, 23);
            this.EmergencyNameLabel.TabIndex = 20;
            this.EmergencyNameLabel.Text = "Name:";
            // 
            // ContactTracingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(913, 653);
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
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Nametextbox);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.FormInstruction);
            this.Controls.Add(this.ConsentCheckbox);
            this.Controls.Add(this.FormTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactTracingForm";
            this.Text = " Contact Tracing";
            this.Load += new System.EventHandler(this.ContactTracingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private SaveFileDialog saveFileDialog1;
        private Button SaveButton;
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
    }
}