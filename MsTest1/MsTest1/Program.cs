﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world...!!!");

            string path = @"test.txt";

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine("The very first line!");
                    tw.Close();
                }

            }

            else if (File.Exists(path))
            {
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine("The next line!");
                    tw.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
