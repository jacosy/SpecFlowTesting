using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillToIDsMaintenance.Models;
using FvTech.Data;
using System.Data;
using BillToIDsMaintenance.Repositories;

namespace BillToIDsMaintenance
{
    public class BMPresenter
    {
        private IBMViewer viewer;
        private BMViewModel vm;
        private BillToIDsRepository repository;
        private string userName;

        public BMPresenter(SqlDatabaseConnection databaseConnection, string userName, IBMViewer view)
        {
            // TODO: Complete member initialization
            this.repository = new BillToIDsRepository(databaseConnection);
            this.userName = userName;
            this.viewer = view;
            this.vm = new BMViewModel { InputBillToID = string.Empty };
        }

        public BMViewModel Initialize()
        {
            Search();
            viewer.Show(vm);
            return this.vm;
        }

        public DataTable Search(string searchBillToId = null)
        {
            DataSet ds = this.repository.GetBillToIDs(searchBillToId);
            DataTable resultDt;

            if (ds != null && ds.Tables.Count > 0)
            {
                resultDt = ds.Tables[0];
            }
            else
            {
                resultDt = CreateBillToIdDt();
            }
            this.vm.BillToIdDt = resultDt;

            return resultDt;
        }

        public string Create(string billToId)
        {
            string msg = ValidateBillToId(billToId);
            if (string.IsNullOrEmpty(msg))
            {
                DataSet ds = this.repository.CreateBillToID(billToId, this.userName, DateTime.Now);

                if (ds != null && ds.Tables.Count > 0)
                {
                    msg = string.Format("BillToID: {0} is already existed in DB.{1}Can't create duplicate BillToID!", billToId, Environment.NewLine);
                }
                else
                {
                    msg = string.Format("BillToID: {0} is created successfully!", billToId);
                }
            }
            return msg;
        }

        public string Delete(string billToId)
        {
            string msg = ValidateBillToId(billToId);
            if (string.IsNullOrEmpty(msg))
            {
                this.repository.DeleteBillToID(billToId);
                msg = string.Format("BillToID: {0} is deleted successfully!", billToId);
            }
            return msg;
        }

        public static string ValidateBillToId(string billToId)
        {
            string result = string.Empty;
            string trimBillToId = billToId == null ? null : billToId.Trim();

            if (string.IsNullOrEmpty(trimBillToId))
            {
                result = "BillToID can't be empty!";
            }
            else if (trimBillToId.Length > 100)
            {
                result = "The length of BillToID can't be over 100 characters!";
            }

            return result;
        }

        private DataTable CreateBillToIdDt()
        {
            var dt = new DataTable();            
            dt.Columns.Add("BillToID", typeof(string));
            dt.Columns.Add("LastModifiedBy", typeof(string));
            dt.Columns.Add("LastModifiedDate", typeof(DateTime));
            return dt;
        }
    }
}
