/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 14/9/2022
 * Hora: 12:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of AlumnoDecorador.
	/// </summary>
	public abstract class AlumnoDecorador : IAlumnos
	{
		IAlumnos ia;
		public void setAlumnoDecorador(IAlumnos ia)
		{
			this.ia = ia;
		}

		#region IAlumnos implementation

		public int getLegajo()
		{
			return ia.getLegajo();
		}

		public int getPromedio()
		{
			return ia.getPromedio();
		}
		
		public string getNombre()
		{
			return ia.getNombre();
		}

		public void cambiarEstrategia(Strategy s)
		{
			ia.cambiarEstrategia(s);
		}

		public double getCalificacion()
		{
			return ia.getCalificacion();
		}

		public void setCalificacion(double cal)
		{
			ia.setCalificacion(cal);
		}

		public int responderPregunta(int pregunta)
		{
			return ia.responderPregunta(pregunta);
		}

		public string darPresente()
		{
			return ia.darPresente();
		}

		public virtual string mostrarCalificacion()
		{
			return ia.mostrarCalificacion();
		}

		#endregion
	}
}
