using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class Stock
    {
        private Items item;

        public Items Items
        {
            get { return item; }
            set { item = value; }
        }



        private int Quantity;

          public int quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        
    }
}
