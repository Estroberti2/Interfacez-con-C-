/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 17:54
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of AlumnoMuyEstudioso.
	/// </summary>
	public class AlumnoMuyEstudioso : Alumno
	{
		public AlumnoMuyEstudioso(string n, int d, int l, int p):base( n,  d,  l,  p)
		{
		}
		
		public override int responderPregunta(int pregunta){
			return 3;
		}
	}
}
