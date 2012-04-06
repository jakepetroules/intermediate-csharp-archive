namespace IntermediateCSharp.Assignment02
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class MailingAddress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelCityStateZIP;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelCityStateZIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(24, 94);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(120, 23);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Show mailing address";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(150, 94);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(120, 23);
            this.buttonHide.TabIndex = 1;
            this.buttonHide.Text = "Hide mailing address";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.ButtonHide_Click);
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(12, 136);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(270, 13);
            this.labelName.TabIndex = 2;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStreet
            // 
            this.labelStreet.Location = new System.Drawing.Point(12, 149);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(270, 13);
            this.labelStreet.TabIndex = 3;
            this.labelStreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCityStateZIP
            // 
            this.labelCityStateZIP.Location = new System.Drawing.Point(12, 162);
            this.labelCityStateZIP.Name = "labelCityStateZIP";
            this.labelCityStateZIP.Size = new System.Drawing.Size(270, 13);
            this.labelCityStateZIP.TabIndex = 4;
            this.labelCityStateZIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MailingAddressGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 268);
            this.Controls.Add(this.labelCityStateZIP);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MailingAddressGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mailing Address";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

