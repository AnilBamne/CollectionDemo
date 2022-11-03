using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class SetDemo
    {
        public static void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");
            HashSet<string> set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add(null);      //Allows a only one null value
            set.Add("Ajay");    //Set doesnot allow Duplicate values
            set.Add("Anil");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            //Console.WriteLine(set[1]);
        }
    }
}
