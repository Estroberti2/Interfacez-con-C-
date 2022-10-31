/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:06
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;

namespace Actividad_7
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona, IAlumnos
	{
		int legajo;
		int promedio;
		Strategy strategy;
		double calificacion;
		static Random random = new Random();
		
		public Alumno(string n, int d, int l, int p):base(n, d){
			
			this.legajo = l;
			this.promedio = p;
			calificacion = 0;
			strategy = new PorDni();
		}
		
		public int getLegajo(){
			return legajo;
		}
		
		public int getPromedio(){
			return promedio;
		}
		
		public void cambiarEstrategia(Strategy s){
			this.strategy = s;
		}	
		
		public override bool sosIgual(Comparable c){
			
			return strategy.sosIgual(this, c);
		}
		
		public override bool sosMenor(Comparable c){
			
			return strategy.sosMenor(this, c);
		}
		
		public override bool sosMayor(Comparable c){
			
			return strategy.sosMayor(this, c);
		}
		public override string toString(){
			string s = "Nombre: " + this.getNombre() + " DNI; " + this.getDni() + " Legajo: "  + this.getLegajo() + " Promedio: "  + this.getPromedio();
			return s;
		}
		
		public double getCalificacion(){
			return calificacion;
		}
		
		public void setCalificacion(double cal){
			calificacion = cal;
		}
		
		public virtual int responderPregunta(int pregunta){
			int res = random.Next(1, 3);
			return res;
		}
		
		public string mostrarCalificacion(){
			return getNombre() + " " + getCalificacion();
		}
		
		public string darPresente(){
			return "Presente";
		}
	}
}
