/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 14/9/2022
 * Hora: 12:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of IAlumnos.
	/// </summary>
	public interface IAlumnos
	{
		int getLegajo();
		int getPromedio();
		string getNombre();
		void cambiarEstrategia(Strategy s);
		double getCalificacion();
		void setCalificacion(double cal);
		int responderPregunta(int pregunta);
		string darPresente();
		string mostrarCalificacion();
	}
}
