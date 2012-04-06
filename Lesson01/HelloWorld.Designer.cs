namespace IntermediateCSharp.Lesson01
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class HelloWorld
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonGreetings;

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
            this.buttonGreetings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGreetings
            // 
            this.buttonGreetings.Location = new System.Drawing.Point(110, 123);
            this.buttonGreetings.Name = "buttonGreetings";
            this.buttonGreetings.Size = new System.Drawing.Size(75, 23);
            this.buttonGreetings.TabIndex = 0;
            this.buttonGreetings.Text = "Click me!";
            this.buttonGreetings.UseVisualStyleBackColor = true;
            this.buttonGreetings.Click += new System.EventHandler(this.ButtonGreetings_Click);
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 268);
            this.Controls.Add(this.buttonGreetings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

