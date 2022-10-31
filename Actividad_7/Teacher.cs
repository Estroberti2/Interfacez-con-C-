/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 11/9/2022
 * Hora: 11:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Actividad_7
{
	/// <summary>
	/// Description of Teacher.
	/// </summary>
	public class Teacher
	{
		List<IStudents> listStudents;
		
		public Teacher(){
			listStudents = new List<IStudents>();
		}
		
		// llega un alumno
		public void goToClass(IStudents s){
			listStudents.Add(s);
		}
		
		// pasar lista
		public void teachingAClass()
		{
			Console.WriteLine("Good morning");
			Console.WriteLine("I'm going to take attendance\n");
			foreach(IStudents s in listStudents){
				Console.WriteLine(s.givePresent());
			}
			Console.WriteLine("\n\n");
		}
		
		// tomar examen
		public void takeExam()
		{
			Console.WriteLine("I'm going to take an exam");
			foreach(IStudents s in listStudents){
				if(s.answerQuestion(3) == 3){
					s.setRating(10);
				}
				else{
					s.setRating(0);
				}
			}
			Console.WriteLine("\n\n");
		}
		
		// publicar resultados (ordenados por calificacion)
		public void publishResults()
		{
			Console.WriteLine("Exam results");
			listStudents.Sort((IStudents x, IStudents y) => x.getRating().CompareTo(y.getRating()));
			// forma lambda
		//	listStudents.Sort((x, y) => x.getCalificación().CompareTo(y.getCalificación()));
			foreach(IStudents s in listStudents){
				Console.WriteLine(s.showRating());
			}
			Console.WriteLine("\n\n");
		}
		
		// publicar resultados (ordenados por calificacion (menor a mayor))
//		public void publishResults2()
//		{
//			Console.WriteLine("Exam results");
//			listStudents.Sort((IStudents x, IStudents y) => x.getRating().CompareTo(y.getRating()));
//			listStudents.Reverse();
//			foreach(IStudents s in listStudents){
//				Console.WriteLine(s.showRating());
//			}
//			Console.WriteLine("\n\n");
//		}
	}
}
