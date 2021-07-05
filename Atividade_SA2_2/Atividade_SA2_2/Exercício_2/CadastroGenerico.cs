using System;
using System.Collections.Generic;

namespace Exercício_2
{
	class CadastroGenerico
	{
		public readonly List<Pessoa> Pessoas = new();
		public int NumeroElementos
		{
			get
			{
				return Pessoas.Count;
			}
		}

		/// <summary>
		/// Incluir uma Pessoa na Lista de Pessoas.
		/// </summary>
		/// <param name="p">A pessoa a ser incluída.</param>
		public virtual void	Incluir(Pessoa p)
		{
			Pessoas.Add(p);
			Console.WriteLine($"{p.Nome} foi incluído(a) com sucesso");
		}

		/// <summary>
		/// Excluir uma Pessoa da Lista pelo id.
		/// </summary>
		/// <param name="id">O id da pessoa a ser excluída.</param>
		public void Excluir(int id)
		{
			Pessoa p = Buscar(id);

			if(p != null) 
			{
				Pessoas.Remove(p);
				Console.WriteLine($"{p.Nome} foi excluído(a) com sucesso");
			}
		}

		/// <summary>
		/// Excluir uma Pessoa da Lista.
		/// </summary>
		/// <param name="p">A Pessoa a ser excluída.</param>
		public void Excluir(Pessoa p)
		{
			Pessoa pTemp = Buscar(p);

			if(p != null) 
			{
				Pessoas.Remove(pTemp);
				Console.WriteLine($"{p.Nome} foi excluído(a) com sucesso"); 
			}
		}

		/// <summary>
		/// Buscar uma Pessoa na Lista.
		/// </summary>
		/// <param name="id">A Pessoa a ser procurada.</param>
		/// <returns></returns>
		public Pessoa Buscar(Pessoa p)
		{
			if(Pessoas.Contains(p))
			{
				return p;
			}

			Console.WriteLine("Pessoa não encontrada");
			return null;

		}

		/// <summary>
		/// Buscar uma Pessoa na Lista pelo id.
		/// </summary>
		/// <param name="id">O id da Pessoa a ser procurada.</param>
		/// <returns></returns>
		public Pessoa Buscar(int id)
		{
			Pessoa p = Pessoas.Find(x => x.Id == id);

			if(p != null)
			{
				return p;
			}

			Console.WriteLine("Pessoa não encontrada");
			return null;
		}

	}
}
