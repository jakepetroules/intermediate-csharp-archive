namespace IntermediateCSharp.Lesson08
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// The ExceptionHandling GUI class.
    /// </summary>
    public partial class ExceptionHandling : Form
    {
        /// <summary>
        /// Initializes a new instance of the ExceptionHandling class.
        /// </summary>
        public ExceptionHandling()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Determines the quotient of the values in the numeric up-downs.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonGo_Click(object sender, EventArgs e)
        {
            try
            {
                decimal result = 0;
                if (this.radioButtonAdd.Checked)
                {
                    result = this.numericUpDownNumerator.Value + this.numericUpDownDenominator.Value;
                }
                else if (this.radioButtonSubtract.Checked)
                {
                    result = this.numericUpDownNumerator.Value - this.numericUpDownDenominator.Value;
                }
                else if (this.radioButtonMultiply.Checked)
                {
                    result = this.numericUpDownNumerator.Value * this.numericUpDownDenominator.Value;
                }
                else if (this.radioButtonDivide.Checked)
                {
                    result = this.numericUpDownNumerator.Value / this.numericUpDownDenominator.Value;
                }
                else
                {
                    MessageBox.Show("Please select a mathematical operation!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (this.RightToLeft == RightToLeft.Yes) ? MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading : 0);
                    return;
                }

                this.labelResult.Text = "Result:\n" + result.ToString(CultureInfo.CurrentCulture);
            }
            catch (DivideByZeroException)
            {
                this.labelResult.Text = "Result:\nUndefined";
            }
            catch (OverflowException)
            {
                this.labelResult.Text = "Result:\nToo large to calculate";
            }
        }

        /// <summary>
        /// Copies the number in the result label to the clipboard.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonCopyResult_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.labelResult.Text.Replace("Result:\n", string.Empty));
        }
    }
}
