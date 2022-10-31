/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 11/9/2022
 * Hora: 14:16
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of Adapter2.
	/// </summary>
	public class Adapter2 : IStudents
	{
		AlumnoMuyEstudioso a;
		public Adapter2(AlumnoMuyEstudioso s)
		{
			a=s;
		}
		
		public string getName(){
			return a.getNombre();
		}
		
		public string givePresent(){
			return a.darPresente();
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
