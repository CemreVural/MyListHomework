
using System;

namespace MyListHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryList<double, string> products = new MyDictionaryList<double, string>();
            MyDictionaryList<double, string> MyDictionaryList = new MyDictionaryList<double, string>();
            MyDictionaryList.Add(1, "Hand Guns");
            MyDictionaryList.Add(2, "Sub Machine Guns");
            MyDictionaryList.Add(3, "Heavy Machine Guns");
            MyDictionaryList.Add(4, "Light Machine Guns");
            MyDictionaryList.Add(5, "Non Lethal Guns");
            MyDictionaryList.Add(6, "Melee Weapons");

            Console.WriteLine("Categories: ->>>>\n");
            for (int i = 0; i < MyDictionaryList.Length; i++)
            {
                Console.WriteLine("Code: " + MyDictionaryList.Keys[i] + " Name: " + MyDictionaryList.Values[i]);
            }
        }
    }
}
