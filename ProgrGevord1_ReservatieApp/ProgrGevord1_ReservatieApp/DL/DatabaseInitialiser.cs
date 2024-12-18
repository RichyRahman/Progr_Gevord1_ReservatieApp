using Microsoft.Data.SqlClient;
using ProgrGevord1_ReservatieApp.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrGevord1_ReservatieApp.DL
{
    class DatabaseInitialiser
    {
        public void DatabaseInitialize()
        {
        string connectionString = "@data source = LAPTOP - KOF6V1EN\\SQLEXPRESS;initial catalog = ParkDB; trusted_connection=true";

        using(SqlConnection _con = new SqlConnection(connectionString))
        {
            string queryStatement = "INSERT dbo.Faciliteiten";

            using(SqlCommand _cmd = new SqlCommand(queryStatement, _con))
            {
                _cmd.BeginExecuteNonQuery();

            }
        }

        }

    }
}
