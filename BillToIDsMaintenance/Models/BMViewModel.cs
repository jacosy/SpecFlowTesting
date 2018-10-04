using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BillToIDsMaintenance.Models
{
    public class BMViewModel
    {
        public string InputBillToID { get; set; }
        //public IList<BillToIDModel> BillToIDList { get; set; }
        public DataTable BillToIdDt { get; set; }
    }
}
