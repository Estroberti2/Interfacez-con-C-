/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class ColeccionMultiple : Coleccionable
	{
		Pila pila;
		Cola cola;
		
		public ColeccionMultiple(Pila p, Cola c){
			this.pila = p;
			this.cola = c;
		}
		
		public int cuantos(){
			return pila.cuantos() + cola.cuantos();
		}
		
		public Comparable minimo(){
			if(pila.minimo().sosMenor(cola.minimo())){
				return pila.minimo();
			}
			return cola.minimo();
		}
		
		public Comparable maximo(){
			if(pila.maximo().sosMayor(cola.maximo())){
				return pila.maximo();
			}
			return cola.maximo();
		}
		
		public void agregar(Comparable c){
			// no hace nada
		}
		
		public bool contiene(Comparable c){
			
			if(pila.contiene(c) || cola.contiene(c)){
				return true;
			}
			return false;
		}
	}
}
