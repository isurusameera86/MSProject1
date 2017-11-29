using System;
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
            Console.WriteLine("hello world......!!!" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"));

            string path = @"test.txt";

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine("The very first line!" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"));
                    tw.Close();
                }

            }

            else if (File.Exists(path))
            {
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine("The next line .....!" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"));
                    tw.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
