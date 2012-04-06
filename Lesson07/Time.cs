namespace IntermediateCSharp.Lesson07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Our custom time class.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// The stored hour.
        /// </summary>
        private int hour;

        /// <summary>
        /// The stored minute.
        /// </summary>
        private int minute;

        /// <summary>
        /// The stored second.
        /// </summary>
        private int second;

        /// <summary>
        /// Initializes a new instance of the Time class. All values are left at their default values (zero).
        /// </summary>
        public Time()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Time class. Internal values are set to the values specified in the parameter list.
        /// </summary>
        /// <param name="hour">The hour to store.</param>
        /// <param name="minute">The minute to store.</param>
        /// <param name="second">The second to store.</param>
        public Time(int hour, int minute, int second)
        {
            this.SetTime(hour, minute, second);
        }

        /// <summary>
        /// Gets or sets the stored hour.
        /// </summary>
        /// <value>The hour component of this instance.</value>
        /// <exception cref="System.ArgumentException">Throws a System.ArgumentException if the value being set is not in the range 0-23, inclusive.</exception>
        public int Hour
        {
            get
            {
                return this.hour;
            }

            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("The value was not in the range 0-23, inclusive.");
                }
                else
                {
                    this.hour = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the stored minute.
        /// </summary>
        /// <value>The minute component of this instance.</value>
        /// <exception cref="System.ArgumentException">Throws a System.ArgumentException if the value being set is not in the range 0-59, inclusive.</exception>
        public int Minute
        {
            get
            {
                return this.minute;
            }

            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("The value was not in the range 0-59, inclusive.");
                }
                else
                {
                    this.minute = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the stored second.
        /// </summary>
        /// <value>The second component of this instance.</value>
        /// <exception cref="System.ArgumentException">Throws a System.ArgumentException if the value being set is not in the range 0-59, inclusive.</exception>
        public int Second
        {
            get
            {
                return this.second;
            }

            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("The value was not in the range 0-59, inclusive.");
                }
                else
                {
                    this.second = value;
                }
            }
        }

        /// <summary>
        /// Sets all three attributes of the time (hour, minute, second) at once.
        /// </summary>
        /// <param name="timeHour">The hour to store.</param>
        /// <param name="timeMinute">The minute to store.</param>
        /// <param name="timeSecond">The second to store.</param>
        public void SetTime(int timeHour, int timeMinute, int timeSecond)
        {
            this.hour = timeHour;
            this.minute = timeMinute;
            this.second = timeSecond;
        }
    }
}
