/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of Iterator.
	/// </summary>
	public interface Iterator
	{
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();
	}
}
