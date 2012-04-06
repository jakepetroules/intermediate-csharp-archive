namespace IntermediateCSharp.Lesson01
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The HelloWorld GUI class.
    /// </summary>
    public partial class HelloWorld : Form
    {
        /// <summary>
        /// Initializes a new instance of the HelloWorld class.
        /// </summary>
        public HelloWorld()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Shows a greeting.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonGreetings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, this.RightToLeft == RightToLeft.Yes ? MessageBoxOptions.RtlReading : 0);
        }
    }
}
