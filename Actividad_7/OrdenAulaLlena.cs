/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 29/9/2022
 * Hora: 11:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of OrdenAulaLlena.
	/// </summary>
	public class OrdenAulaLlena : OrdenEnAula1
	{
		Aula a;
		public OrdenAulaLlena(Aula b)
		{
			a = b;
		}
		public void ejecutar()
		{
			a.claseLista();
		}
	}
}
