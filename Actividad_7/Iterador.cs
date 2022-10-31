/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Actividad_7
{
	/// <summary>
	/// Description of Iterador.
	/// </summary>
	public class Iterador : Iterator
	{
		int paginaActual;
		List<Comparable> paginas;
		
		public Iterador(List<Comparable> c){
			paginas = c;
			primero();
		}
		
		public void primero(){
			paginaActual = 0;
		}
		public void siguiente(){
			paginaActual ++;
		}
		public bool fin(){
			return paginaActual >= paginas.Count;
		}
		public Comparable actual(){
			return paginas[paginaActual];
		}
	}
}
