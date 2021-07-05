using System;

namespace Exercício_3
{
	/// <summary>
	/// Classe utilizada para fazer cálculos matemáticos.
	/// </summary>
	public static class Matematica
	{
		/// <summary>
		/// Método para calcular usando regra de três.
		/// </summary>
		/// <param name="n1">O primeiro número.</param>
		/// <param name="n1Resposta">O resultado do primeiro número.</param>
		/// <param name="n2">O segundo número.</param>
		public static float RegraDeTres(float n1, float n1Resposta, float n2)
		{
			return (n2 * n1Resposta) / n1;
		}

		/// <summary>
		/// Método para calcular usando Bháskara.
		/// </summary>
		/// <param name="a">O valor multiplicador de x².</param>
		/// <param name="b">O valor multiplicador de x.</param>
		/// <param name="c">O valor sozinho.</param>
		public static float[] Bhaskara(float a, float b, float c)
		{
			float deltaSqrt = MathF.Sqrt((b * b) - (4 * a * c));

			float r1;
			float r2;
			r1 = (-b + deltaSqrt) / (2 * a);
			r2 = (-b - deltaSqrt) / (2 * a);

			float[] r = { r1, r2 };

			return r;
		}

		/// <summary>
		/// Método para calcular a Hipotenusa.
		/// </summary>
		/// <param name="catAdj">O valor do Cateto Adjacente.</param>
		/// <param name="catOpo">O valor do Cateto Oposto.</param>
		public static float Hipotenusa(float catAdj, float catOpo)
		{
			return MathF.Sqrt((catAdj * catAdj) + (catOpo * catOpo));
		}

		/// <summary>
		/// Método para calcular a Área do Trapézio.
		/// </summary>
		/// <param name="bMenor">O valor da Base Menor.</param>
		/// <param name="bMaior">O valor da Base Maior.</param>
		/// <param name="h">O valor da Altura.</param>
		public static float AreaTrapezio(float bMenor, float bMaior, float h)
		{
			return ((bMaior + bMenor) * h) / 2;
		}

	}
}
