/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of Strategy2.
	/// </summary>
	
	class PorDni : Strategy{
		
		public bool sosIgual(Comparable c, Comparable d){
			return (((Alumno)c).getDni().CompareTo(((Alumno)d).getDni())) == 0;
		}
		public bool sosMenor(Comparable c, Comparable d){
			return (((Alumno)c).getDni().CompareTo(((Alumno)d).getDni())) < 0;
		}
		public bool sosMayor(Comparable c, Comparable d){
			return (((Alumno)c).getDni().CompareTo(((Alumno)d).getDni())) > 0;
		}
	}
	class PorNombre : Strategy{
		
		public bool sosIgual(Comparable c, Comparable d){
			
			return (((Alumno)c).getNombre().CompareTo(((Alumno)d).getNombre())) == 0;
		}
		public bool sosMenor(Comparable c, Comparable d){
			
			return (((Alumno)c).getNombre().CompareTo(((Alumno)d).getNombre())) < 0;
		}
		public bool sosMayor(Comparable c, Comparable d){
			
			return (((Alumno)c).getNombre().CompareTo(((Alumno)d).getNombre())) > 0;
		}
	}
	class PorLegajo : Strategy{
		
		public bool sosIgual(Comparable c, Comparable d){
			return (((Alumno)c).getLegajo().CompareTo(((Alumno)d).getLegajo())) == 0;
		}
		public bool sosMenor(Comparable c, Comparable d){
			return (((Alumno)c).getLegajo().CompareTo(((Alumno)d).getLegajo())) < 0;
		}
		public bool sosMayor(Comparable c, Comparable d){
			return (((Alumno)c).getLegajo().CompareTo(((Alumno)d).getLegajo())) > 0;
		}
	}
	class PorPromedio : Strategy{
		
		public bool sosIgual(Comparable c, Comparable d){
			return (((Alumno)c).getPromedio().CompareTo(((Alumno)d).getPromedio())) == 0;
		}
		public bool sosMenor(Comparable c, Comparable d){
			return (((Alumno)c).getPromedio().CompareTo(((Alumno)d).getPromedio())) < 0;
		}
		public bool sosMayor(Comparable c, Comparable d){
			return (((Alumno)c).getPromedio().CompareTo(((Alumno)d).getPromedio())) > 0;
		}
	}
	// agrego mas estratgias para vendedor
	class PorBonus : Strategy{
		
		public bool sosIgual(Comparable c, Comparable d){
			return (((Vendedor)c).getBonus().CompareTo(((Vendedor)d).getBonus())) == 0;
		}
		public bool sosMenor(Comparable c, Comparable d){
			return (((Vendedor)c).getBonus().CompareTo(((Vendedor)d).getBonus())) < 0;
		}
		public bool sosMayor(Comparable c, Comparable d){
			return (((Vendedor)c).getBonus().CompareTo(((Vendedor)d).getBonus())) > 0;
		}
	}
	
}
