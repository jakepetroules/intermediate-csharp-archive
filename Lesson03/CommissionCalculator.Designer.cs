namespace IntermediateCSharp.Lesson03
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class CommissionCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSales;

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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSales = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(79, 84);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "&Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(160, 84);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "C&lear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(241, 84);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(125, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Location = new System.Drawing.Point(127, 45);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(36, 13);
            this.labelSales.TabIndex = 2;
            this.labelSales.Text = "Sales:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(169, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Click += new System.EventHandler(this.TextBox_TextBoxEnteredOrSelected);
            this.textBoxName.Enter += new System.EventHandler(this.TextBox_TextBoxEnteredOrSelected);
            // 
            // textBoxSales
            // 
            this.textBoxSales.Location = new System.Drawing.Point(169, 42);
            this.textBoxSales.Name = "textBoxSales";
            this.textBoxSales.Size = new System.Drawing.Size(100, 20);
            this.textBoxSales.TabIndex = 3;
            this.textBoxSales.Click += new System.EventHandler(this.TextBox_TextBoxEnteredOrSelected);
            this.textBoxSales.Enter += new System.EventHandler(this.TextBox_TextBoxEnteredOrSelected);
            // 
            // CommissionCalculatorGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 118);
            this.Controls.Add(this.textBoxSales);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSales);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CommissionCalculatorGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commission Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

