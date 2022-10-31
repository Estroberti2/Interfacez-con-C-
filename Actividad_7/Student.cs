/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 11/9/2022
 * Hora: 12:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of Student.
	/// </summary>
	public class Student : IStudents, IComparable
	{
		string name;
		double rating;
		
		public Student(string n)
		{
			name = n;
		}
		
		public string getName(){
			return name;
		}
		
		public double getRating(){
			return rating;
		}
		
		public void setRating(double rat){
			rating = rat;
		}
		// dar presente
		public string givePresent(){
			return "Present";
		}
	
		// responder pregunta
		public int answerQuestion(int n){
			Random random = new Random();
			int res = random.Next(1, 3);
			return res;
		}
		
		// mostrar calificacion
		public string showRating(){
			return name + " " + getRating();
		}

		#region IComparable implementation
		public int CompareTo(object obj)
		{
			if (obj == null) return 1;
 
			IStudents otherPerson = obj as IStudents; // realizar casteo del objeto a comparar
			if (otherPerson != null)
				return this.getRating().CompareTo(otherPerson.getRating());
			else
				throw new ArgumentException("Object is not a Person");
		}
		#endregion	
	}
}
