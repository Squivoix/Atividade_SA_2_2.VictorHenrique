using System;

namespace Exercício_3
{
	public class Exercício_3
	{
		public static void MainProgram()
		{
			//Cria todas as variáveis que serão usadas.
			float n1, n1Resposta, n2, a, b, c, catAdj, catOpo, bMenor, bMaior, h;
			float[] r;

			//Utilizando n1, n1Resposta e n2. Pede para escrever os números, e então chama a função RegraDeTres.
			Console.WriteLine("Regra de três\n");
			
			Console.Write("Digite o primeiro valor: "); while(!float.TryParse(Console.ReadLine(), out n1)) { Console.Write("Por favor, digite um número: "); };
			Console.Write("Digite o resultado do primeiro valor: "); while(!float.TryParse(Console.ReadLine(), out n1Resposta)) { Console.Write("Por favor, digite um número: "); };
			Console.Write("Digite o segundo valor: "); while(!float.TryParse(Console.ReadLine(), out n2)) { Console.Write("Por favor, digite um número: "); };
			Console.Write($"A resposta da regra de três é: {Matematica.RegraDeTres(n1, n1Resposta, n2)}\n");

			//Utilizando a, b, c e r. Pede para escrever os números, e então chama a função Bhaskara.
			Console.WriteLine("\nBhaskara\n");

			Console.Write("Digite o valor de a: "); while(!float.TryParse(Console.ReadLine(), out a)) { Console.Write("Por favor, digite um número: "); };
			Console.Write("Digite o valor de b: "); while(!float.TryParse(Console.ReadLine(), out b)) { Console.Write("Por favor, digite um número: "); };
			Console.Write("Digite o valor de c: "); while(!float.TryParse(Console.ReadLine(), out c)) { Console.Write("Por favor, digite um número: "); };

			r = Matematica.Bhaskara(a, b, c);

			if(float.IsNaN(r[0]))
			{
				Console.Write("A raiz é um número Complexo!\n");
			} else
			{
				Console.Write($"A primeira raiz de bhaskara é: {r[0]}\n");
				Console.Write($"A segunda raiz de bhaskara é: {r[1]}\n");
			}

			//Utilizando catAdj e catOpo. Pede para escrever os números, e então chama a função Hipotenusa.
			Console.WriteLine("\nHipotenusa\n");

			Console.Write("Digite o valor do cateto adjacente: "); while(!float.TryParse(Console.ReadLine(), out catAdj)) { Console.Write("Por favor, digite um número: "); };
			Console.Write("Digite o valor do cateto oposto: "); while(!float.TryParse(Console.ReadLine(), out catOpo)) { Console.Write("Por favor, digite um número: "); };
			Console.Write($"A resposta da hipotenusa é: {Matematica.Hipotenusa(catAdj, catOpo)}\n");

			////Utilizando bMenor, bMaior e h. Pede para escrever os números, e então chama a função AreaTrapezio.
			Console.WriteLine("\nÁrea do trapézio\n");

			Console.Write("Digite o valor da base menor: "); while(!float.TryParse(Console.ReadLine(), out bMenor)) { Console.Write("Por favor, digite um número: "); };
			Console.Write("Digite o valor da base maior: "); while(!float.TryParse(Console.ReadLine(), out bMaior)) { Console.Write("Por favor, digite um número: "); };
			Console.Write("Digite o valor da altura: "); while(!float.TryParse(Console.ReadLine(), out h)) { Console.Write("Por favor, digite um número: "); };
			Console.Write($"A resposta da área do trapézio é: {Matematica.AreaTrapezio(bMenor, bMaior, h)}\n");
		}
	}
}

