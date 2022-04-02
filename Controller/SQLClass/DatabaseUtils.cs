﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySqlConnector;

namespace ElectronicScale2MES
{
    class DatabaseUtils
    {
        public static MySqlConnection GetMes_Base_DataDBC()
        {
            string host = "172.16.0.22";
            string user = "guest";
            string password = "guest@123";
            string database = "mes_base_data";

            return DatabaseSQLServerUtils.GetMesDBConnection(host, user, password, database);
        }

        public static MySqlConnection GetMes_Planning_ExcutionDBC()
        {
            string host = "172.16.0.22";
            string user = "guest";
            string password = "guest@123";
            string database = "mes_planning_excution";
            
            return DatabaseSQLServerUtils.GetMesDBConnection(host, user, password, database);
        }

        public static MySqlConnection GetMes_Quality_ControlDBC()
        {
            string host = "172.16.0.22";
            string user = "guest";
            string password = "guest@123";
            string database = "mes_planning_excution";

            return DatabaseSQLServerUtils.GetMesDBConnection(host, user, password, database);
        }
    }
}