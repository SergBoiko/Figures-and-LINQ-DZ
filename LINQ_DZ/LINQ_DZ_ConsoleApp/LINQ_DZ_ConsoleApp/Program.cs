using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_DZ_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersList = new List<int> { 2, 4, -7, 8, -6, 2, 5 };

            var firstPositiveNumber = numbersList.First(x => x > 0);
            var lastNegativeNumber = numbersList.Last(x => x < 0);
            Console.WriteLine($"First even number - {firstPositiveNumber}");
            Console.WriteLine($"Last odd number - { lastNegativeNumber}");


            var firstPositiveNumberorNull = numbersList.FirstOrDefault(x => x > 0);
            var lastNegativeNumberorNull = numbersList.LastOrDefault(x => x < 0);
            Console.WriteLine($"First even number or null - {firstPositiveNumberorNull}");
            Console.WriteLine($"Last odd number or null - { lastNegativeNumberorNull}");

            var c = 'C';
            var stringsList = new List<string> { "qwe", "ced", "123", "cefdg", null};
            var result = string.Concat(stringsList.Where(x => x?.ToLower().StartsWith(c.ToString().ToLower()) ?? false));
            Console.WriteLine($"Show the element started with 'C' - {result}");

            var evenNumbers = numbersList.Where(x => x % 2 == 0).Distinct().ToList();
            for(int i = 0; i < evenNumbers.Count(); i++)
            {
                Console.WriteLine($"Return the numbers - { evenNumbers[i]}");
            }
            


            var D = 5;
            var firstLargerNumber = numbersList.First(x => x > 0);
            var evenPositiveNumberReversed = numbersList.Where(x => x > 0 && x % 2 == 0).Reverse().ToList();
            for (int i = 0; i < evenPositiveNumberReversed.Count(); i++)
            {
                Console.WriteLine($"Return all the even and odd numbers - { evenPositiveNumberReversed[i]}");
            }

            var secondNumbersList = new List<int>() { 2, 4, -7, 8, -6, 2, 5, 0 };
            var concatList = numbersList.Where(x => x > D).DefaultIfEmpty(D).Concat(secondNumbersList.Where(x => x > D)).DefaultIfEmpty(D).ToList();
            for (int i = 0; i < concatList.Count(); i++)
            {
                Console.WriteLine($"New list - { concatList[i]}");
            }

            var suppliers = new List<Supply>()
            {
                    new Supply()
                {
                    Name = "supp1",
                    Amount = 100,
                    Date = DateTime.Now
                },
                new Supply()
                {
                    Name = "supp2",
                    Amount = 200,
                    Date = DateTime.Now.AddDays(-1)
                },
                new Supply()
                {
                    Name = "supp1",
                    Amount = 300,
                    Date = DateTime.Now.AddDays(-2)
                },
                new Supply()
                {
                    Name = "supp4",
                    Amount = 100,
                    Date = DateTime.Now
                },
                new Supply()
                {
                    Name = "supp2",
                    Amount = 200,
                    Date = DateTime.Now.AddDays(-1)
                },
                new Supply()
                {
                    Name = "supp6",
                    Amount = 300,
                    Date = DateTime.Now.AddDays(-2)
                },
            };


            var res = suppliers
                .GroupBy(x => x.Name)
                .Select(x => new
                {
                    TotalAmount = x.Sum(y => y.Amount),
                    FirstSupplyDate = x.Min(y => y.Date),
                    LastSupplyDate = x.Max(y => y.Date),
                })
                .Where(x => x.TotalAmount > 0).ToList();

            for (int i = 0; i < res.Count(); i++)
            {
                Console.WriteLine($"Total amount - { res[i].TotalAmount}");
            }

            for (int i = 0; i < res.Count(); i++)
            {
                Console.WriteLine($"First supply date - { res[i].FirstSupplyDate}");
            }

            for (int i = 0; i < res.Count(); i++)
            {
                Console.WriteLine($"Last supply date - { res[i].LastSupplyDate}");
            }

            Console.ReadKey();
        }

        class Supply
        {
            public string Name { get; set; }
            public double Amount { get; set; }
            public DateTime Date { get; set; }
        }

    }
}
