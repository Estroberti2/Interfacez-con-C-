/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:05
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona : Comparable
	{
		string nombre;
		int dni;
		
		
		public Persona(string nom, int dni){
			this.nombre = nom;
			this.dni = dni;
		}
		
		public string getNombre(){
			return nombre;
		}
		
		public int getDni(){
			return dni;
		}
		
		public void setNombre(string n){
			nombre = n;
		}
		
		public void setDni(int d){
			dni = d;
		}
		
		public virtual bool sosIgual(Comparable c){
			
			if(((Persona)c).dni == this.dni){
				return true;
			}
			return false;
		}
		
		public virtual bool sosMenor(Comparable c){
			
			if(((Persona)c).dni < this.dni){
				return true;
			}
			return false;
		}
		
		public virtual bool sosMayor(Comparable c){
			
			if(((Persona)c).dni > this.dni){
				return true;
			}
			return false;
		}
		
		public virtual string toString(){
			string s = "Nombre: " + this.getNombre() + " DNI; " + this.getDni();
			return s;
		}
	}
}
