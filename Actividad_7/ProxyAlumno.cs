/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 26/9/2022
 * Hora: 10:16
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of ProxyAlumno.
	/// </summary>
	public class ProxyAlumno : IAlumnos, Comparable
	{
		IAlumnos a = null;
		string nom;
		int dni;
		int legajo;
		int preomedio;
		int queCrear;
		
		public ProxyAlumno(string n, int d, int l, int p, int q)
		{
			nom = n;
			dni = d;
			legajo = l;
			preomedio = p;
			queCrear = q;
		}

		#region IAlumnos implementation

		public int getLegajo()
		{
			return legajo;
		}

		public int getPromedio()
		{
			return preomedio;
		}

		public string getNombre()
		{
			return nom;
		}

		public double getCalificacion()
		{
			return a.getCalificacion();
		}
		
		public void cambiarEstrategia(Strategy s)
		{
			a.cambiarEstrategia(s);
		}

		public void setCalificacion(double cal)
		{
			a.setCalificacion(cal);
		}

		public virtual int responderPregunta(int pregunta)
		{
			// aca se crea el alumno
			if(a == null){
				if(queCrear == 1){
					a = new Alumno(nom, dni, legajo, preomedio);
				}
				if(queCrear == 2){
					a = new AlumnoMuyEstudioso(nom, dni, legajo, preomedio);
				}
				return a.responderPregunta(pregunta);
			}
			return a.responderPregunta(pregunta);
		}

		public string darPresente()
		{
			string s = ((queCrear == 1) ? "ProxyAlumno" : "ProxyAlumnoEstudioso");
			return s;
		}

		public string mostrarCalificacion()
		{
			return a.mostrarCalificacion();
		}

		#endregion

		#region Comparable implementation

		public bool sosIgual(Comparable c)
		{
			return ((Comparable)a).sosIgual(c);
		}

		public bool sosMenor(Comparable c)
		{
			return ((Comparable)a).sosMenor(c);
		}

		public bool sosMayor(Comparable c)
		{
			return ((Comparable)a).sosMayor(c);
		}

		public string toString()
		{
			return ((Comparable)a).toString();;
		}

		#endregion
	}
}
