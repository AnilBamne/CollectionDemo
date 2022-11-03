using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
        class DictionaryInCollection
        {
            public static void DictionaryDemo()
            {
                Console.WriteLine("\nIn doDictionaryDemo");
                Dictionary<int, string> dictionary = new Dictionary<int, string>();
                dictionary.Add(100, "Amit");
                dictionary.Add(101, "Rahul");
                dictionary.Add(102, "Vijay");
                Console.WriteLine("Access value using key(key=100): " + dictionary[100]);
                Console.WriteLine("\nIterating Dictionary: ");
                foreach (var element in dictionary)
                {
                    Console.WriteLine("key=" + element.Key + "& Value=" + element.Value);
                }
                Dictionary<int, string>.Enumerator obj = dictionary.GetEnumerator();
                while (obj.MoveNext())
                {
                    Console.WriteLine(obj.Current);
                }
            }
        }
}
