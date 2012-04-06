namespace IntermediateCSharp.Lesson02
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The HelloWorldModified GUI class.
    /// </summary>
    public partial class HelloWorldModified : Form
    {
        /// <summary>
        /// Initializes a new instance of the HelloWorldModified class.
        /// </summary>
        public HelloWorldModified()
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
            this.labelGreeting.Text = "Hello world!";
        }

        /// <summary>
        /// Clears the greeting.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.labelGreeting.Text = string.Empty;
        }
    }
}
