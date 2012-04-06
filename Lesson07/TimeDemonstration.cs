namespace IntermediateCSharp.Lesson07
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// The TimeDemonstration GUI class.
    /// </summary>
    public partial class TimeDemonstration : Form
    {
        /// <summary>
        /// An instance of our Time class for testing it.
        /// </summary>
        private Time time;

        /// <summary>
        /// Initializes a new instance of the TimeDemonstration class.
        /// </summary>
        public TimeDemonstration()
        {
            this.InitializeComponent();
            this.time = new Time();
        }

        /// <summary>
        /// Stores the values specified on the GUI, in our instance of the Time class.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonSetTime_Click(object sender, EventArgs e)
        {
            this.time.SetTime((int)this.numericUpDownSetHour.Value, (int)this.numericUpDownSetMinute.Value, (int)this.numericUpDownSetSecond.Value);
        }

        /// <summary>
        /// Retrieves the values stored in our instance of the Time class and displays them on the GUI.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonGetTime_Click(object sender, EventArgs e)
        {
            this.labelTime.Text = string.Format(CultureInfo.InvariantCulture, "{0:D2}:{1:D2}:{2:D2}", this.time.Hour, this.time.Minute, this.time.Second);
        }
    }
}
