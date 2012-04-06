namespace IntermediateCSharp.Lesson08
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Forms;
    using Lesson07;

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
            programs.Add(new KeyValuePair<string, Form>("Exceptions Demonstration", new ExceptionHandling()));
            programs.Add(new KeyValuePair<string, Form>("Files Demonstration", new FilesDemonstration()));
            programs.Add(new KeyValuePair<string, Form>("Dialogs Demonstration", new DialogsDemonstration()));
            Application.Run(new ChooseProgram(programs));
        }
    }
}
