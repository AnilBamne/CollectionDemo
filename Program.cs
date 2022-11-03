using System;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to c# collection!");
            ListDemo list1 = new ListDemo();
            list1.List1();
            ListDemo.doListDemo();


            StackDemo.Stack();
            DictionaryInCollection.DictionaryDemo();
            QueueInCollection.QueueDemo();
            SetDemo.doSetDemo();
        }
    }
}
