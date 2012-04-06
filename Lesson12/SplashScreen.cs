namespace IntermediateCSharp.Lesson12
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Globalization;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// The program splash screen.
    /// </summary>
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// The nunber of spaces between the text (which will be multiplied by 10).
        /// </summary>
        private int spaces = 5;

        /// <summary>
        /// The index of the character to capitalize.
        /// </summary>
        private int charIndex = 0;

        /// <summary>
        /// Initializes a new instance of the SplashScreen class.
        /// </summary>
        public SplashScreen()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the current number of spaces between the two bits of text.
        /// </summary>
        /// <param name="number">Number of spaces.</param>
        /// <returns>A string with the specified number of spaces.</returns>
        private static string Spaces(int number)
        {
            StringBuilder sb = new StringBuilder();
            do
            {
                sb.Append(' ');
            }
            while (number-- > 0);

            return sb.ToString();
        }

        /// <summary>
        /// Gets the current state of the string for the effect.
        /// </summary>
        /// <param name="str">The string to work on.</param>
        /// <param name="index">The index of the capitialized character.</param>
        /// <returns>A string with the specified character capitalized.</returns>
        private static string GetEffectString(string str, int index)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (i == index)
                {
                    sb.Append(str[i].ToString().ToUpper(CultureInfo.CurrentCulture));
                }
                else
                {
                    sb.Append(str[i]);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Transforms the splash screen into an ellipse when it loads.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Create a GraphicsPath object that will be used to shape our form
            GraphicsPath formShape = new GraphicsPath();

            // Make this new shape into an ellipse
            formShape.AddEllipse(15, 30, this.Width - 30, this.Height - 45);

            // Make the form show as only this ellipse
            this.Region = new Region(formShape);
        }

        /// <summary>
        /// Timer event handler for timer that decides when the splash screen closes.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Timer event handler for text effects.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void TimerText_Tick(object sender, EventArgs e)
        {
            if (this.spaces >= 0)
            {
                this.labelName.Text = "Jake" + SplashScreen.Spaces(this.spaces-- * 10) + "Petroules";
            }
            else
            {
                this.labelName.Text = SplashScreen.GetEffectString("Jake Petroules", this.charIndex++);
            }
        }
    }
}
