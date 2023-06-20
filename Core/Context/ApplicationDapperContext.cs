using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Context
{
    public class ApplicationDapperContext
    {
        private readonly IConfiguration _configuration;
        private string _connectionString;

        public ApplicationDapperContext(IConfiguration configuration)
        {
            _configuration = configuration;         
        }
        public IDbConnection CreateConnection()
        {
            _connectionString = _configuration.GetSection("ConnectionStrings").GetSection("DefaultConnectionPSF").Value;
            return new SqlConnection(_connectionString);
        }
        public IDbConnection CreateConnectionFinance()
        {
            _connectionString = _configuration.GetSection("ConnectionStrings").GetSection("DefaultConnectionPSF").Value;
            return new SqlConnection(_connectionString);

        }
        public IDbConnection HookConnection()
        {
            //_configuration.GetSection("ConnectionStrings").GetSection("ReplicaConnectionReadReplica").Value;
            return new SqlConnection(_configuration.GetSection("ConnectionStrings").GetSection("DefaultConnectionHook").Value);
        }
    }
}
