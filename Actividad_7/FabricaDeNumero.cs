/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of FabricaDeNumero.
	/// </summary>
	public class FabricaDeNumero : FactoryMethod
	{
		public override Comparable crearAleatorio(ChainOfResponsability s, int que = 0){
			// generamos uno aleatorio max 10)
			return new Numero(s.numeroAleatorio(10));
		}
		
		public override Comparable crearTeclado(ChainOfResponsability s){
			return new Numero(s.numeroPorTeclado());
		}
	}
}
