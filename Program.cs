using System;

namespace OdevDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int > myDictionary = new MyDictionary<string, int>();
            myDictionary.Add(" ALİ ",3);
            myDictionary.Add(" Mehmet ",4);
            myDictionary.Add(" Ahmet ",5);


        }
    }
}
