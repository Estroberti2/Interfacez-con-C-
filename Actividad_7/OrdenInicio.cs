/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 29/9/2022
 * Hora: 11:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of OrdenInicio.
	/// </summary>
	public class OrdenInicio : OrdenEnAula1
	{
		Aula a;
		public OrdenInicio(Aula b)
		{
			a = b;
		}
		public void ejecutar()
		{
			a.Comenzar();
		}
	}
}
