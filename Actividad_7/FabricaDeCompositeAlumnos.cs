/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 12/10/2022
 * Hora: 13:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of FabricaDeCompositeAlumnos.
	/// </summary>
	public class FabricaDeCompositeAlumnos : FactoryMethod
	{
		#region implemented abstract members of FactoryMethod

		public override Comparable crearAleatorio(ChainOfResponsability s,int deque = 0)
		{
			CompositeAlumnos cal = new CompositeAlumnos();
			for (int i = 0; i < 5; i++) {
				cal.agregarAlumno((IAlumnos)(FactoryMethod.crearAleatorio(5, 0)));
			}
			return (Comparable)cal;
		}
	
		public override Comparable crearTeclado(ChainOfResponsability s)
		{
			CompositeAlumnos cal = new CompositeAlumnos();
			for (int i = 0; i < 5; i++) {
				cal.agregarAlumno((IAlumnos)(FactoryMethod.crearTeclado(5)));
			}
			return (Comparable)cal;
		}

		#endregion
	}
}
