using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class ListDemo
    {
        public  void List1()
        {
            ///<summary>
            ///Create lists 0f integer and Strings
            /// </summary>
            var list = new List<int>();
            var countries=new List<string>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            countries.Add("India");
            countries.Add("Srilanka");
            countries.Add("Japan");
            countries.Add("India");
            Console.WriteLine("list1 values are : ");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List of countries :");
            foreach(var country in countries)
            {
                Console.WriteLine(country);
            }
           
        }
        public static void doListDemo()
        {
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            //list.Add(123);
            Console.WriteLine("List of Names : ");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(list[3]);
        }
    }
}
