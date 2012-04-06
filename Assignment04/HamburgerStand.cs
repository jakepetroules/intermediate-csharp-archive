namespace IntermediateCSharp.Assignment04
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// The HamburgerStand GUI class.
    /// </summary>
    public partial class HamburgerStand : Form
    {
        /// <summary>
        /// Initializes a new instance of the HamburgerStand class.
        /// </summary>
        public HamburgerStand()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Occurs when the calculate button is clicked.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            this.labelCost.Text = string.Empty;
            decimal cost = 0M;

            if (!this.radioButtonDessertNone.Checked && !this.radioButtonDessertCake.Checked && !this.radioButtonDessertIceCream.Checked)
            {
                MessageBox.Show("Please make your choice of dessert!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                return;
            }

            if (this.checkBoxHamburger.Checked)
            {
                cost += 2M;
            }

            if (this.checkBoxFries.Checked)
            {
                cost += 1.5M;
            }

            if (this.checkBoxDrink.Checked)
            {
                cost += 1M;
            }

            this.labelCost.Text = String.Format(CultureInfo.CurrentCulture, "The cost of your order is {0:C}", cost);
        }
    }
}
