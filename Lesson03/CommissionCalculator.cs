namespace IntermediateCSharp.Lesson03
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// The CommissionCalculator GUI class.
    /// </summary>
    public partial class CommissionCalculator : Form
    {
        /// <summary>
        /// Initializes a new instance of the CommissionCalculator class.
        /// </summary>
        public CommissionCalculator()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Calculates the commission based on the input values.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double commission = Convert.ToDouble(this.textBoxSales.Text, CultureInfo.CurrentCulture) * 0.02;

                MessageBox.Show(String.Format(CultureInfo.CurrentCulture, "Your commission is {0:C}.", commission), this.textBoxName.Text + "'s Commission", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid name and value of sales.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
            }
        }

        /// <summary>
        /// Clears the input text.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.textBoxName.Text = string.Empty;
            this.textBoxSales.Text = string.Empty;
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Selects all the text in the given textbox when it is clicked or entered.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void TextBox_TextBoxEnteredOrSelected(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox != null)
            {
                textbox.SelectAll();
            }
        }
    }
}
