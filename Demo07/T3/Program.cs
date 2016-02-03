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

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"c:\VisualStudioOhjelmointi\tv.txt");

            TV tv1 = new TV { ShowName = "Uutiset", Channel = "Yle TV1", StartTime = "20.30", EndTime = "20.50", Info = "Illan uutislähetys" };
            outputFile.WriteLine(tv1);

            TV tv2 = new TV { ShowName = "Kymmenen uutiset", Channel = "MTV3", StartTime = "22.00", EndTime = "22.20", Info = "Illan pääuutislähetys" };
            outputFile.WriteLine(tv2);

            TV tv3 = new TV { ShowName = "Urheilua", Channel = "Yle TV2", StartTime = "14.30", EndTime = "16.50", Info = "Urheilua suorana lähetyksenä" };
            outputFile.WriteLine(tv3);

            outputFile.Close();

            try
            {
                string tvshows = System.IO.File.ReadAllText(@"c:\VisualStudioOhjelmointi\tv.txt");
                Console.WriteLine(tvshows);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found!!!");
            }
        }
    }
}
