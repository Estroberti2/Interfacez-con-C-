/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 18/4/2022
 * Hora: 13:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Actividad_2
{
	// se aplica strategy cuando necesitamos muchas variantes de un mismo algoritmo
	
	// --  EJERCICIO 1 ----------------------------------------------------------------------------
		
	interface Comparable{
		
		bool sosIgual(Comparable c);
		bool sosMenor(Comparable c);
		bool sosMayor(Comparable c);
	}
	
	interface Strategy{
		
		bool sosIgual(Comparable c, Comparable d);
		bool sosMenor(Comparable c, Comparable d);
		bool sosMayor(Comparable c, Comparable d);
	}
	
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
			return (((Alumno)c).getDni().CompareTo(((Alumno)d).getDni())) == 0;
		}
		public bool sosMenor(Comparable c, Comparable d){
			return (((Alumno)c).getDni().CompareTo(((Alumno)d).getDni())) < 0;
		}
		public bool sosMayor(Comparable c, Comparable d){
			return (((Alumno)c).getDni().CompareTo(((Alumno)d).getDni())) > 0;
		}
	}
	class PorLegajo : Strategy{
		
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
	class PorPromedio : Strategy{
		
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
	class Persona : Comparable{
		
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
	}
	
	class Alumno : Persona{
		
		int legajo;
		int promedio;
		Strategy strategy;
		
		public Alumno(string n, int d, int l, int p):base(n, d){
			
			this.legajo = l;
			this.promedio = p;
			strategy = new PorDni();
		}
		
		public int getLegajo(){
			return legajo;
		}
		
		public int getPromedio(){
			return promedio;
		}
		
		public void cambiarEstrategia(Strategy s){
			this.strategy = s;
		}
		
		
		public override bool sosIgual(Comparable c){
			
			return strategy.sosIgual(this, c);
		}
		
		public override bool sosMenor(Comparable c){
			
			return strategy.sosIgual(this, c);
		}
		
		public override bool sosMayor(Comparable c){
			
			return strategy.sosIgual(this, c);
		}
	}
	
	interface Coleccionable{
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable c);
		bool contiene(Comparable c);
	}
	
	interface Iterable{
		Iterator crearIterator();
	}
	
	interface Iterator{
		int cuantos();
		void primero();
		void siguiente();
		bool fin();
		Iterable contiene(Comparable c);
	}
	
	
	// --  EJERCICIO 3 Y 5 ----------------------------------------------------------------------------
	class Conjunto : Coleccionable{
		
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
	}
	
	// --  EJERCICIO 4 Y 5 ----------------------------------------------------------------------------
	class ClaveValor{
		Comparable clave;
		Comparable valor;
		
		public ClaveValor(Comparable c, Comparable v){
			clave = c;
			valor = v;
		}
	}
	
	class Diccionario : Coleccionable{
		
		List<Conjunto> dic;
		
		public Diccionario(){
			dic = new List<Conjunto>();
		}
		
		public void agregar(Comparable clave,Comparable valor){
			
			foreach(Conjunto c in dic){
				
				if((c.getConjunto()[0].sosIgual(clave))){
				  	 
					c.getConjunto()[1] = valor;
				}
				else{
					Conjunto d = new Conjunto();
					d.agregar((Comparable)new ClaveValor(clave, valor));
					dic.Add(d);
				}
			}
		}
	
		public Comparable valorDe(Comparable clave){
			foreach(Conjunto c in dic){
				
				if((c.getConjunto()[0].sosIgual(clave))){
					
					return (Comparable)c.getConjunto()[1];
				}
			}
			return null;
		}
		
		public int cuantos(){
			return dic.Count;
		}
		
		public Comparable minimo(){
			
			Comparable minimo = dic[0].getConjunto()[1];
			
			for(int i = 1; i < dic.Count; i++){
				if(((Comparable)dic[i].getConjunto()[1]).sosMenor(minimo)){
					minimo = ((Comparable)dic[i].getConjunto()[1]);
				}
			}
			return minimo;
		}
		
		public Comparable maximo(){
			
			Comparable maximo = ((Comparable)dic[0].getConjunto()[1]);
			
			for(int i = 1; i < dic.Count; i++){
				if(((Comparable)dic[i].getConjunto()[1]).sosMayor(maximo)){
					maximo = ((Comparable)dic[i].getConjunto()[1]);
				}
			}
			return maximo;
		}
		
		public void agregar(Comparable c){
			
		}
		public bool contiene(Comparable valor){
			
			foreach(Conjunto c in dic){
				if(((Comparable)c.getConjunto()[1]).sosIgual(valor)){
					return true;
				}
			}
			return false;
		}
	}
	
	
	
	
	
	class Program
	{
		// --  EJERCICIO 2 ----------------------------------------------------------------------------
		
		public static void llenarAlumnos(Coleccionable c){
			
			Comparable comparable;
			string nombre;
			int dni;
			int legajo;
			int promedio;
			Random random = new Random();
			
			for(int i = 0; i < 20; i++){
				
				dni = random.Next(1, 100000000);
				nombre = stringAleatorio();
				legajo = random.Next(1, 1000000);
				promedio = random.Next(1, 10);
				
				comparable = new Alumno(nombre, dni, legajo, promedio);
				if(i%2 == 0){
					Strategy s = new PorLegajo();
						((Alumno)comparable).cambiarEstrategia(s);
				}
				c.agregar(comparable);
			}
		}
		
		
		
		
		
		
		
		// --  EJERCICIO 5 ----------------------------------------------------------------------------
		// --  EJERCICIO 6 ----------------------------------------------------------------------------
		// --  EJERCICIO 7 ----------------------------------------------------------------------------
		// --  EJERCICIO 8 ----------------------------------------------------------------------------
		// --  EJERCICIO 9 ----------------------------------------------------------------------------
		// --  EJERCICIO 10 ----------------------------------------------------------------------------
		// --  EJERCICIO 11 ----------------------------------------------------------------------------
		// --  EJERCICIO 12 ----------------------------------------------------------------------------
		// --  EJERCICIO 13 ----------------------------------------------------------------------------
		// --  EJERCICIO 14 ----------------------------------------------------------------------------
		// --  EJERCICIO 15 ----------------------------------------------------------------------------
		// --  EJERCICIO 16 ----------------------------------------------------------------------------
		
		
		public static void Main(string[] args)
		{
			// --  EJERCICIO 2 ----------------------------------------------------------------------------
		
			Coleccionable pila = new Pila();
			Coleccionable cola = new Cola();
			
			Coleccionable multiple = new ColeccionMultiple((Pila)pila, (Cola)cola);
			
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			
			informar(pila);
			informar(cola);
			
			informar(multiple);
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}