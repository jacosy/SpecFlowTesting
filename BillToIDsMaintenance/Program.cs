using FvTech.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BillToIDsMaintenance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BillToIDsMaintenance(new SqlDatabaseConnection("Initial Catalog=UnitedStationers;Data Source=test-sql01;UID=cardiff;PWD=cardiff;Packet Size=4096;"), "Test EOBLockbox", "user"));
        }
    }
}
