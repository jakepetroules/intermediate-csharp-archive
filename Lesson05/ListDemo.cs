namespace IntermediateCSharp.Lesson05
{
    using System.Windows.Forms;

    /// <summary>
    /// The ListDemo GUI class.
    /// </summary>
    public partial class ListDemo : Form
    {
        /// <summary>
        /// Initializes a new instance of the ListDemo class.
        /// </summary>
        public ListDemo()
        {
            this.InitializeComponent();
            this.UpdateLabel();
        }

        /// <summary>
        /// Puts the name of the currently selected item in the remove item text box.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ListBoxGrocery_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.textBoxRemove.Text = (string)this.listBoxGrocery.SelectedItem;
            this.UpdateLabel();
        }

        /// <summary>
        /// Loads an item into the text box.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonAdd_Click(object sender, System.EventArgs e)
        {
            this.listBoxGrocery.Items.Add(this.textBoxAdd.Text);
        }

        /// <summary>
        /// Removes an item from the text box.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonRemove_Click(object sender, System.EventArgs e)
        {
            this.listBoxGrocery.Items.Remove(this.textBoxRemove.Text);
        }

        /// <summary>
        /// Shows the currently selected index of the listbox on the output label.
        /// </summary>
        private void UpdateLabel()
        {
            this.labelSelectedIndex.Text = "Selected index: " + this.listBoxGrocery.SelectedIndex;
            if (this.listBoxGrocery.SelectedIndex < 0)
            {
                this.labelSelectedIndex.Text += " (None)";
            }
        }
    }
}
