
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap6.Eje5
{
    class Program
    {
        static void Main(string[] args){}
        public void paso(int[][] jagged)
        {
            for (int n = 0; n < jagged.Length; n++)
            {
                for (int m = 0; m < jagged[n].GetLength(0); m++)
                {
                    Console.WriteLine(jagged[n][m]);
                }
                
            }
        }
    }
}
