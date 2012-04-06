namespace IntermediateCSharp.Assignment07
{
    using IntermediateCSharp.Lesson07;

    /// <summary>
    /// An extended version of the Time class with an added Tick method.
    /// </summary>
    public class TimeExtended : Time
    {
        /// <summary>
        /// Initializes a new instance of the TimeExtended class. All values are left at their default values (zero).
        /// </summary>
        public TimeExtended()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeExtended class. Internal values are set to the values specified in the parameter list.
        /// </summary>
        /// <param name="hour">The hour to store.</param>
        /// <param name="minute">The minute to store.</param>
        /// <param name="second">The second to store.</param>
        public TimeExtended(int hour, int minute, int second) : base(hour, minute, second)
        {
        }

        /// <summary>
        /// Adds one second to the total time stored (hours, minutes and seconds). Values will be correctly incremented (e.g. 00:00:59 will become 00:01:00).
        /// </summary>
        public void Tick()
        {
            if (this.Second == 59)
            {
                this.Second = 0;
            }
            else
            {
                this.Second = this.Second + 1;
                return;
            }

            if (this.Minute == 59)
            {
                this.Minute = 0;
            }
            else
            {
                this.Minute = this.Minute + 1;
                return;
            }

            if (this.Hour == 23)
            {
                this.Hour = 0;
            }
            else
            {
                this.Hour = this.Hour + 1;
            }
        }
    }
}
