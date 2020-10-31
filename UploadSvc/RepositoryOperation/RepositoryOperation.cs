using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using HoneyWell.Flight.Stream.Core.Entities;

namespace UploadSvc.RepositoryOperation
{
    public class RepositoryOperation : IRepositoryOperation
    {

        private SqlConnection _sqlConnection;
        private string _connectionString;

        public RepositoryOperation()
        {
            _sqlConnection = new SqlConnection(_connectionString);

        }

        public bool GetMediaAvailability(Flight flightDetails)
        {
            throw new NotImplementedException();
        }

        
    }
}
