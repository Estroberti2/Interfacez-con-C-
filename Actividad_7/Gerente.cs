/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:54
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Actividad_7
{
	/// <summary>
	/// Description of Gerente.
	/// </summary>
	public class Gerente : IObservador
	{
		List<Comparable> mejores;
		public Gerente()
		{
			mejores = new List<Comparable>();
		}
		
		public void cerrar(){
			foreach(Comparable col in mejores){
				string s = " Nombre: " + ((Vendedor)col).getNombre() + " DNI: " + ((Vendedor)col).getDni() + " Bonus: " + ((Vendedor)col).getBonus();
				Console.WriteLine(s);
			}
		} 
		public void venta(Vendedor c, double monto){
			
			if(monto > 5000){
				if(!existe((Comparable)c)){
					mejores.Add(c);
				}
				c.aumentaBonus();
			}
		}
		public bool existe(Comparable c){
			foreach(Comparable col in mejores){
				if(col.sosIgual(c)){
					return true;
				}
			}
			return false;
		}
		public void actualizar(IObservado o){
			venta(((Vendedor)o), ((Vendedor)o).getMontoVendido());
		}
	}
}
