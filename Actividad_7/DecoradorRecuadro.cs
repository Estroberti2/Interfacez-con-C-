/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 14/9/2022
 * Hora: 13:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of DecoradorRecuadro.
	/// </summary>
	public class DecoradorRecuadro : AlumnoDecorador
	{
		public DecoradorRecuadro(IAlumnos ia)
		{
			base.setAlumnoDecorador(ia);
		}
		public override string mostrarCalificacion()
		{
			string s = "*********************************\n" 
					  + "*\t" + base.getNombre() + "\t" + base.getCalificacion() + "\t*\n" 
					 + "*********************************\n";			
			return s;
		}
	}
}
