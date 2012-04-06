namespace IntermediateCSharp.Lesson05
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class ListDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.TextBox textBoxRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListBox listBoxGrocery;
        private System.Windows.Forms.Label labelSelectedIndex;

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
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.textBoxRemove = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBoxGrocery = new System.Windows.Forms.ListBox();
            this.labelSelectedIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(54, 14);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdd.TabIndex = 0;
            // 
            // textBoxRemove
            // 
            this.textBoxRemove.Location = new System.Drawing.Point(54, 43);
            this.textBoxRemove.Name = "textBoxRemove";
            this.textBoxRemove.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemove.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(160, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Load Item";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(160, 41);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(80, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove Item";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // listBoxGrocery
            // 
            this.listBoxGrocery.FormattingEnabled = true;
            this.listBoxGrocery.Location = new System.Drawing.Point(54, 70);
            this.listBoxGrocery.Name = "listBoxGrocery";
            this.listBoxGrocery.Size = new System.Drawing.Size(186, 121);
            this.listBoxGrocery.Sorted = true;
            this.listBoxGrocery.TabIndex = 4;
            this.listBoxGrocery.SelectedIndexChanged += new System.EventHandler(this.ListBoxGrocery_SelectedIndexChanged);
            // 
            // labelSelectedIndex
            // 
            this.labelSelectedIndex.AutoSize = true;
            this.labelSelectedIndex.Location = new System.Drawing.Point(51, 194);
            this.labelSelectedIndex.Name = "labelSelectedIndex";
            this.labelSelectedIndex.Size = new System.Drawing.Size(90, 13);
            this.labelSelectedIndex.TabIndex = 5;
            this.labelSelectedIndex.Text = "<Selected Index>";
            // 
            // ListDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 228);
            this.Controls.Add(this.labelSelectedIndex);
            this.Controls.Add(this.listBoxGrocery);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxRemove);
            this.Controls.Add(this.textBoxAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

