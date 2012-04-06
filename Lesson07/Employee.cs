namespace IntermediateCSharp.Lesson07
{
    using System.Globalization;

    /// <summary>
    /// Stores data about employees.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The employee's name.
        /// </summary>
        private string name;

        /// <summary>
        /// The employee's salary.
        /// </summary>
        private decimal salary;

        /// <summary>
        /// Initializes a new instance of the Employee class.
        /// </summary>
        /// <param name="name">The employee's name.</param>
        /// <param name="salary">The employee's salary.</param>
        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        /// <summary>
        /// Gets a description of the employee.
        /// </summary>
        /// <value>A description of the employee showing name and salary.</value>
        public virtual string Description
        {
            get { return string.Format(CultureInfo.CurrentCulture, "Employee: {0} with salary: {1:C}", this.name, this.salary); }
        }

        /// <summary>
        /// Gets or sets the employee's name.
        /// </summary>
        /// <value>The employee's name.</value>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets or sets the employee's salary.
        /// </summary>
        /// <value>The employee's salary.</value>
        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
    }
}
