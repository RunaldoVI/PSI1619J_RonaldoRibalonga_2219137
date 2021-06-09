using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tugagenda
{
    static class Program
    {
        public static string MyConnectionString;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            MyConnectionString = ConfigurationManager.ConnectionStrings["tugagenda"].ConnectionString;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmcomeco());        
            
        }
           
        public static User logUser { get; set; }
       
    }
}
