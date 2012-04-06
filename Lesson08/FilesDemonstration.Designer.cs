namespace IntermediateCSharp.Lesson08
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class FilesDemonstration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonOpenFile;

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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(79, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(203, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(24, 38);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(120, 23);
            this.buttonWrite.TabIndex = 2;
            this.buttonWrite.Text = "Write name to file";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.ButtonWrite_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Your name:";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(150, 38);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(120, 23);
            this.buttonOpenFile.TabIndex = 3;
            this.buttonOpenFile.Text = "Read name from file";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // FilesDemonstration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 68);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FilesDemonstration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Files Demonstration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FilesDemonstration_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}