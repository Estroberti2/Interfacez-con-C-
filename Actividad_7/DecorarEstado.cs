/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 14/9/2022
 * Hora: 13:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of DecorarEstado.
	/// </summary>
	public class DecorarEstado : AlumnoDecorador
	{
		public DecorarEstado(IAlumnos ia)
		{
			base.setAlumnoDecorador(ia);
		}
		public override string mostrarCalificacion()
		{
			string s = base.getNombre() + "\t" + base.getCalificacion();
			if(base.getCalificacion() >= 7){
				s += "(PROMOCIÓN)";
			}
			else{
				if(base.getCalificacion() >= 4 && base.getCalificacion() < 7){
					s += "(APROBADO)";
				}
				else{
					s += "(DESAPROBADO)";
				}
			}
			return s;
		}
	}
}
