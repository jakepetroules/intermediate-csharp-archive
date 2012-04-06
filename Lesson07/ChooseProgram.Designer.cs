namespace IntermediateCSharp.Lesson07
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class ChooseProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ComboBox comboBoxProgram;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonExit;

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
            this.labelDescription = new System.Windows.Forms.Label();
            this.comboBoxProgram = new System.Windows.Forms.ComboBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(12, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(270, 52);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "This program contains several programs demonstrating classes. Please choose the p" +
                "rogram you would like to run, and click the \'Run\' button. To exit this program i" +
                "nstead, click \'Exit\'.";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxProgram
            // 
            this.comboBoxProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProgram.FormattingEnabled = true;
            this.comboBoxProgram.Location = new System.Drawing.Point(57, 72);
            this.comboBoxProgram.Name = "comboBoxProgram";
            this.comboBoxProgram.Size = new System.Drawing.Size(180, 21);
            this.comboBoxProgram.TabIndex = 1;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(69, 99);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(150, 99);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ChooseProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 138);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.comboBoxProgram);
            this.Controls.Add(this.labelDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChooseProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Program";
            this.ResumeLayout(false);

        }

        #endregion
    }
}