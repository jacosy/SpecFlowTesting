using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillToIDsMaintenance.Models;
using FvTech.Data;

namespace BillToIDsMaintenance.Repositories
{
    public class BillToIDsRepository
    {
        SqlDatabaseConnection sqlDbCon;

        public BillToIDsRepository(SqlDatabaseConnection sqlDbConnection)
        {
            sqlDbCon = sqlDbConnection;
        }

        public DataSet GetBillToIDs(string billToId = null)
        {
            var paramList = new List<SerializableSqlParameter>();
            paramList.Add(new SerializableSqlParameter("@billToId", billToId));
            return sqlDbCon.RunStoredProcedure("IBMMSC_GetBillToIDs", paramList);
        }

        public DataSet CreateBillToID(string billToId, string userName, DateTime createDate)
        {
            var paramList = new List<SerializableSqlParameter>();
            paramList.Add(new SerializableSqlParameter("@billToId", billToId));
            paramList.Add(new SerializableSqlParameter("@createBy", userName));
            paramList.Add(new SerializableSqlParameter("@creationDate", createDate));
            return sqlDbCon.RunStoredProcedure("IBMMSC_InsertBillToID", paramList);
        }

        public void DeleteBillToID(string billToId)
        {
            var paramList = new List<SerializableSqlParameter>();
            paramList.Add(new SerializableSqlParameter("@billToId", billToId));
            sqlDbCon.RunStoredProcedure("IBMMSC_DeleteBillToID", paramList);
        }
    }
}
