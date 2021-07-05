using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
	/// <summary>
	/// Uma classe usada para conversão aproximada de Tempo.
	/// </summary>
	public static class ConversaoDeUnidadesDeTempo
	{
		/// <summary>
		/// Converte de Minutos para Segundos.
		/// </summary>
		/// <param name="t">O valor em Minutos.</param>
		public static float MinutoParaSegundo(float t)
		{
			return t * 60f;
		}
		
		/// <summary>
		/// Converte de Horas para Minutos.
		/// </summary>
		/// <param name="t">O valor em Horas</param>
		public static float HoraParaMinuto(float t)
		{
			return t * 60f;
		}
		
		/// <summary>
		/// Converte de Dias para Horas
		/// </summary>
		/// <param name="t">O valor em Dias</param>
		public static float DiaParaHora(float t)
		{
			return t * 24f;
		}
		
		/// <summary>
		/// Converte de Semanas para Dias.
		/// </summary>
		/// <param name="t">O valor em Semanas</param>
		public static float SemanaParaDia(float t)
		{
			return t * 7f;
		}
		
		/// <summary>
		/// Converte de Mêses para Dias.
		/// </summary>
		/// <param name="t">O valor em Meses</param>
		public static float MesesParaDia(float t)
		{
			return t * 30f;
		}
		
		/// <summary>
		/// Converte de Anos para Dias
		/// </summary>
		/// <param name="t">O valor em Anos</param>
		public static float AnoParaDia(float t)
		{
			return t * 365.25f;
		}

		

	}
}
