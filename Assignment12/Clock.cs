namespace IntermediateCSharp.Assignment12
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using Assignment07;

    /// <summary>
    /// The Clock GUI class.
    /// </summary>
    public partial class Clock : Form
    {
        /// <summary>
        /// An instance of our Time class for testing it.
        /// </summary>
        private TimeExtended time;

        /// <summary>
        /// Initializes a new instance of the Clock class.
        /// </summary>
        public Clock()
        {
            this.InitializeComponent();
            this.time = new TimeExtended();
        }

        /// <summary>
        /// Stores the values specified on the GUI, in our instance of the Time class.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonSetTime_Click(object sender, EventArgs e)
        {
            this.time.SetTime((int)this.numericUpDownSetHour.Value, (int)this.numericUpDownSetMinute.Value, (int)this.numericUpDownSetSecond.Value);
            this.timer.Start();
        }

        /// <summary>
        /// Calls the ExtendedTimer's Tick method.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void TimerTicker_Tick(object sender, EventArgs e)
        {
            this.time.Tick();
            this.labelTime.Text = string.Format(CultureInfo.InvariantCulture, "{0:D2}:{1:D2}:{2:D2}", this.time.Hour, this.time.Minute, this.time.Second);
        }
    }
}
