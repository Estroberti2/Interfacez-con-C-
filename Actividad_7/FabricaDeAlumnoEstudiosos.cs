/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 11/9/2022
 * Hora: 13:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of FabricaDeAlumnoEstudiosos.
	/// </summary>
	public class FabricaDeAlumnoEstudiosos : FactoryMethod
	{
		public override Comparable crearAleatorio(ChainOfResponsability s, int que = 0){
			// generamos uno texto max 8
			
			return new AlumnoMuyEstudioso(
					s.stringAleatorio(8),
					s.numeroAleatorio(99999999),
					s.numeroAleatorio(99999),
					s.numeroAleatorio(9)
			);
		}
		public override Comparable crearTeclado(ChainOfResponsability s){
			
			return new AlumnoMuyEstudioso( 
					s.stringPorTeclado(),
					s.numeroPorTeclado(),
					s.numeroPorTeclado(),
					s.numeroPorTeclado());
		}
	}
}
