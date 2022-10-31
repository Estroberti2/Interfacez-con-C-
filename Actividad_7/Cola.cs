/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Actividad_7
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola : Coleccionable, Iterable
	{
		List<Comparable> elementos;
		
		public Cola(){
			elementos = new List<Comparable>();
		}
		
		public void push(Comparable c){
			elementos.Add(c);
		}
		
		public Comparable pop(int i){
			Comparable c;
			c = elementos[i];
//			elementos.RemoveAt(i);
			return c;
		}
		
		public int cuantos(){
			return this.elementos.Count;
		}
		
		public Comparable minimo(){
			Comparable minimo = elementos[0];
			for(int i = 1; i < elementos.Count; i++){
				if(elementos[i].sosMenor(minimo)){
					minimo = elementos[i];
				}
			}
			return minimo;
		}
		
		public Comparable maximo(){
			Comparable maximo = elementos[0];
			for(int i = 1; i < elementos.Count; i++){
				if(elementos[i].sosMayor(maximo)){
					maximo = elementos[i];
				}
			}
			return maximo;
		}
		
		public void agregar(Comparable c){
			this.push(c);
		}
		
		public bool contiene(Comparable c){
			foreach(Comparable com in elementos){
				if(c.sosIgual(com)){
					return true;
				}
			}
			return false;
		}

		#region Iterable implementation

		public Iterator crearIterator()
		{
			return new Iterador(elementos);
		}

		#endregion
	}
}
