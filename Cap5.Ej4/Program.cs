
namespace Cap5.Ej4
{
	class Program
	{
		static void Main(string[] args)
		{
			byte num, i;
			long result = 1;
			string linea;
			Console.Write("Introduce un numero: ");
			linea = Console.ReadLine();
			num = byte.Parse(linea);
			for (i = 2; i <= num; i++)
			{
				result = result * i;
			}
			Console.WriteLine("El factorial de {0} es: {1}",num,result);
 
			Console.Write("Pulse una Tecla ");
			Console.ReadLine();
		}
	}
}
