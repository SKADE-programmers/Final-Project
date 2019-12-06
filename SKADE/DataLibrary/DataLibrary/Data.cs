using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    internal static class Data
    {
        static internal System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();

        static Data()
        {
            con.ConnectionString = global::DataLibrary.Properties.Settings.Default.EmmasConnectionString;
        }
    }
}
