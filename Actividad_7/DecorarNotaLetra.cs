/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 14/9/2022
 * Hora: 12:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of DecorarNotaLetra.
	/// </summary>
	public class DecorarNotaLetra : AlumnoDecorador
	{
		public DecorarNotaLetra(IAlumnos ia)
		{
			base.setAlumnoDecorador(ia);
		}
		public override string mostrarCalificacion()
		{
			string s = base.getNombre() + "\t" + base.getCalificacion();
			double a = base.getCalificacion();
			int num = (int)a;
			switch (num) {
				case 0:
					s += "(cero)";
					break;
				case 1:
					s += "(uno)";
					break;
				case 2:
					s += "(dos)";
					break;
				case 3:
					s += "(tres)";
					break;
				case 4:
					s += "(cuatro)";
					break;
				case 5:
					s += "(cinco)";
					break;
				case 6:
					s += "(seis)";
					break;
				case 7:
					s += "(siete)";
					break;
				case 8:
					s += "(ocho)";
					break;
				case 9:
					s += "(nueve)";
					break;
				case 10:
					s += "(diez)";
					break;
			}
			
			return s;
		}
	}
}
