using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.add(1, "Elif");
            myDictionary.add(2, "Ayşe");
           foreach(var isim in myDictionary.Values)
            {
                Console.WriteLine(isim);
            }
            foreach (var number in myDictionary.Keys)
            {
                Console.WriteLine(number);
            }


        }
    }
}
