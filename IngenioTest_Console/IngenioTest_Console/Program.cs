using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenioTest_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot r1 = new Robot("IngenioRobot");

            Chip sChip = new SortofChips("Sort of Chips");
            Chip tChip = new TotalofChips("Total of Chips");


            int[] s = new int[] { 1, 2, 3, 4, 5 };
            int[] result;


            r1.InstallChip(sChip);
            result = r1.ExecuteChip(s);
            foreach (var i in result)
                Console.Write(i + " ");
            Console.WriteLine("");

            r1.InstallChip(tChip);
            result = r1.ExecuteChip(s);
            foreach (var i in result)
                Console.Write(i + " ");
            Console.WriteLine("");

            Console.ReadLine();

        }
    }
}
