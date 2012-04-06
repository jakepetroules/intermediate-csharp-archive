namespace IntermediateCSharp.Lesson02
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class HelloWorldModified
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonGreetings;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelGreeting;

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
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGreetings
            // 
            this.buttonGreetings.Location = new System.Drawing.Point(69, 111);
            this.buttonGreetings.Name = "buttonGreetings";
            this.buttonGreetings.Size = new System.Drawing.Size(75, 23);
            this.buttonGreetings.TabIndex = 0;
            this.buttonGreetings.Text = "Greetings";
            this.buttonGreetings.UseVisualStyleBackColor = true;
            this.buttonGreetings.Click += new System.EventHandler(this.ButtonGreetings_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(150, 111);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // labelGreeting
            // 
            this.labelGreeting.Location = new System.Drawing.Point(12, 145);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(270, 13);
            this.labelGreeting.TabIndex = 2;
            this.labelGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 268);
            this.Controls.Add(this.labelGreeting);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGreetings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My First Program";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

