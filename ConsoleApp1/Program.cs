using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用迴圈呈現右側結果
            //++++1
            //+++22
            //++333
            //+4444    
            //55555

            for(int i = 1; i <=5; i++)
            {
                int Plus = 5 - i;
                int Number = i;

                string row = new string('+', Plus)+ new string(i.ToString()[0], Number);
                
                Console.WriteLine(row);
            }
        }
    }
}
