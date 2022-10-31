/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 11/10/2022
 * Hora: 13:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Actividad_7
{
	/// <summary>
	/// Description of CompositeAlumnos.
	/// </summary>
	public class CompositeAlumnos : IAlumnos, Comparable
	{
		List<IAlumnos> hijos;
		public CompositeAlumnos(){
			hijos = new List<IAlumnos>();
		}
		
		public void agregarAlumno(IAlumnos al){
			hijos.Add(al);
		}
		
		public string getNombre(){
			string s = "";
			foreach(IAlumnos ia in hijos){
				s+= ia.getNombre() + "\n";
			}
			return s;
		}
		
		public int responderPregunta(int p){
			int rp = 0;
			int cp = 0;
			foreach(IAlumnos ia in hijos){
				rp = ia.responderPregunta(p);
				cp++;
			}
			return ((int)(rp / cp));
		}
		
		public void setCalificacion(double num){
			foreach(IAlumnos ia in hijos){
				ia.setCalificacion(num);
			}
		}
		
		public string mostrarCalificacion(){
			string s = "";
			foreach(IAlumnos ia in hijos){
				s+= ia.mostrarCalificacion() + "\n";
			}
			return s;
			// tambien se podria mostrar un promedio de la calificacion
		}
		
		public bool sosIgual(IAlumnos a){
			foreach(IAlumnos ia in hijos){
				if(((Alumno)ia).sosMenor((Alumno)a) || ((Alumno)ia).sosMayor((Alumno)a)){
					return false;
				}
			}
			return true;
		}
		
		public bool sosMenor(IAlumnos a){
			foreach(IAlumnos ia in hijos){
				if(((Alumno)ia).sosMayor((Alumno)a) || ((Alumno)ia).sosIgual((Alumno)a)){
					return false;
				}
			}
			return true;
		}
		
		public bool sosMayor(IAlumnos a){
			foreach(IAlumnos ia in hijos){
				if(((Alumno)ia).sosMenor((Alumno)a) || ((Alumno)ia).sosIgual((Alumno)a)){
					return false;
				}
			}
			return true;
		}

		public int getLegajo()
		{
			int rp = 0;
			int cp = 0;
			foreach(IAlumnos ia in hijos){
				rp = ia.getLegajo();
				cp++;
			}
			return ((int)(rp / cp));
		}

		public int getPromedio()
		{
			int rp = 0;
			int cp = 0;
			foreach(IAlumnos ia in hijos){
				rp = ia.getPromedio();
				cp++;
			}
			return ((int)(rp / cp));
		}

		public void cambiarEstrategia(Strategy s)
		{
			foreach(IAlumnos ia in hijos){
				ia.cambiarEstrategia(s);
			}
		}

		public double getCalificacion()
		{
			double rp = 0;
			int cp = 0;
			foreach(IAlumnos ia in hijos){
				rp = ia.getCalificacion();
				cp++;
			}
			return ((double)(rp / cp));
		}

		public string darPresente()
		{
			string s = "";
			foreach(IAlumnos ia in hijos){
				s+= ia.darPresente() + "\n";
			}
			return s;
		}

		#region Comparable implementation

		public bool sosIgual(Comparable c)
		{
			foreach(Comparable ia in hijos){
				if(ia.sosMenor(c) || ia.sosMayor(c)){
					return false;
				}
			}
			return true;
		}

		public bool sosMenor(Comparable c)
		{
			foreach(Comparable ia in hijos){
				if(ia.sosIgual(c) || ia.sosMayor(c)){
					return false;
				}
			}
			return true;
		}

		public bool sosMayor(Comparable c)
		{
			foreach(Comparable ia in hijos){
				if(ia.sosMenor(c) || ia.sosIgual(c)){
					return false;
				}
			}
			return true;
		}

		public string toString()
		{
			return getNombre();
		}

		#endregion
	}
}
