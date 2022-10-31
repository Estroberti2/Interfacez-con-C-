/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Actividad_7
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto : Coleccionable, Iterable
	{
		List<Comparable> conjunto;
		
		public Conjunto(){
			conjunto = new List<Comparable>();
		}
		
		public List<Comparable> getConjunto(){
			return conjunto;
		}
		
		public void agregar(Comparable c){
			if(!this.contiene(c)){
				conjunto.Add(c);
			}
		}
		public bool contiene(Comparable c){
			
			foreach(Comparable d in conjunto){
				if(d.sosIgual(c)){
					return true;
				}
			}
			return false;
		}
		public int cuantos(){
			return conjunto.Count;
		}
		
		public Comparable minimo(){
			Comparable minimo = conjunto[0];
			for(int i = 1; i < conjunto.Count; i++){
				if(conjunto[i].sosMenor(minimo)){
					minimo = conjunto[i];
				}
			}
			return minimo;
		}
		
		public Comparable maximo(){
			Comparable maximo = conjunto[0];
			for(int i = 1; i < conjunto.Count; i++){
				if(conjunto[i].sosMayor(maximo)){
					maximo = conjunto[i];
				}
			}
			return maximo;
		}
		
		#region Iterable implementation

		public Iterator crearIterator()
		{
			return new Iterador(conjunto);
		}
		
		#endregion
	}
}
