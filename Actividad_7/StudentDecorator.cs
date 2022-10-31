/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 14/9/2022
 * Hora: 15:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of StudentDecorator.
	/// </summary>
	public abstract class StudentDecorator : IStudents
	{
		IStudents student;
		public void setStudentDecorator(IStudents st)
		{
			student = st;
		}
		
		public string givePresent(){
			return student.givePresent();
		}
		public int answerQuestion(int n){
			return student.answerQuestion(n);
		}
		// este es el que se va a decorar
		public virtual string showRating(){
			return student.showRating();
		}
		public double getRating(){
			return student.getRating();
		}
		public void setRating(double rat){
			student.setRating(rat);
		}
		public string getName(){
			return student.getName();
		}
	}
}
