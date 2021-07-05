using System;

namespace Exercício_4
{
	public class Exercício_4
	{
		public static void MainProgram()
		{
			float v1;
			double v2;

			Console.WriteLine("Litros para Centímetros Cúbicos\n");
			Console.Write("Digite o valor em Litros: "); while(!float.TryParse(Console.ReadLine(), out v1)) { Console.WriteLine("Por favor, digite um número: "); }
			Console.WriteLine($"O valor em Centímetros Cúbicos é {ConversaoDeUnidadesDeVolume.CentimetrosCubicos(v1)}\n");
			
			Console.WriteLine("\nMetros Cúbicos para Litros\n");
			Console.Write("Digite o valor em Metros Cúbicos: "); while(!float.TryParse(Console.ReadLine(), out v1)) { Console.WriteLine("Por favor, digite um número: "); }
			Console.WriteLine($"O valor em Litros é {ConversaoDeUnidadesDeVolume.Litros(v1)}\n");
			
			Console.WriteLine("\nMetros Cúbicos para Pés Cúbicos\n");
			Console.Write("Digite o valor em : "); while(!float.TryParse(Console.ReadLine(), out v1)) { Console.WriteLine("Por favor, digite um número: "); }
			Console.WriteLine($"O valor em Pés Cúbicos é {ConversaoDeUnidadesDeVolume.PesCubicos(v1)}\n");
			
			Console.WriteLine("\nGalão Americano para Polegadas Cúbicas\n");
			Console.Write("Digite o valor em Galão Americano: "); while(!float.TryParse(Console.ReadLine(), out v1)) { Console.WriteLine("Por favor, digite um número: "); }
			Console.WriteLine($"O valor em Polegadas Cúbicas é {ConversaoDeUnidadesDeVolume.PolegadasCubicas(v1)}\n");
			
			Console.WriteLine("\nGalão Americano para Litros\n");
			Console.Write("Digite o valor em Galão Americano: "); while(!double.TryParse(Console.ReadLine(), out v2)) { Console.WriteLine("Por favor, digite um número: "); }
			Console.WriteLine($"O valor em Litros é {ConversaoDeUnidadesDeVolume.Litros(v2)}");
			
		}
	}
}

