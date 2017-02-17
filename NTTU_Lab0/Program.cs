using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTTU_Lab0
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"0001_gs.xml"))
            {
                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach (var ch in line)
                    {
                        Console.Write(ch);
                    }
                }
            }
            Console.Read();
        }
    }
}
