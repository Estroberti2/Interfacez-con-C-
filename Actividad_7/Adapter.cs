/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 11/9/2022
 * Hora: 11:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of Adapter.
	/// </summary>
	public class Adapter : IStudents
	{
		IAlumnos a;
		public Adapter(IAlumnos s)
		{
			a=s;
		}
		
		public string getName(){
			return a.getNombre();
		}
		
		public string givePresent(){
			string s = a.darPresente();
			return s;
		}
		
		public int answerQuestion(int n){
			return a.responderPregunta(n);
		}
		
		public string showRating(){
			return a.mostrarCalificacion();
		}
		
		public double getRating(){
			return a.getCalificacion();
		}
		
		public void setRating(double d){
			a.setCalificacion(d);
		}
	}
}
