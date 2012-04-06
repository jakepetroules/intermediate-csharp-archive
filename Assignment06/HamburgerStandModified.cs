namespace IntermediateCSharp.Assignment06
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// The HamburgerStandModified GUI class.
    /// </summary>
    public partial class HamburgerStandModified : Form
    {
        /// <summary>
        /// The total cost of the items chosen.
        /// </summary>
        private decimal totalCost = 0M;

        /// <summary>
        /// Initializes a new instance of the HamburgerStandModified class.
        /// </summary>
        public HamburgerStandModified()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Adds a hamburger, drink or fries to the chosen items, depending on the menu clicked.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void FoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            if (menu != null)
            {
                this.labelItems.Text += "\n" + menu.Text;
                this.totalCost += Convert.ToDecimal(menu.ShortcutKeyDisplayString.Remove(0, 1), CultureInfo.InvariantCulture);
                this.labelTotalAmount.Text = String.Format(CultureInfo.CurrentCulture, "{0:C}", this.totalCost);
            }
        }
    }
}
