using DapperRepositoryLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DapperRepositoryLib.Data
{
    public class ConnectionHelper : IConnectionHelper
    {
        private readonly string _connectionString;
        public ConnectionHelper(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
