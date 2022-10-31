/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Actividad_7
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila : Coleccionable, Iterable, Ordenable
	{
		private List<Comparable> elementos;
		OrdenEnAula1 ordenInicio, ordenFinal;
		OrdenEnAula2 nuevoAlumno;
		
		public Pila(){
			elementos = new List<Comparable>();
		}
		
		public void push(Comparable c)
		{
			elementos.Add(c);
			if(this.cuantos() == 1){
				ordenInicio.ejecutar();
			}
			nuevoAlumno.ejecutar(c);
			if(this.cuantos() == 40){
				ordenFinal.ejecutar();
			}
		}
		public void terminar(){
			ordenFinal.ejecutar();
		}
		
		public Comparable pop(){
			Comparable c;
			c = elementos[cuantos() - 1];
			elementos.RemoveAt(cuantos() - 1);
			return c;
		}
		
		public int cuantos(){
			return elementos.Count;
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

		#region Ordenable implementation

		public void setOrdenInicio(OrdenEnAula1 o1)
		{
			ordenInicio = o1;
		}

		public void setOrdenLlegaAlumno(OrdenEnAula2 o2)
		{
			nuevoAlumno = o2;
		}

		public void setOrdenAulaLlena(OrdenEnAula1 o1)
		{
			ordenFinal = o1;
		}

		#endregion
	}
}
