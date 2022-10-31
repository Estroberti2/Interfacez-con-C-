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
	/// Description of Numero.
	/// </summary>
	public class Numero : Comparable
	{
		int num;
		public Numero(int num)
		{
			this.num = num;
		}
		public int getNum(){
			return num;
		}

		#region Comparable implementation

		public bool sosIgual(Comparable c)
		{
			return ((Numero)c).getNum() == this.getNum();
		}

		public bool sosMenor(Comparable c)
		{
			return ((Numero)c).getNum() < this.getNum();
		}

		public bool sosMayor(Comparable c)
		{
			return ((Numero)c).getNum() > this.getNum();
		}

		public string toString()
		{
			return "";
		}

		#endregion
	}
}
