namespace IntermediateCSharp.Lesson12
{
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Our special button which is drawn as a blue-colored ellipse.
    /// </summary>
    public partial class SpecialButton : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the SpecialButton class.
        /// </summary>
        public SpecialButton()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Paints the SpecialButton.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SpecialButton_Paint(object sender, PaintEventArgs e)
        {
            // Create the graphics object
            Graphics ellipse = e.Graphics;

            // Create a brush to fill in the ellipse
            SolidBrush myBrush = new SolidBrush(Color.Blue);

            // Fill in the ellipse with my new brush
            ellipse.FillEllipse(myBrush, 0, 0, this.Width, this.Height);
        }
    }
}
