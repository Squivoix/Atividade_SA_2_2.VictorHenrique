using System;

namespace Exercício_2
{
	abstract class Pessoa : IPessoa
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public DateTime DataNascimento { get; set; }

		public Pessoa(int Id, string Nome, DateTime DataNascimento)
		{
			this.Id = Id;
			this.Nome = Nome;
			this.DataNascimento = DataNascimento;
		}
	}
}
