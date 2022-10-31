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
	/// Description of Diccionario.
	/// </summary>
	public class Diccionario : Coleccionable, Iterable
	{
		List<Comparable> dic;
		int num = 0;
		
		public Diccionario(){
			dic = new List<Comparable>();
		}
		
		public void agregar(Comparable clave,Comparable valor){
			
			if(!this.contiene(valor)){
				dic.Add(new ClaveValor(clave, valor));
			}
			else{
				foreach(ClaveValor c in dic){
					if(c.tieneClaveNum()){
						if(c.getClave().sosIgual(clave)){
							c.cambiarValor(valor);
						}
					}
				}
			}
		}
	
		public Comparable valorDe(Comparable clave){
			foreach(ClaveValor c in dic){
				if(c.tieneClaveNum()){
					if(clave.sosIgual(c.getClave())){
						return c.getValor();
					}
				}
			}
			return null;
		}
		
		public int cuantos(){
			return dic.Count;
		}
		
		public Comparable minimo(){
			
			Comparable minimo = (dic[0] as ClaveValor).getValor();
			
			for(int i = 1; i < dic.Count; i++){
				if((dic[i] as ClaveValor).getValor().sosMenor(minimo)){
					minimo = (dic[i] as ClaveValor).getValor();
				}
			}
			return minimo;
		}
		
		public Comparable maximo(){
			
			Comparable maximo = (dic[0] as ClaveValor).getValor();
			
			for(int i = 1; i < dic.Count; i++){
				if((dic[i] as ClaveValor).getValor().sosMayor(maximo)){
					maximo = (dic[i] as ClaveValor).getValor();
				}
			}
			return maximo;
		}
		
		public void agregar(Comparable v){
			if(!this.contiene(v)){
				dic.Add(new ClaveValor(num, v));
				num++;
			}
		}
		public bool contiene(Comparable valor){
			
			foreach(ClaveValor c in dic){
				if(c.getValor().sosIgual(valor)){
					return true;
				}
			}
			return false;
		}

		#region Iterable implementation

		public Iterator crearIterator()
		{
			return new Iterador(dic);
		}

		#endregion
	}
}
