using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tugagenda
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
            Application.Run(new comeco());        
            
        }
            private static string _connectionString = "Server=devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619J_RonaldoRibalonga_2219137;Uid=PSIM1619J_RonaldoRibalonga_2219137;Password=4bBC7C8A;";
            private static SqlConnection db = new SqlConnection (_connectionString);
           
       
    }
}
