/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 14/9/2022
 * Hora: 15:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of DecoratorStudent.
	/// </summary>
	public class DecoratorStudent : StudentDecorator
	{
		public DecoratorStudent(IStudents st)
		{
			base.setStudentDecorator(st);
		}
		public override string showRating(){
			string s = "*************************************************\n";
			string t = "*\t" + base.getName() + "\t" + base.getRating();		
			
			switch ((int)base.getRating()) {
				case 0:
					t += "(cero)(DESAPROBADO)\t*\n";
					break;
				case 1:
					t += "(uno)(DESAPROBADO)\t*\n";
					break;
				case 2:
					t += "(dos)(DESAPROBADO)\t*\n";
					break;
				case 3:
					t += "(tres)(DESAPROBADO)\t*\n";
					break;
				case 4:
					t += "(cuatro)(APROBADO)\t*\n";
					break;
				case 5:
					t += "(cinco)(APROBADO)\t*\n";
					break;
				case 6:
					t += "(seis)(APROBADO)\t*\n";
					break;
				case 7:
					t += "(siete)(PROMOCIÓN)\t*\n";
					break;
				case 8:
					t += "(ocho)(PROMOCIÓN)\t*\n";
					break;
				case 9:
					t += "(nueve)(PROMOCIÓN)\t*\n";
					break;
				case 10:
					t += "(diez)(PROMOCIÓN)\t*\n";
					break;
			}
			
			return s+t+s;
		}
	}
}
