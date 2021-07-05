using System;

namespace Exercício_2
{
	/// <summary>
	/// Uma classe Aluno.
	/// </summary>
	class Aluno : Pessoa
	{
		private static int Matricula = 0;
		public string Curso { get; set; }

		/// <summary>
		/// Construtor de Aluno.
		/// </summary>
		/// <param name="Nome">O nome do Aluno.</param>
		/// <param name="Curso">O Curso do Aluno.</param>
		/// <param name="DataNascimento">A data de nascimento do Aluno.</param>
		public Aluno(string Nome, string Curso, DateTime DataNascimento) : base (Matricula, Nome, DataNascimento)
		{
			this.Curso = Curso;
			Matricula++;
		}
	}
}
