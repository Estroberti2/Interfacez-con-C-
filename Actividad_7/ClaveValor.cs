/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;

namespace Actividad_7
{
	/// <summary>
	/// Description of ClaveValor.
	/// </summary>
	public class ClaveValor : Comparable
	{
		Comparable clave;
		int claveNum = -1;
		Comparable valor;
		
		public ClaveValor(Comparable c, Comparable v){
			clave = c;
			valor = v;
		}
		public ClaveValor(int c, Comparable v){
			claveNum = c;
			valor = v;
		}
		public void cambiarValor(Comparable v){
			valor = v;
		}
		public bool tieneClaveNum(){
			return claveNum == -1;
		}
		public Comparable getClave(){
			return clave;
		}
		public int getClaveNum(){
			return claveNum;
		}
		public Comparable getValor(){
			return valor;
		}
		
		#region Comparable implementation

		public bool sosIgual(Comparable c)
		{
			return clave.sosIgual(c);
		}

		public bool sosMenor(Comparable c)
		{
			return clave.sosMenor(c);
		}

		public bool sosMayor(Comparable c)
		{
			return clave.sosMayor(c);
		}

		public string toString(){
			string s;
			if(claveNum == -1){
				s = "Clave: " + this.clave.toString() + "\n" + "Valor: " + this.valor.toString() + "\n";
				return s;
			}
			s = "Clave: " + this.claveNum + "\n" + "Valor: " + this.valor.toString() + "\n";
			return s;
		}
		#endregion
	}
}
