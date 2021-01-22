using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();

            myDictionary.add("anahtar1", "deger1");
            myDictionary.add("anahtar2", "deger2");
            myDictionary.add("anahtar3", "deger3");

        }
    }
}
