namespace IntermediateCSharp.Assignment01
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class Hello
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClickMe;

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
            this.buttonClickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClickMe
            // 
            this.buttonClickMe.Location = new System.Drawing.Point(110, 123);
            this.buttonClickMe.Name = "buttonClickMe";
            this.buttonClickMe.Size = new System.Drawing.Size(75, 23);
            this.buttonClickMe.TabIndex = 0;
            this.buttonClickMe.Text = "Click me!";
            this.buttonClickMe.UseVisualStyleBackColor = true;
            this.buttonClickMe.Click += new System.EventHandler(this.ButtonClickMe_Click);
            // 
            // HelloGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 268);
            this.Controls.Add(this.buttonClickMe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HelloGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

