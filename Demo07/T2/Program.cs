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
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"d:\K1744\Demo07\Demo07\T1\bin\Debug\text.txt");
            do
            {
                Console.WriteLine("Give a number (enter or not a number ends): ");
                string line = Console.ReadLine();
                int num;
                outputFile.WriteLine(text);
            } while (text.Length != 0);

            outputFile.Close();

            try
            {
                string alltext = System.IO.File.ReadAllText(@"d:\K1744\Demo07\Demo07\T1\bin\Debug\text.txt");
                Console.WriteLine(alltext);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found!!!");
            }
        }
    }
}
