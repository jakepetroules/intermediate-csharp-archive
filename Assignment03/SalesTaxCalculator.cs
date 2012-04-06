namespace IntermediateCSharp.Assignment03
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// The SalesTaxCalculator GUI class.
    /// </summary>
    public partial class SalesTaxCalculator : Form
    {
        /// <summary>
        /// Initializes a new instance of the SalesTaxCalculator class.
        /// </summary>
        public SalesTaxCalculator()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Executed when the calculate button is clicked.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            bool error = false;

            try
            {
                decimal result = Convert.ToDecimal(this.textBoxPrice.Text, CultureInfo.CurrentCulture) * (1M + (Convert.ToDecimal(this.textBoxTax.Text, CultureInfo.CurrentCulture) / 100M));

                this.labelOutput.Text = result.ToString("C", CultureInfo.CurrentCulture);
            }
            catch (InvalidCastException)
            {
                error = true;
            }
            catch (FormatException)
            {
                error = true;
            }

            if (error)
            {
                MessageBox.Show("Please enter only numbers!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
            }
        }

        /// <summary>
        /// Executed when the clear button is clicked.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.textBoxPrice.Clear();
            this.textBoxTax.Clear();
            this.labelOutput.Text = string.Empty;
        }

        /// <summary>
        /// Executed when the exit button is clicked.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Executed when the price text box receives focus.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event arguments.</param>
        private void TextBoxPrice_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        /// <summary>
        /// Executed when the tax text box receives focus.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event arguments.</param>
        private void TextBoxTax_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        /// <summary>
        /// Executed when the price text box is clicked.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event arguments.</param>
        private void TextBoxPrice_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        /// <summary>
        /// Executed when the tax text box receives focus.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event arguments.</param>
        private void TextBoxTax_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
