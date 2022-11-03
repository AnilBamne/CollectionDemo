using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class StackDemo
    {
        public static void Stack()
        {
            Console.WriteLine("\nIn Stack :\n");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garina");
            
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }

            string pop = stack.Pop();
            Console.WriteLine("\nPoped element is : " + pop);
            Console.WriteLine("After pop stack is : \n");
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }

        }
    }
}
