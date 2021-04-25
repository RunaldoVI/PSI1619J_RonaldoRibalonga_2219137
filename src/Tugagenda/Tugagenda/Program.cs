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
            Application.Run(new Login());        
            
        }
            private static string _connectionString = @"Server=UED1310\SQLEXPRESS;Database=tugagenda;Uid=sa;Password=Pa$$w0rd;";
            private static SqlConnection db = new SqlConnection (_connectionString);
           
       
    }
}
