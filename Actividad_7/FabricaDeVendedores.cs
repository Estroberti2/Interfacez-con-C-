/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of FabricaDeVendedores.
	/// </summary>
	public class FabricaDeVendedores : FactoryMethod
	{
		 public override Comparable crearAleatorio(ChainOfResponsability s, int que = 0){
			// generamos uno texto max 8
			
			return new Vendedor(  
					s.stringAleatorio(8),
					s.numeroAleatorio(99999999),
					s.numeroAleatorio(99999)
			);
		}
		public override Comparable crearTeclado(ChainOfResponsability s){
			
			return new Vendedor(
					s.stringPorTeclado(),
					s.numeroPorTeclado(),
					s.numeroPorTeclado()
			);
		}
	}
}
