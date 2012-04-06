namespace IntermediateCSharp.Assignment01
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The Hello GUI class.
    /// </summary>
    public partial class Hello : Form
    {
        /// <summary>
        /// Initializes a new instance of the Hello class.
        /// </summary>
        public Hello()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Shows the program creator's name in a message box.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jake Petroules", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
        }
    }
}
