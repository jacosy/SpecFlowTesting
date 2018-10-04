using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillToIDsMaintenance.Models
{
    public class BillToIDModel
    {
        public int ID { get; set; }
        public string BillToID { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
