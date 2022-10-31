/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 13:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary>
	public class LectorDeDatos : ChainOfResponsability
	{
		public LectorDeDatos(ChainOfResponsability s):base(s){
			
		}
		public override int numeroPorTeclado(){
			
			int numPorTeclado = Convert.ToInt32( Console.ReadLine() );
			return numPorTeclado;
		}
		
		public override string stringPorTeclado(){
			
			string str = Console.ReadLine();
			return str;		
		}
	}
}
