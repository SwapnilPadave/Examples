using System;
using System.Linq;

namespace Ex33_LinkQquery
{
    class Program
    {        
        static void Main(string[] args)
        {
            string[] names = { "swapnil", "saurabh", "faisal", "ajay" };           

            var Linkqquerry = from name in names
                              where name.Contains('p')
                              select name;

            foreach(var name in Linkqquerry)
            {
                Console.WriteLine(name + "");
            }           
        }
    }
}
