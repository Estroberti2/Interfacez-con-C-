/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of Strategy.
	/// </summary>
	public interface Strategy
	{
		bool sosIgual(Comparable c, Comparable d);
		bool sosMenor(Comparable c, Comparable d);
		bool sosMayor(Comparable c, Comparable d);
	}
}
