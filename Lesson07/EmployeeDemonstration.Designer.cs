namespace IntermediateCSharp.Lesson07
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class EmployeeDemonstration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonGetEmployeeInfo;
        private System.Windows.Forms.Label labelEmployeeInfo;
        private System.Windows.Forms.Label labelOfficerInfo;
        private System.Windows.Forms.Button buttonGetOfficerInfo;
        private System.Windows.Forms.Label labelOfficerInfoPoly;
        private System.Windows.Forms.Button buttonGetOfficerInfoPoly;

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
            this.buttonGetEmployeeInfo = new System.Windows.Forms.Button();
            this.labelEmployeeInfo = new System.Windows.Forms.Label();
            this.labelOfficerInfo = new System.Windows.Forms.Label();
            this.buttonGetOfficerInfo = new System.Windows.Forms.Button();
            this.labelOfficerInfoPoly = new System.Windows.Forms.Label();
            this.buttonGetOfficerInfoPoly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGetEmployeeInfo
            // 
            this.buttonGetEmployeeInfo.Location = new System.Drawing.Point(87, 40);
            this.buttonGetEmployeeInfo.Name = "buttonGetEmployeeInfo";
            this.buttonGetEmployeeInfo.Size = new System.Drawing.Size(120, 23);
            this.buttonGetEmployeeInfo.TabIndex = 0;
            this.buttonGetEmployeeInfo.Text = "Get Employee Info";
            this.buttonGetEmployeeInfo.UseVisualStyleBackColor = true;
            this.buttonGetEmployeeInfo.Click += new System.EventHandler(this.ButtonGetEmployeeInfo_Click);
            // 
            // labelEmployeeInfo
            // 
            this.labelEmployeeInfo.Location = new System.Drawing.Point(12, 74);
            this.labelEmployeeInfo.Name = "labelEmployeeInfo";
            this.labelEmployeeInfo.Size = new System.Drawing.Size(270, 13);
            this.labelEmployeeInfo.TabIndex = 1;
            this.labelEmployeeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOfficerInfo
            // 
            this.labelOfficerInfo.Location = new System.Drawing.Point(12, 132);
            this.labelOfficerInfo.Name = "labelOfficerInfo";
            this.labelOfficerInfo.Size = new System.Drawing.Size(270, 26);
            this.labelOfficerInfo.TabIndex = 3;
            this.labelOfficerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGetOfficerInfo
            // 
            this.buttonGetOfficerInfo.Location = new System.Drawing.Point(87, 98);
            this.buttonGetOfficerInfo.Name = "buttonGetOfficerInfo";
            this.buttonGetOfficerInfo.Size = new System.Drawing.Size(120, 23);
            this.buttonGetOfficerInfo.TabIndex = 2;
            this.buttonGetOfficerInfo.Text = "Get Officer Info";
            this.buttonGetOfficerInfo.UseVisualStyleBackColor = true;
            this.buttonGetOfficerInfo.Click += new System.EventHandler(this.ButtonGetOfficerInfo_Click);
            // 
            // labelOfficerInfoPoly
            // 
            this.labelOfficerInfoPoly.Location = new System.Drawing.Point(12, 203);
            this.labelOfficerInfoPoly.Name = "labelOfficerInfoPoly";
            this.labelOfficerInfoPoly.Size = new System.Drawing.Size(270, 26);
            this.labelOfficerInfoPoly.TabIndex = 5;
            this.labelOfficerInfoPoly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGetOfficerInfoPoly
            // 
            this.buttonGetOfficerInfoPoly.Location = new System.Drawing.Point(62, 169);
            this.buttonGetOfficerInfoPoly.Name = "buttonGetOfficerInfoPoly";
            this.buttonGetOfficerInfoPoly.Size = new System.Drawing.Size(170, 23);
            this.buttonGetOfficerInfoPoly.TabIndex = 4;
            this.buttonGetOfficerInfoPoly.Text = "Get Officer Info (Polymorphic)";
            this.buttonGetOfficerInfoPoly.UseVisualStyleBackColor = true;
            this.buttonGetOfficerInfoPoly.Click += new System.EventHandler(this.ButtonGetOfficerInfoPoly_Click);
            // 
            // EmployeeGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 268);
            this.Controls.Add(this.labelOfficerInfoPoly);
            this.Controls.Add(this.buttonGetOfficerInfoPoly);
            this.Controls.Add(this.labelOfficerInfo);
            this.Controls.Add(this.buttonGetOfficerInfo);
            this.Controls.Add(this.labelEmployeeInfo);
            this.Controls.Add(this.buttonGetEmployeeInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Class Demonstration";
            this.ResumeLayout(false);

        }

        #endregion
    }
}