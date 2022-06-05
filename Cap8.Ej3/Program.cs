using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap8.Ej3
{

    class Program
    {
        static void Main(string[] args)
        {
            String formato;

            formato = String.Format("La hora y fecha es: {0:hh tt yyyy dd M}", DateTime.Now);
            Console.WriteLine(formato);
        }

    }
}
