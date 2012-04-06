namespace IntermediateCSharp.Assignment05
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The Favorites GUI class.
    /// </summary>
    public partial class Favorites : Form
    {
        /// <summary>
        /// The program creator's favorite items.
        /// </summary>
        private string[] favoriteItems;

        /// <summary>
        /// Initializes a new instance of the Favorites class.
        /// </summary>
        public Favorites()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Loads the program creator's favorite items into the list box.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void FavoritesGui_Load(object sender, EventArgs e)
        {
            this.favoriteItems = new string[] { "red", "C#", "pretty girls", "Digital Fortress", "sushi", "computers", "physics", "rice" };

            for (int i = 0; i < this.favoriteItems.Length; i++)
            {
                this.listBoxFavorites.Items.Add(this.favoriteItems[i]);
            }
        }

        /// <summary>
        /// Tells the user that the program creator also likes the item they clicked on.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ListBoxFavorites_Click(object sender, EventArgs e)
        {
            if (this.listBoxFavorites.SelectedItem != null)
            {
                MessageBox.Show("I like " + this.listBoxFavorites.SelectedItem + " too!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
            }
        }
    }
}
