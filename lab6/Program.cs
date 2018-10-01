using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouqet b = new Bouqet { new Rose("Name", "White", 2100), new Cactus("Cact", "Purple", 1000), new Rose() };
            BouqetController bc = new BouqetController(b);


            BouqetController.Comand find = BouqetController.Comand.FindByColor;
            BouqetController.Comand sort = BouqetController.Comand.SortByParam;

            Bouqet res = bc.ExecuteCommand(find, "Red");
            Printer.Print(res);

            bc.ExecuteCommand(sort, null);
            Printer.Print(b);

            Console.WriteLine("Цена букета: " + bc.TotalPrice().ToString());


            Paper p1 = new Paper("Shit Paper", Paper.Quality.Good);
            Paper p2 = new Paper("Another Shit Paper", Paper.Quality.Bad);
            List<Paper> paperList = new List<Paper> { p1, p2 };

            foreach (var el in paperList)
            {
                Console.WriteLine(el.name);
            }

            Console.WriteLine();
            p2 = p1;
            p1.name = "Not rly shit paper";
            Console.WriteLine(p1.name);
            Console.WriteLine(p2.name);
            Console.WriteLine();

            foreach (var el in paperList)
            {
                Console.WriteLine(el.name);
            }

        }
    }
}
