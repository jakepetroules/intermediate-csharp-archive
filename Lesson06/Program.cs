namespace IntermediateCSharp.Lesson06
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The main entry class for the application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ControlDemonstration());
        }
    }
}
