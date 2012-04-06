namespace IntermediateCSharp.Lesson04
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// The NewCarSales GUI class.
    /// </summary>
    public partial class NewCarSales : Form
    {
        /// <summary>
        /// Initializes a new instance of the NewCarSales class.
        /// </summary>
        public NewCarSales()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Occurs when the calculate cost button is clicked.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonCalculateCost_Click(object sender, EventArgs e)
        {
            // Base cost is $15,000
            decimal carCost = 15000M;

            this.labelCost.Text = string.Empty;
            string errorString = string.Empty;
            string errorTitle = "Missing information";

            if (string.IsNullOrEmpty(this.textBoxName.Text))
            {
                errorString += "You must enter your name!" + Environment.NewLine;
            }

            if (this.checkBoxPowerWindows.CheckState == CheckState.Indeterminate)
            {
                errorString += "You must make a choice for power windows!" + Environment.NewLine;
            }
            else if (this.checkBoxPowerWindows.Checked)
            {
                carCost += 500M;
            }

            if (this.checkBoxAirConditioning.CheckState == CheckState.Indeterminate)
            {
                errorString += "You must make a choice for air conditioning!" + Environment.NewLine;
            }
            else if (this.checkBoxAirConditioning.Checked)
            {
                carCost += 750M;
            }

            if (this.checkBoxChrome.CheckState == CheckState.Indeterminate)
            {
                errorString += "You must make a choice for chrome!" + Environment.NewLine;
            }
            else if (this.checkBoxChrome.Checked)
            {
                carCost += 1000M;
            }

            if (!this.radioButtonColourBlue.Checked && !this.radioButtonColourWhite.Checked)
            {
                errorString += "You must make a choice for colour!" + Environment.NewLine;
            }

            // Deduct 3% from the cost of the car if this is a business account
            if (this.radioButtonAcctBusiness.Checked)
            {
                carCost *= 0.97M;
            }

            if (!string.IsNullOrEmpty(errorString))
            {
                MessageBox.Show(errorString, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                return;
            }

            this.labelCost.Text = String.Format(CultureInfo.CurrentCulture, "{0}, the cost of your new car is:\n{1:C}", this.textBoxName.Text, carCost);
        }
    }
}
