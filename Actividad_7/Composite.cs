/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 11/10/2022
 * Hora: 13:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of Composite.
	/// </summary>
	public interface Composite
	{
		string getNombre();
		int responderPregunta(int p);
		void setCalificacion(double num);
		string mostrarCalificacion();
		bool sosIgual(IAlumnos a);
		bool sosMenor(IAlumnos a);
		bool sosMayor(IAlumnos a);
	}
}
