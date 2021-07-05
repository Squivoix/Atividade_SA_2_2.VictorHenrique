using System;

namespace Exercício_6
{
	class Exercício_6
	{
		public static void MainProgram()
		{
			//Valor em anos a ser convertido para todos os outros.
			const int VALOR_CONVERTER = 5;
			//Variáveis com os valores devidamentes convertidos.
			float Dias = ConversaoDeUnidadesDeTempo.AnoParaDia(VALOR_CONVERTER);
			float Horas = ConversaoDeUnidadesDeTempo.DiaParaHora(Dias);
			float Minutos = ConversaoDeUnidadesDeTempo.HoraParaMinuto(Horas);
			float Segundos = ConversaoDeUnidadesDeTempo.MinutoParaSegundo(Minutos);

			//Escreve a quantia a ser convertida.
			Console.WriteLine($"Valor em anos a ser convertido: {VALOR_CONVERTER}\n");

			//Escreve os valores.
			Console.WriteLine($"Valor em Anos: {VALOR_CONVERTER}");
			Console.WriteLine($"Valor em Dias: {Dias}");
			Console.WriteLine($"Valor em Horas: {Horas}");
			Console.WriteLine($"Valor em Minutos: {Minutos}");
			Console.WriteLine($"Valor em Segundos: {Segundos}");
		}
	}
}
