using System;

namespace WhatKindOfTriangle {

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers?");
            string sideAAsString = Console.ReadLine();
            string sideBAsString = Console.ReadLine();
            string sideCAsString = Console.ReadLine();

            int sideA = int.Parse(sideAAsString);
            int sideB = int.Parse(sideBAsString);
            int sideC = int.Parse(sideCAsString);

            Triangle thisTriangle = new Triangle(sideA, sideB, sideC);

            bool isThisATriangle = thisTriangle.IsTriangle();

            if (isThisATriangle)
            {
                string whatKindOfTriangle = thisTriangle.WhatKindOfTriangle();
                Console.WriteLine(whatKindOfTriangle);
            }
            else
            {
                Console.WriteLine("No.");
            }





        }
    }
}
