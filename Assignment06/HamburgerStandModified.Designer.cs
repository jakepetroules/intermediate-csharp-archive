namespace IntermediateCSharp.Assignment06
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class HamburgerStandModified
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem foodChoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hamburgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem friesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinkToolStripMenuItem;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalAmount;

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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.foodChoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hamburgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.friesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelList = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.panelItems = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.panelItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foodChoiceToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(294, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // foodChoiceToolStripMenuItem
            // 
            this.foodChoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hamburgerToolStripMenuItem,
            this.friesToolStripMenuItem,
            this.drinkToolStripMenuItem});
            this.foodChoiceToolStripMenuItem.Name = "foodChoiceToolStripMenuItem";
            this.foodChoiceToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.foodChoiceToolStripMenuItem.Text = "&Food Choice";
            // 
            // hamburgerToolStripMenuItem
            // 
            this.hamburgerToolStripMenuItem.Name = "hamburgerToolStripMenuItem";
            this.hamburgerToolStripMenuItem.ShortcutKeyDisplayString = "$2.00";
            this.hamburgerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.hamburgerToolStripMenuItem.Text = "Hamburger";
            this.hamburgerToolStripMenuItem.Click += new System.EventHandler(this.FoodToolStripMenuItem_Click);
            // 
            // friesToolStripMenuItem
            // 
            this.friesToolStripMenuItem.Name = "friesToolStripMenuItem";
            this.friesToolStripMenuItem.ShortcutKeyDisplayString = "$1.50";
            this.friesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.friesToolStripMenuItem.Text = "Fries";
            this.friesToolStripMenuItem.Click += new System.EventHandler(this.FoodToolStripMenuItem_Click);
            // 
            // drinkToolStripMenuItem
            // 
            this.drinkToolStripMenuItem.Name = "drinkToolStripMenuItem";
            this.drinkToolStripMenuItem.ShortcutKeyDisplayString = "$1.00";
            this.drinkToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.drinkToolStripMenuItem.Text = "Drink";
            this.drinkToolStripMenuItem.Click += new System.EventHandler(this.FoodToolStripMenuItem_Click);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(12, 28);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(26, 13);
            this.labelList.TabIndex = 1;
            this.labelList.Text = "List:";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Location = new System.Drawing.Point(0, 0);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(0, 13);
            this.labelItems.TabIndex = 0;
            // 
            // panelItems
            // 
            this.panelItems.AutoScroll = true;
            this.panelItems.Controls.Add(this.labelItems);
            this.panelItems.Location = new System.Drawing.Point(15, 44);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(267, 195);
            this.panelItems.TabIndex = 2;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(12, 246);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total:";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(52, 246);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(0, 13);
            this.labelTotalAmount.TabIndex = 4;
            // 
            // HamburgerStandModified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 268);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.panelItems);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "HamburgerStandModified";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hamburger Stand Modified";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelItems.ResumeLayout(false);
            this.panelItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

