/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 14/9/2022
 * Hora: 12:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of DecoradorLegajo.
	/// </summary>
	public class DecoradorLegajo : AlumnoDecorador
	{
		public DecoradorLegajo(IAlumnos ia)
		{
			base.setAlumnoDecorador(ia);
		}
		public override string mostrarCalificacion()
		{
			return base.getNombre() + "(" + base.getLegajo() + ")" + "\t" + base.getCalificacion();
		}
	}
	
}
