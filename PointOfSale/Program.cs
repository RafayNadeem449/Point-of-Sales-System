using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stock> stock = new List<Stock>();
            Bill myRecipt = new Bill();
            int choice = -1; bool dis = false;
            do
            {
                Console.WriteLine("|----------------------------------------------------|");
                Console.WriteLine("|               Point of Sales System                |");
                Console.WriteLine("|----------------------------------------------------|");
                Console.WriteLine("|Press 1 for Adding Item                             |");
                Console.WriteLine("|Press 2 for Buying Item                             |");
                Console.WriteLine("|Press 3 for Generating Bill                         |");
                Console.WriteLine("|Press 0 to Exit                                     |");
                Console.WriteLine("|----------------------------------------------------|");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Stock s = new Stock();
                            Items p = new Items();
                            Console.WriteLine("Enter Product name = ");
                            p.name = Console.ReadLine();

                            Console.WriteLine("Enter Price  = ");
                            p.price = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Category  = ");
                            p.catagory = Console.ReadLine();
                            s.Items = p;

                            Console.WriteLine("Enter Quantity  = ");
                            s.quantity = Convert.ToInt32(Console.ReadLine());
                            stock.Add(s);

                            break;
                        }

                    case 2:
                        {
                            foreach (Stock stockobj in stock)
                            {
                                Console.WriteLine(stockobj.Items.name);
                            }

                            Console.WriteLine("Choose your product by name = ");
                            string ch = Console.ReadLine();

                            for (int i = 0; i < stock.Count; i++)
                            {
                                if (ch.Equals(stock[i].Items.name))
                                {
                                    Items p = stock[i].Items;
                                    myRecipt.BillDate = DateTime.Now;
                                    myRecipt.ListofItem.Add(p);
                                    Console.WriteLine("Producted Successfully Added in Cart");
                                }
                            }
                            break;
                        }

                    case 3:
                        {

                            foreach (var item in myRecipt.ListofItem)
                            {
                                myRecipt.totalprice += item.price;
                            }
                            Console.WriteLine("Your Total Bill is = ");
                            Console.WriteLine(myRecipt.totalprice);

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("INVALID");

                            break;
                        }
                }
                Console.WriteLine("Do you want to contiune = ");
                string s1 = Console.ReadLine();
                if (s1.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {

                    dis = true;

                }
                else
                {
                    dis = false;
                }
            } while (dis != false); 
        }
   }
}
