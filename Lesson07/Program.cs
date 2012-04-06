namespace IntermediateCSharp.Lesson07
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
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
            Collection<KeyValuePair<string, Form>> programs = new Collection<KeyValuePair<string, Form>>();
            programs.Add(new KeyValuePair<string, Form>("Employee Class Demonstration", new EmployeeDemonstration()));
            programs.Add(new KeyValuePair<string, Form>("Time Class Demonstration", new TimeDemonstration()));
            Application.Run(new ChooseProgram(programs));
        }
    }
}
