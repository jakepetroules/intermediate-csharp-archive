namespace IntermediateCSharp.Assignment07
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// The TimerExtended GUI class.
    /// </summary>
    public partial class TimerExtended : Form
    {
        /// <summary>
        /// An instance of our Time class for testing it.
        /// </summary>
        private TimeExtended time;

        /// <summary>
        /// Initializes a new instance of the TimerExtended class.
        /// </summary>
        public TimerExtended()
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

        /// <summary>
        /// Starts or stops the timer that continuously calls the ExtendedTimer's Tick method.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonControlTick_Click(object sender, EventArgs e)
        {
            if (this.timerTicker.Enabled)
            {
                this.timerTicker.Stop();
                this.buttonControlTick.Text = "Start Ticker";
            }
            else
            {
                this.timerTicker.Start();
                this.buttonControlTick.Text = "Stop Ticker";
            }

            this.buttonGetTime.Enabled = !this.timerTicker.Enabled;
        }

        /// <summary>
        /// Calls the ExtendedTimer's Tick method.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void TimerTicker_Tick(object sender, EventArgs e)
        {
            this.time.Tick();
            this.ButtonGetTime_Click(this, EventArgs.Empty);
        }
    }
}
