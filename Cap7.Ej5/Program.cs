using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7.Ej5
{

    class Program
    {
        static void Main(string[] args)
        {
            Hashtable agenda = new Hashtable();
            string nombre, numero;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite . para terminar");

                Console.WriteLine("Digite el nombre");
                nombre = Console.ReadLine();
                if (nombre == ".")
                    break;
                Console.WriteLine("Digite el numero");
                numero = Console.ReadLine();
                if (numero == ".")
                    break;

                agenda.Add(nombre, numero);
            } while(nombre != "." && numero != ".");

            Console.Clear();
            Console.WriteLine("Agenda: \n");

            foreach (DictionaryEntry datos in agenda)
                Console.WriteLine(datos.Key + "  -  " + datos.Value);

        }

    }
}
