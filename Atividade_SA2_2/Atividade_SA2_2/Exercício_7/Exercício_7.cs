using System;

namespace Exercício_7
{
	class Exercício_7
	{
		public static void MainProgram()
		{
			//Tempo de gestação de um elefante indiano em dias.
			const float GESTACAO = 624f;
			//Faz as conversões.
			float Horas = Exercício_6.ConversaoDeUnidadesDeTempo.DiaParaHora(GESTACAO);
			float Minutos = Exercício_6.ConversaoDeUnidadesDeTempo.DiaParaHora(Horas);
			float Segundos = Exercício_6.ConversaoDeUnidadesDeTempo.DiaParaHora(Minutos);

			//Escreve o título.
			Console.WriteLine("Gestação de um elefante indiano.\n");

			//Escreve os valores.
			Console.WriteLine($"Dias: {GESTACAO}");
			Console.WriteLine($"Horas: {Horas}");
			Console.WriteLine($"Minutos: {Minutos}");
			Console.WriteLine($"Segundos: {Segundos}");
		}
	}
}
