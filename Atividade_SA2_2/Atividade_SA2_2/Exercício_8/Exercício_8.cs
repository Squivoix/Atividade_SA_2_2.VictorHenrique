using System;

namespace Exercício_8
{
	class Exercício_8
	{
		public static void MainProgram()
		{
			float temp;

			Console.Write("Digite uma temperatura em Celsius: "); while(!float.TryParse(Console.ReadLine(), out temp)) { Console.Write("Por favor, digite um número: "); }

			/* Celsius */
			Console.WriteLine($"\nCelsius para Fahrenheit: {ConversaoDeUnidadesDeTemperatura.CelsiusParaFahrenheit(temp)}");
			Console.WriteLine($"Celsius para Kelvin: {ConversaoDeUnidadesDeTemperatura.CelsiusParaKelvin(temp)}");
			Console.WriteLine($"Celsius para Réamur: {ConversaoDeUnidadesDeTemperatura.CelsiusParaReamur(temp)}");
			Console.WriteLine($"Celsius para Rankine: {ConversaoDeUnidadesDeTemperatura.CelsiusParaRankine(temp)}");

			Console.Write("\nDigite uma temperatura em Fahrenheit: "); while(!float.TryParse(Console.ReadLine(), out temp)) { Console.Write("Por favor, digite um número: "); }

			/* Fahrenheit */
			Console.WriteLine($"\nFahrenheit para Celsius: {ConversaoDeUnidadesDeTemperatura.FahrenheitParaCelsius(temp)}");
			Console.WriteLine($"Fahrenheit para Kelvin: {ConversaoDeUnidadesDeTemperatura.FahrenheitParaKelvin(temp)}");
			Console.WriteLine($"Fahrenheit para Réamur: {ConversaoDeUnidadesDeTemperatura.FahrenheitParaReamur(temp)}");
			Console.WriteLine($"Fahrenheit para Rankine: {ConversaoDeUnidadesDeTemperatura.FahrenheitParaRankine(temp)}");

			Console.Write("\nDigite uma temperatura em Kelvin: "); while(!float.TryParse(Console.ReadLine(), out temp)) { Console.Write("Por favor, digite um número: "); }

			/* Kelvin */
			Console.WriteLine($"\nKelvin para Celsius: {ConversaoDeUnidadesDeTemperatura.KelvinParaCelsius(temp)}");
			Console.WriteLine($"Kelvin para Fahrenheit: {ConversaoDeUnidadesDeTemperatura.KelvinParaFahrenheit(temp)}");
			Console.WriteLine($"Kelvin para Réamur: {ConversaoDeUnidadesDeTemperatura.KelvinParaReamur(temp)}");
			Console.WriteLine($"Kelvin para Rankine: {ConversaoDeUnidadesDeTemperatura.KelvinParaRankine(temp)}");

			Console.Write("\nDigite uma temperatura em Réamur: "); while(!float.TryParse(Console.ReadLine(), out temp)) { Console.Write("Por favor, digite um número: "); }

			/* Réamur */
			Console.WriteLine($"\nRéamur para Celsius: {ConversaoDeUnidadesDeTemperatura.ReamurParaCelsius(temp)}");
			Console.WriteLine($"Réamur para Fahrenheit: {ConversaoDeUnidadesDeTemperatura.ReamurParaFahrenheit(temp)}");
			Console.WriteLine($"Réamur para Kelvin: {ConversaoDeUnidadesDeTemperatura.ReamurParaKelvin(temp)}");
			Console.WriteLine($"Réamur para Rankine: {ConversaoDeUnidadesDeTemperatura.ReamurParaRankine(temp)}");

			Console.Write("\nDigite uma temperatura em Rankine: "); while(!float.TryParse(Console.ReadLine(), out temp)) { Console.Write("Por favor, digite um número: "); }

			/* Rankine */
			Console.WriteLine($"\nRankine para Celsius: {ConversaoDeUnidadesDeTemperatura.RankineParaCelsius(temp)}");
			Console.WriteLine($"Rankine para Fahrenheit: {ConversaoDeUnidadesDeTemperatura.RankineParaFahrenheit(temp)}");
			Console.WriteLine($"Rankine para Kelvin: {ConversaoDeUnidadesDeTemperatura.RankineParaKelvin(temp)}");
			Console.WriteLine($"Rankine para Réamur: {ConversaoDeUnidadesDeTemperatura.RankineParaReamur(temp)}");

		}
	}
}
