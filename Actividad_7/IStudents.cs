/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 11/9/2022
 * Hora: 12:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of IStudents.
	/// </summary>
	public interface IStudents
	{
		string givePresent();
		int answerQuestion(int n);
		string showRating();
		double getRating();
		void setRating(double rat);
		string getName();
	}
}
