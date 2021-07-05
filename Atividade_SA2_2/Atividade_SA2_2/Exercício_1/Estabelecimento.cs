using System.Collections.Generic;

namespace Exercício_1
{
	class Estabelecimento
	{
		public readonly string NomeEstabelecimento;
		public List<Lanche> Lanches = new ();

		public Estabelecimento(string nome, List<Lanche> lanches)
		{
			NomeEstabelecimento = nome;
			
			foreach(Lanche l in lanches)
			{
				Lanches.Add(l);
			}
		}
	}
}
