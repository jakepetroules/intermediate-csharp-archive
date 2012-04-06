namespace IntermediateCSharp.Lesson07
{
    using System.Globalization;

    /// <summary>
    /// Stores data about officers.
    /// </summary>
    public class Officer : Employee
    {
        /// <summary>
        /// The officer's bonus.
        /// </summary>
        private decimal bonus;

        /// <summary>
        /// Initializes a new instance of the Officer class.
        /// </summary>
        /// <param name="name">The officer's name.</param>
        /// <param name="salary">The officer's salary.</param>
        /// <param name="bonus">The officer's bonus.</param>
        public Officer(string name, decimal salary, decimal bonus)
            : base(name, salary)
        {
            this.bonus = bonus;
        }

        /// <summary>
        /// Gets a description of the officer.
        /// </summary>
        /// <value>A description of the officer showing name, salary and bonus.</value>
        public override string Description
        {
            get { return string.Format(CultureInfo.CurrentCulture, "Employee: {0} with salary: {1:C} and bonus: {2:C}", this.Name, this.Salary, this.bonus); }
        }

        /// <summary>
        /// Gets or sets the officer's bonus.
        /// </summary>
        /// <value>The officer's bonus.</value>
        public decimal Bonus
        {
            get { return this.bonus; }
            set { this.bonus = value; }
        }
    }
}
