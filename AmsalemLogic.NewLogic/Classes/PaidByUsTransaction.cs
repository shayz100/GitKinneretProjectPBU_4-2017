using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmsalemLogic.NewLogic.Classes
{
  public  class PaidByUsTransaction
    {
        public int Id { get; set; }
        public string CurrencyCode { get; set; }
        public int TripNumber { get; set; }
        public int OriginalAmount { get; set; }
        public string OriginalCurrencyCode { get; set; }
        public string SupplierName { get; set; }
        public int SupplierAccountNum { get; set; }
        public string BackOfficeCompany { get; set; }
        public string For { get; set; }
        public string Item { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDateTime{ get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public int Status { get; set; }
        public int BillingAmount { get; set; }
        public string BillingCurrencyCode { get; set; }



    }
}
