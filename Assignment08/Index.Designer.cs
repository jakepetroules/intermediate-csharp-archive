namespace IntermediateCSharp.Assignment08
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Button buttonGetValue;
        private System.Windows.Forms.Label labelResult;

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
            this.labelIndex = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.buttonGetValue = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(36, 17);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(36, 13);
            this.labelIndex.TabIndex = 0;
            this.labelIndex.Text = "Index:";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(78, 14);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxIndex.TabIndex = 1;
            // 
            // buttonGetValue
            // 
            this.buttonGetValue.Location = new System.Drawing.Point(184, 12);
            this.buttonGetValue.Name = "buttonGetValue";
            this.buttonGetValue.Size = new System.Drawing.Size(75, 23);
            this.buttonGetValue.TabIndex = 2;
            this.buttonGetValue.Text = "Get Value";
            this.buttonGetValue.UseVisualStyleBackColor = true;
            this.buttonGetValue.Click += new System.EventHandler(this.ButtonGetValue_Click);
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(12, 46);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(270, 26);
            this.labelResult.TabIndex = 3;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 88);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonGetValue);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.labelIndex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

