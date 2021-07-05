using System;

namespace Exercício_2
{
	/// <summary>
	/// Cadastro dos Alunos.
	/// </summary>
	class CadastroAluno : CadastroGenerico
	{
		public string Curso { get; set; }

		public override void Incluir(Pessoa p)
		{
			if(p is Aluno)
			{
				base.Incluir(p);
			} else
			{
				Console.WriteLine("Apenas é possível incluir Alunos!");
			}
		}
	}
}
