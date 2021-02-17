using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> NameAge = new Dictionary<string, int>();
            NameAge.Add("Dilan", 22);
            NameAge.Add("Ali", 24);
            NameAge.Add("Gamze", 23);
            foreach (var value in NameAge)
            {
                Console.WriteLine(value);
            }
    }
}
