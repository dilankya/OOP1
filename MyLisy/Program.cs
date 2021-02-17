using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();

            dictionary.Add("Ankara","Türkiye");
            dictionary.Add("Pekin", "Çin");
            dictionary.Add("Paris", "Fransa");
            

            dictionary.Key("Ankara");
            dictionary.Key("Pekin");
            dictionary.Key("Paris");
            

                }
    }
}
