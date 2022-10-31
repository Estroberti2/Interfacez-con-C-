/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 29/9/2022
 * Hora: 11:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of OrdenLlegaAlumno.
	/// </summary>
	public class OrdenLlegaAlumno : OrdenEnAula2
	{
		Aula a;
		public OrdenLlegaAlumno(Aula b)
		{
			a = b;
		}
		public void ejecutar(Comparable c)
		{
			a.nuevoAlumno(((IAlumnos)c));
		}
	}
}
