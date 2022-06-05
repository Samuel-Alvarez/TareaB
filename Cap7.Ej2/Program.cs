using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7.Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable palabras = new Hashtable();
            palabras.Add("abandonar", "Dejar solo, sin atención, sin cuidados a una persona, un animal o una cosa.");
            palabras.Add("abanico", "Objeto que sirve para dar aire.");
            palabras.Add("abeto", "Árbol de tronco alto y recto. La copa tiene forma de cono y su fruto son las piñas. ");
            palabras.Add("caño", "Tubo por donde sale al exterior un chorro de un líquido.");

            foreach (DictionaryEntry datos in palabras)
                Console.WriteLine(datos.Key + ":\t" + datos.Value);
        }

    }
}
