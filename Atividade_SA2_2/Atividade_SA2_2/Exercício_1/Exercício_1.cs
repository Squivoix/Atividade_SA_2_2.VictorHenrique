using System;
using System.Collections.Generic;

namespace Exercício_1
{
	class Exercício_1
	{
		public static void MainProgram()
		{
			//Criação dos Lanches e Restaurantes
			#region Lanches
			//Criação de todos os lanches do Brasil.
			List<Lanche> lanchesBrasil = new () {
				new ("NecFeijoada", "Um Nec feito com a melhor feijoada", 19.99f),
				new ("NecBacon", "Um Nec feito com o melhor bacon", 23.99f),
				new ("NecAcarajé", "O melhor acarajé do mundo", 15.99f),
				new ("NecPicanha", "Um Nec feito com a melhor picanha já feita", 34.99f)
			};

			//Criação de todos os lanches da Argentina.
			List<Lanche> lanchesArgentina = new () {
				new ("NecPicanha", "Um Nec feito com a segunda melhor feijoada", 24.99f),
				new ("NecChimichurri", "O melhor chimichurri", 9.99f)
			};

			//Criação de todos os lanches dos Estados Unidos.
			List<Lanche> lanchesEstadosUnidos = new () {
				new ("NecBacon", "Um Nec feito com o melhor bacon", 5.99f),
				new ("NecCheddar", "O melhor cheddar do mundo", 4.99f)
			};

			//Criação de todos os lanches do Japão.
			List<Lanche> lanchesJapao = new () {
				new ("NecSushi", "Um Nec feito com o melhor sushi", 4000.00f),
				new ("NecCheddar", "O segundo melhor cheddar do mundo", 5000.00f)
			};
			#endregion

			#region Restaurantes
			//Criação do Restaurante do Brasil, e de vários Estabelecimentos, cada um com o mesmo cardápio.
			Restaurante Brasil = new Restaurante("Brasil", new List<Estabelecimento>() { 
				new Estabelecimento("NecBurguer Manaus", lanchesBrasil),
				new Estabelecimento("NecBurguer São Paulo", lanchesBrasil),
				new Estabelecimento("NecBurguer Rio de Janeiro", lanchesBrasil),
				new Estabelecimento("NecBurguer Paraná", lanchesBrasil)
			});

			//Criação do Restaurante da Argentina, e de vários Estabelecimentos, cada um com o mesmo cardápio.
			Restaurante Argentina = new Restaurante("Argentina", new List<Estabelecimento>() { 
				new Estabelecimento("NecBurguer Buenos Aires", lanchesArgentina),
				new Estabelecimento("NecBurguer Mendonza", lanchesArgentina),
				new Estabelecimento("NecBurguer Bariloche", lanchesArgentina),
				new Estabelecimento("NecBurguer Ushuaia", lanchesArgentina)
			});

			//Criação do Restaurante dos Estados Unidos, e de vários Estabelecimentos, cada um com o mesmo cardápio.
			Restaurante EstadosUnidos = new Restaurante("Estados Unidos", new List<Estabelecimento>() { 
				new Estabelecimento("NecBurguer Michigan", lanchesEstadosUnidos),
				new Estabelecimento("NecBurguer Nova York", lanchesEstadosUnidos),
				new Estabelecimento("NecBurguer California", lanchesEstadosUnidos),
				new Estabelecimento("NecBurguer Washington", lanchesEstadosUnidos)
			});

			//Criação do Restaurante do Japão, e de vários Estabelecimentos, cada um com o mesmo cardápio.
			Restaurante Japao = new Restaurante("Japão", new List<Estabelecimento>() { 
				new Estabelecimento("NecBurguer Tokyo", lanchesJapao),
				new Estabelecimento("NecBurguer Quioto", lanchesJapao),
				new Estabelecimento("NecBurguer Fukuoka", lanchesJapao),
				new Estabelecimento("NecBurguer Osaka", lanchesJapao)
			});
			#endregion

			//Começo do programa
			int codigo;

			//Escreve os comandos.
			Console.WriteLine("Comandos:\n" +
					"1 - Mostrar cardápio.\n" +
					"2 - Mostrar todos os cardápios.\n" +
					"3 - Adicionar item ao cardápio.\n" +
					"4 - Remover item do cardápio.\n" +
					"5 - Reescrever comandos.\n" +
					"9 - Sair.");

			//Entra em um loop.
			do
			{
				//Pede para escrever o código
				Console.Write("\nDigite o código: ");
				//Enquanto não for escrito um número, uma mensagem de erro aparece
				while(!int.TryParse(Console.ReadLine(), out codigo)) { Console.Write("Por favor, insira um número: "); }

				//Dependendo do código que foi inserido, entra em algum comando
				switch(codigo)
				{
					case 1: //Mostrar cardápio de um país
					{
						int cod;
						Console.Write("\nEscolha o país que quer ver o cardápio:\n" +
							"1 - Brasil.\n" +
							"2 - Argentina.\n" +
							"3 - Estados Unidos.\n" +
							"4 - Japao.\n" +
							"Digite o número: ");

						while(!int.TryParse(Console.ReadLine(), out cod)) { Console.Write("Por favor, insira um número: "); }

						if(cod == 1)
						{
							Brasil.MostrarCardapio();
						} else if(cod == 2)
						{
							Argentina.MostrarCardapio();
						} else if(cod == 3)
						{
							EstadosUnidos.MostrarCardapio();
						} else if(cod == 4)
						{
							Japao.MostrarCardapio();
						} else
						{
							Console.WriteLine("\nCódigo não existe");
						}

						break;
					}

					case 2: //Mostrar todos os cardápios
					{
						Console.WriteLine("\n*** Brasil ***");
						Brasil.MostrarCardapio();
						Console.WriteLine("\n*** Argentina ***");
						Argentina.MostrarCardapio();
						Console.WriteLine("\n*** Estados Unidos ***");
						EstadosUnidos.MostrarCardapio();
						Console.WriteLine("\n*** Japão ***");
						Japao.MostrarCardapio();
						break;
					}

					case 3: //Adicionar item ao cardápio
					{
						int cod;
						float preco;

						Console.Write("\nDigite o nome do lanche: ");
						string nome = Console.ReadLine();

						Console.Write("Digite a descrição do lanche: ");
						string descricao = Console.ReadLine();

						Console.Write("Digite o preço do lanche: ");
						while(!float.TryParse(Console.ReadLine(), out preco)) { Console.Write("Por favor, insira um número: "); }

						Console.Write($"\nAgora escolha o país que quer adicionar {nome} ao cardápio:\n" +
							"1 - Brasil.\n" +
							"2 - Argentina.\n" +
							"3 - Estados Unidos.\n" +
							"4 - Japao.\n" +
							"Digite o número: ");

						while(!int.TryParse(Console.ReadLine(), out cod)) { Console.Write("Por favor, insira um número: "); }

						if(cod == 1)
						{
							Brasil.AdicionarItem(nome, descricao, preco);
						} else if(cod == 2)
						{
							Argentina.AdicionarItem(nome, descricao, preco);
						} else if(cod == 3)
						{
							EstadosUnidos.AdicionarItem(nome, descricao, preco);
						} else if(cod == 4)
						{
							Japao.AdicionarItem(nome, descricao, preco);
						} else
						{
							Console.WriteLine("\nCódigo não existe");
						}
						break;
					}

					case 4: //Remover item do cardápio
					{
						int cod;
						Console.Write("\nEscolha o país que quer remover o lanche do cardápio:\n" +
							"1 - Brasil.\n" +
							"2 - Argentina.\n" +
							"3 - Estados Unidos.\n" +
							"4 - Japao.\n" +
							"Digite o número: ");

						while(!int.TryParse(Console.ReadLine(), out cod)) { Console.Write("Por favor, insira um número: "); }

						if(cod > 4 || cod < 1) { Console.WriteLine("\nCódigo não existe"); break; }
							
						Console.Write("\nDigite o nome do lanche: "); string nome = Console.ReadLine();

						if(cod == 1) //Brasil
						{
							Brasil.RemoverItem(nome);
						} else if(cod == 2) //Argentina
						{
							Argentina.RemoverItem(nome);
						} else if(cod == 3) //Estados Unidos
						{
							EstadosUnidos.RemoverItem(nome);
						} else if(cod == 4) //Japão
						{
							Japao.RemoverItem(nome);
						}

						break;
					}

					case 5: //Reescrever os comandos
					{
						//Reescreve os comandos.
						Console.WriteLine("Comandos:\n" +
								"1 - Mostrar cardápio.\n" +
								"2 - Mostrar todos os cardápios.\n" +
								"3 - Adicionar item ao cardápio.\n" +
								"4 - Remover item do cardápio.\n" +
								"5 - Reescrever comandos.\n" +
								"9 - Sair.");
						break;
					}

					default:
					{
						Console.WriteLine("Código não existe");
						break;
					}
				}

			} while(codigo != 9);
		}



	}
}
