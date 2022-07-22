namespace Contact_Tracing_App
{
    partial class Form2
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
            this.CamLabel = new System.Windows.Forms.Label();
            this.CamComboBox = new System.Windows.Forms.ComboBox();
            this.CameraBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CamLabel
            // 
            this.CamLabel.AutoSize = true;
            this.CamLabel.Location = new System.Drawing.Point(212, 32);
            this.CamLabel.Name = "CamLabel";
            this.CamLabel.Size = new System.Drawing.Size(63, 20);
            this.CamLabel.TabIndex = 0;
            this.CamLabel.Text = "Camera:";
            this.CamLabel.Click += new System.EventHandler(this.CamLabel_Click);
            // 
            // CamComboBox
            // 
            this.CamComboBox.FormattingEnabled = true;
            this.CamComboBox.Location = new System.Drawing.Point(295, 29);
            this.CamComboBox.Name = "CamComboBox";
            this.CamComboBox.Size = new System.Drawing.Size(151, 28);
            this.CamComboBox.TabIndex = 1;
            this.CamComboBox.SelectedIndexChanged += new System.EventHandler(this.CamComboBox_SelectedIndexChanged);
            // 
            // CameraBox
            // 
            this.CameraBox.Location = new System.Drawing.Point(39, 85);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(575, 408);
            this.CameraBox.TabIndex = 2;
            this.CameraBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(667, 522);
            this.Controls.Add(this.CameraBox);
            this.Controls.Add(this.CamComboBox);
            this.Controls.Add(this.CamLabel);
            this.Name = "Form2";
            this.Text = "Scan QR Code";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CamLabel;
        private ComboBox CamComboBox;
        private PictureBox CameraBox;
        private System.Windows.Forms.Timer timer1;
    }
}