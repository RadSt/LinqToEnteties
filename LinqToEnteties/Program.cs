using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToEnteties
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars =
            {
                "Mercedes", "Porshe", "Toyota", "VAZ", "OKA", "KAMAZ", "Nissan", "Reno", "KIA",
                "Folkswagen"
            };

            var filteredCars = cars.Where((c, i) => (i & 1) == 1);

            foreach (var car in filteredCars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
