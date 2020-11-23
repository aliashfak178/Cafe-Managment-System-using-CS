using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Utilities
{
    public class ConnectionStrings
    {
        private static string connectionString;
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings
                    ["CMS"].ConnectionString;
            }
        }
    }
}
