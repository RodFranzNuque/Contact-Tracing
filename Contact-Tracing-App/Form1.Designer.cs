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
            this.Title = new System.Windows.Forms.Label();
            this.ConsentCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.SkyBlue;
            this.Title.Location = new System.Drawing.Point(40, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(870, 91);
            this.Title.TabIndex = 0;
            this.Title.Text = "Covid Contact Tracing";
            this.Title.Click += new System.EventHandler(this.label1_Click);
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
            this.ConsentCheckbox.Location = new System.Drawing.Point(40, 155);
            this.ConsentCheckbox.Name = "ConsentCheckbox";
            this.ConsentCheckbox.Size = new System.Drawing.Size(840, 37);
            this.ConsentCheckbox.TabIndex = 1;
            this.ConsentCheckbox.Text = resources.GetString("ConsentCheckbox.Text");
            this.ConsentCheckbox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ConsentCheckbox.UseVisualStyleBackColor = false;
            this.ConsentCheckbox.CheckedChanged += new System.EventHandler(this.ConsentCheckbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(40, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please accomplish this form with accurate \r\ninformation before entering the estab" +
    "lishment.";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ContactTracingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(965, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsentCheckbox);
            this.Controls.Add(this.Title);
            this.Name = "ContactTracingForm";
            this.Text = "Contact Tracing";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private CheckBox ConsentCheckbox;
        private Label label1;
        private BindingSource bindingSource1;
    }
}