/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public interface FabricaDeComparables
	{
		Comparable crearAl(int que);
		Comparable crearTec(int que);
	}
}
