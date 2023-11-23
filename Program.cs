using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fpath = "C:\\Users\\alish\\Desktop\\Mphasis\\Student TextFile\\student.txt";

                string[] lines = File.ReadAllLines(fpath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
