namespace IntermediateCSharp.Assignment08
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// The Index GUI class.
    /// </summary>
    public partial class Index : Form
    {
        /// <summary>
        /// An array of random numbers.
        /// </summary>
        private int[] randomNumbers;

        /// <summary>
        /// Initializes a new instance of the Index class.
        /// </summary>
        public Index()
        {
            this.InitializeComponent();

            this.randomNumbers = new int[10];
            for (int i = 0; i < this.randomNumbers.Length; i++)
            {
                this.randomNumbers[i] = new Random(DateTime.UtcNow.Millisecond).Next();
            }
        }

        /// <summary>
        /// Shows the value at the specified index, or an appropriate message if an exception was thrown.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonGetValue_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(this.textBoxIndex.Text, CultureInfo.InvariantCulture);
                this.labelResult.Text = string.Format(CultureInfo.InvariantCulture, "The value at index {0} is {1}", index, this.randomNumbers[index]);
            }
            catch (FormatException fe)
            {
                this.labelResult.Text = fe.Message;
            }
            catch (IndexOutOfRangeException ioore)
            {
                this.labelResult.Text = ioore.Message;
            }
        }
    }
}
