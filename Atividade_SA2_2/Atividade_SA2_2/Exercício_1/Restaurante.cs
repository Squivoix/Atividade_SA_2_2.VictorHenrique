using System;
using System.Collections.Generic;

namespace Exercício_1
{
	class Restaurante
	{
		public readonly List<Estabelecimento> Estabelecimentos;
		public readonly string NomeRestaurante;

		public Restaurante(string nome, List<Estabelecimento> estabelecimentos)
		{
			NomeRestaurante = nome;
			Estabelecimentos = estabelecimentos;
		}

		#region Métodos
		public void MostrarCardapio()
		{
			//Mostrar nome pais, estabelecimentos e os lanches.
			Console.WriteLine($"\nRestaurante: {NomeRestaurante}");
			Console.WriteLine("\nEstabelecimentos:");

			foreach(Estabelecimento est in Estabelecimentos)
			{
				Console.WriteLine($"- {est.NomeEstabelecimento}.");
			}

			Console.WriteLine("\nCardápio:");

			foreach(Lanche lanche in Estabelecimentos[0].Lanches)
			{
				Console.WriteLine($"\nNome: {lanche.Nome}\nDescrição: {lanche.Descricao}\nPreço: R${lanche.Preco}");
			}
		}

		public void AdicionarItem(string nome, string descricao, float preco)
		{
			//Adicionar um novo item no cardápio de cada estabelecimento.
			Lanche lancheTemp = BuscarLanche(nome);

			if(lancheTemp == null)
			{
				for(int i = 0; i < Estabelecimentos.Count; i++)
				{
					Estabelecimentos[i].Lanches.Add(new Lanche(nome, descricao, preco));
				}

				Console.WriteLine($"O Lanche {nome} foi adicionado com sucesso ao Restaurante {NomeRestaurante}!");
			} else
			{
				Console.WriteLine($"O lanche {nome} já existe no cardápio");
			}
		}

		public void RemoverItem(string nome)
		{
			//Remove item do carápio de cada estabelecimento
			Lanche lancheTemp = BuscarLanche(nome);

			if(lancheTemp != null)
			{
				for(int i = 0; i < Estabelecimentos.Count; i++)
				{
					Estabelecimentos[i].Lanches.Remove(lancheTemp);
				}

				Console.WriteLine($"O Lanche {nome} foi removido de {NomeRestaurante} com sucesso!");
			} else
			{
				Console.WriteLine($"Não foi possível encontrar o lanche {nome}");
			}
		}

		private Lanche BuscarLanche(string nome)
		{
			return Estabelecimentos[0].Lanches.Find(x => x.Nome == nome);
		}
		#endregion
	}
}
