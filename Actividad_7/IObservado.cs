/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of IObservado.
	/// </summary>
	public interface IObservado
	{
		void agregarObservador(IObservador o);
		void quitarObservador(IObservador o);
		void notificar();
	}
}
