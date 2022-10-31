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
	/// Description of FactoryMethod.
	/// </summary>
	public abstract class FactoryMethod : FabricaDeComparables
	{
		#region FabricaDeComparables implementation

		public Comparable crearAl(int que)
		{
			return crearAleatorio(que);
		}

		public Comparable crearTec(int que)
		{
			return crearTeclado(que);
		}

		#endregion
		
		// forma aleatoria
		public static Comparable crearAleatorio(int que, int deque = 0){
			
			ChainOfResponsability manejador = new LectorDeDatos(null);
			manejador = new LectorDeArchivos(manejador);
			manejador = new GeneradorDeDatosAleatorios(manejador);
			
			FactoryMethod fm = null;
			
			switch (que) {
				case 1:
					// creo numero
					fm = new FabricaDeNumero();
					break;
				case 2:
					// creo alumno
					fm = new FabricaDeAlumno();
					break;
				case 3:
					// creo alumno estudiosos
					fm = new FabricaDeAlumnoEstudiosos();
					break;
				case 4:
					// creo vendedor
					fm = new FabricaDeVendedores();
					break;
				case 5:
					// creo ProxyAlumno
					fm = new FabricaDeProxyAlumno();
					break;
				case 6:
					// creo Composite
					fm = new FabricaDeCompositeAlumnos();
					break;
			}
			// esto lo apolican sus herederos	
			return fm.crearAleatorio(manejador, deque);
		}
		
		public abstract Comparable crearAleatorio(ChainOfResponsability s, int deque);
		
		// forma por teclado
		public static Comparable crearTeclado(int que){
			
			ChainOfResponsability manejador = new LectorDeDatos(null);
			manejador = new LectorDeArchivos(manejador);
			manejador = new GeneradorDeDatosAleatorios(manejador);
			
			FactoryMethod fm = null;
			switch (que) {
				case 1:
					// creo numero
					fm = new FabricaDeNumero();
					break;
				case 2:
					// creo alumno
					fm = new FabricaDeAlumno();
					break;
				case 3:
					// creo alumno estudiosos
					fm = new FabricaDeAlumnoEstudiosos();
					break;
				case 4:
					// creo vendedor
					fm = new FabricaDeVendedores();
					break;
				case 5:
					// creo ProxyAlumno
					fm = new FabricaDeProxyAlumno();
					break;
				case 6:
					// creo Composite
					fm = new FabricaDeCompositeAlumnos();
					break;
			}
			// esto lo apolican sus herederos	
			return fm.crearTeclado(manejador);
		}
		
		public abstract Comparable crearTeclado(ChainOfResponsability s);
	}
}
