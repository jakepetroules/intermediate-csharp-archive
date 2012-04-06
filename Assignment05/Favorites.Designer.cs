namespace IntermediateCSharp.Assignment05
{
    /// <summary>
    /// GUI initialization.
    /// </summary>
    public partial class Favorites
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox listBoxFavorites;

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
            this.listBoxFavorites = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxFavorites
            // 
            this.listBoxFavorites.FormattingEnabled = true;
            this.listBoxFavorites.Location = new System.Drawing.Point(12, 12);
            this.listBoxFavorites.Name = "listBoxFavorites";
            this.listBoxFavorites.Size = new System.Drawing.Size(270, 238);
            this.listBoxFavorites.Sorted = true;
            this.listBoxFavorites.TabIndex = 0;
            this.listBoxFavorites.Click += new System.EventHandler(this.ListBoxFavorites_Click);
            // 
            // FavoritesGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 268);
            this.Controls.Add(this.listBoxFavorites);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FavoritesGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Favorites";
            this.Load += new System.EventHandler(this.FavoritesGui_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

