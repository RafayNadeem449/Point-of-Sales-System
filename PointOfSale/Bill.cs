using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class Bill
    {
        public List<Items> ListofItem;
        
        public Bill()
        {
            ListofItem = new List<Items>();
        }

        private DateTime billDate;

        public DateTime BillDate
        {
            get { return billDate; }
            set { billDate = value; }
        }

        private int TotalPrice;

        public int totalprice
        {
            get { return TotalPrice; }
            set { TotalPrice = value; }
        }
        
        
    }
}
