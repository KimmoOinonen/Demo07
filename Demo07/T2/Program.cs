/*
 * Copyright (C) Kimmo Oinonen
 *
 * This file is part of homework project in Object-Oriented
 * and GUI Programming class in JAMK.
 *
 * Created: 2.2.2016
 * Author: Kimmo Oinonen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"c:\VisualStudioOhjelmointi\int.txt");
            System.IO.StreamWriter outputFile2 = new System.IO.StreamWriter(@"c:\VisualStudioOhjelmointi\double.txt");
            int num;
            double num1;
            do
            {
                Console.WriteLine("Give a number (enter or not a number ends): ");
                string line = Console.ReadLine();
                bool success = int.TryParse(line, out num);
                if (success)
                {
                    outputFile.WriteLine(num);
                }
                else
                {
                    double.TryParse(line, out num1);
                    /*if (success1)
                    {*/
                        outputFile2.WriteLine(num1);
                    /*} else
                    {
                        Console.WriteLine("You didn't gave any number!!!");
                    }*/
                }
                
            } while (num != 0);

            outputFile.Close();

            try
            {
                string intnums = System.IO.File.ReadAllText(@"c:\VisualStudioOhjelmointi\int.txt");
                Console.WriteLine("Integers: ");
                Console.WriteLine(intnums);

                string dnums = System.IO.File.ReadAllText(@"c:\VisualStudioOhjelmointi\double.txt");
                Console.WriteLine("Doubles: ");
                Console.WriteLine(dnums);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found!!!");
            }
        }
    }
}
