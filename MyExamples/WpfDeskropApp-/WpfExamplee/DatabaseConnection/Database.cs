using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExamplee.DatabaseConnection
{
    internal class Database
    {
        public static string GetConnectionString
        {
            get
            {
                return "Data Source=.\\SQLExpress;Initial Catalog=Northwind;Integrated Security=SSPI";
            }
        }
    }
}
