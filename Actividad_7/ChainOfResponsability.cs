/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 26/10/2022
 * Hora: 08:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of ChainOfResponsability.
	/// </summary>
	public abstract class ChainOfResponsability
	{
		ChainOfResponsability sucesor = null;
		
		public ChainOfResponsability(ChainOfResponsability s){
			sucesor = s;
		}
		
		public virtual int numeroPorTeclado(){
			if(sucesor != null){
				return sucesor.numeroPorTeclado();
			}
			return 0;
		}
		
		public virtual string stringPorTeclado(){
			if(sucesor != null){
				return sucesor.stringPorTeclado();
			}
			return "";
		}
		
		public virtual int numeroAleatorio(int max){
			if(sucesor != null){
				return sucesor.numeroAleatorio(max);
			}
			return 0;
		}
		
		public virtual string stringAleatorio(int cant){
			if(sucesor != null){
				return sucesor.stringAleatorio(cant);
			}
			return "";
		}
		
		public virtual double numeroDesdeArchivo(double max){
			if(sucesor != null){
				return sucesor.numeroDesdeArchivo(max);
			}
			return 0;
		}
		
		public virtual string stringDesdeArchivo(int cant){
			if(sucesor != null){
				return sucesor.stringDesdeArchivo(cant);
			}
			return "";
		}
	}
}
