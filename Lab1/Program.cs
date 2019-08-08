using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable declaration
            string strPlayerName;
            double nhits, nAtBat;
            double dblBayyingAverage;

            Console.WriteLine("This program calculate a baseball playet average..");
            Console.WriteLine("----------------------->");
            Console.WriteLine(" ");

            Console.WriteLine("Enter the Players name:   ");
            strPlayerName = Console.ReadLine();

            // prompt for hits, walk and at bats
            Console.WriteLine("Enter the Players hits:   ");
            nhits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Players  # of at bats:   ");
            nAtBat = Convert.ToInt32(Console.ReadLine());


            // calculating 
            dblBayyingAverage = nhits % nAtBat;
            Console.WriteLine(strPlayerName + "'S batting average is " + dblBayyingAverage);
            Console.ReadLine();


            Console.WriteLine("My Dog Gadget is " + 5 + 5 + " years old");
           
            Console.ReadLine();

            Console.WriteLine("My Dog Gadget is {0} years old.", 5 + 5);
            Console.WriteLine("I paid {0:c} for her.", 20);

        }

    } 
}

