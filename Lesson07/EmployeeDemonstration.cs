namespace IntermediateCSharp.Lesson07
{
    using System.Windows.Forms;

    /// <summary>
    /// The EmployeeDemonstration GUI class.
    /// </summary>
    public partial class EmployeeDemonstration : Form
    {
        /// <summary>
        /// An instance of our Employee class for testing it.
        /// </summary>
        private Employee employee;

        /// <summary>
        /// An instance of our Officer class for testing it.
        /// </summary>
        private Officer officer;

        /// <summary>
        /// An instance of our Officer class, but held in a variable of type Employee for demonstrating polymorphism.
        /// </summary>
        private Employee polymorphicOfficer;

        /// <summary>
        /// Initializes a new instance of the EmployeeDemonstration class.
        /// </summary>
        public EmployeeDemonstration()
        {
            this.InitializeComponent();
            this.employee = new Employee("Joe Employee", 123.45M);
            this.officer = new Officer("Pat Officer", 987.65M, 1000M);
            this.polymorphicOfficer = this.officer;
        }

        /// <summary>
        /// Shows the data of the test instance of Employee on the GUI.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonGetEmployeeInfo_Click(object sender, System.EventArgs e)
        {
            this.labelEmployeeInfo.Text = this.employee.Description;
        }

        /// <summary>
        /// Shows the data of the test instance of Officer on the GUI.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonGetOfficerInfo_Click(object sender, System.EventArgs e)
        {
            this.labelOfficerInfo.Text = this.officer.Description;
        }

        /// <summary>
        /// Shows the data of the polymorphic test instance of Officer on the GUI.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonGetOfficerInfoPoly_Click(object sender, System.EventArgs e)
        {
            this.labelOfficerInfoPoly.Text = this.polymorphicOfficer.Description;
        }
    }
}
