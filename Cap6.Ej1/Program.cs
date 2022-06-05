
namespace Cap6.Ej1
{
    class Program
    {
     static void Main(string[] args)
        {

            int cantidad = 0;
            int salones = 0; 
            int n = 0; 
            int m = 0; 
            string valor = "";
               
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f; 

            Console.WriteLine("Dame la cantidad de salones:");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);
            Console.WriteLine("Dame la cantidad de alumnos por salon:");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            float[,] calif = new float[salones, cantidad];
  
                for (n = 0; n < salones; n++) 
            {
                    Console.WriteLine("Salon {0}:", n);
                for (m = 0; m < cantidad; m++)
                {
                    Console.Write("Dame la calificación: ");
                    valor = Console.ReadLine();
                    calif[n, m] = Convert.ToSingle(valor);
                }
            }

                for (n = 0; n < salones; n++)
                {
                for (m = 0; m < cantidad; m++) 
                {
                    suma += calif[n, m];
                }
                }
                promedio = suma / (cantidad * salones);

            Console.WriteLine("El promedio es: {0}", promedio);
            
        }
 
    }
}


