using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string[9]
            {
                "CALIFORNIA", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "NAIROBI",
                "ZURICH", "LONDON", "PARIS", "ROME"
            };

            var OrderedList = array.OrderBy(s => s.Length).ThenBy(x => x).ToList();

            foreach(var y in OrderedList)
            {
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }
    }
}
