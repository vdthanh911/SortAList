using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAList
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> myList = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                myList.Add(random.Next(100));
            }

            Console.WriteLine("Printing My List:");
            PrintList(myList);

            List<int> listTop20 = myList.OrderByDescending(r => r).Take(20).ToList();

            foreach(int val in listTop20)
            {
                var element = myList.First(r => r == val);
                myList.Remove(element);
            }

            var sortedList = listTop20.Concat(myList).ToList();
            Console.WriteLine("");
            Console.WriteLine("Printing Sorted List:");
            PrintList(sortedList);
            Console.ReadLine();
        }

        private static void PrintList(List<int> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i] + " ");
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
