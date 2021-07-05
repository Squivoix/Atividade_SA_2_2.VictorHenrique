using System;

namespace Exercício_5
{
	class Exercício_5
	{
		public static void MainProgram()
		{
			//Cria uma constante com o volume da piscina e escreve o volume.
			const float VOLUME = 1890f;
			Console.WriteLine($"O volume da piscina é {VOLUME} metros cúbicos.\n");

			//Converte de metros cúbicos para Litros. Utilizando o Exercício_4.
			Console.WriteLine($"O volume da piscina em Litros é: {Exercício_4.ConversaoDeUnidadesDeVolume.Litros(VOLUME)}L.");

			//Converte de metros cúbicos para Pés Cúbicos. Utilizando o Exercício_4.
			Console.WriteLine($"O volume da piscina em Pés Cúbicos é: {Exercício_4.ConversaoDeUnidadesDeVolume.PesCubicos(VOLUME)}ft³.");

			//Converte de metros cúbicos para Centimetros Cúbicos. Utilizando o Exercício_4.
			Console.WriteLine($"O volume da piscina em Centimentros Cúbicos é: " +
				$"{Exercício_4.ConversaoDeUnidadesDeVolume.CentimetrosCubicos(Exercício_4.ConversaoDeUnidadesDeVolume.Litros(VOLUME))}cm³.");
		}
	}
}
