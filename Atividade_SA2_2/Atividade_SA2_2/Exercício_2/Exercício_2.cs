using System;

namespace Exercício_2
{
	class Exercício_2
	{
		public static void MainProgram()
		{
			//Cria três Alunos e o Cadastro de Alunos.
			Aluno a1 = new("Victor", "Desenvolvimento de Sistemas", new DateTime(2001, 04, 04));
			Aluno a2 = new("Amanda", "Desenvolvimento de Sistemas", new DateTime(2002, 12, 13));
			Aluno a3 = new("Roberto", "Análise de Sistemas", new DateTime(1999, 05, 25));
			Aluno a4 = new("Fernada", "Análise de Sistemas", new DateTime(2003, 01, 16));

			CadastroAluno c = new();

			//Não é possível criar uma instância de uma classe abstrata.
			//Pessoa p = new();

			//Inclui os Alunos criados no Cadastro de Alunos.
			c.Incluir(a1);
			c.Incluir(a2);
			c.Incluir(a3);
			c.Incluir(a4);

			//Escreve quantos Elementos estão no Cadastro de Alunos, e então os atributos de cada um.
			Console.WriteLine($"\nNúmero Elementos: {c.NumeroElementos}\n");
			foreach(Aluno a in c.Pessoas)
			{
				Console.WriteLine($"Id: {a.Id} || Nome: {a.Nome} || Curso: {a.Curso} || Data de Nascimento: {a.DataNascimento.ToShortDateString()}");
			}

			//Exclui o Aluno pelo id.
			c.Excluir(0);

			//Exclui o Aluno por ele mesmo.
			c.Excluir(a2);

			//Escreve quantos Elementos restantes estão no Cadastro de Alunos, e então os atributos de cada um.
			Console.WriteLine($"\nNúmero Elementos: {c.NumeroElementos}\n");
			foreach(Aluno a in c.Pessoas)
			{
				Console.WriteLine($"Id: {a.Id} || Nome: {a.Nome} || Curso: {a.Curso} || Data de Nascimento: {a.DataNascimento.ToShortDateString()}");
			}
		}
	}
}
