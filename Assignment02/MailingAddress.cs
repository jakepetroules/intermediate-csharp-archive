namespace IntermediateCSharp.Assignment02
{
    using System.Windows.Forms;

    /// <summary>
    /// The MailingAddress GUI class.
    /// </summary>
    public partial class MailingAddress : Form
    {
        /// <summary>
        /// Initializes a new instance of the MailingAddress class.
        /// </summary>
        public MailingAddress()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Shows the program creator's mailing address.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonShow_Click(object sender, System.EventArgs e)
        {
            this.labelName.Text = "Jake Petroules";
            this.labelStreet.Text = "11 Fairmount Street";
            this.labelCityStateZIP.Text = "Nashua, NH 03064-2522";
        }

        /// <summary>
        /// Shows the program creator's mailing address.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonHide_Click(object sender, System.EventArgs e)
        {
            this.labelName.Text = string.Empty;
            this.labelStreet.Text = string.Empty;
            this.labelCityStateZIP.Text = string.Empty;
        }
    }
}
