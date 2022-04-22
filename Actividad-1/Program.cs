/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 6/4/2022
 * Hora: 10:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Actividad_1
{
//	---  Ejercicio 1 -----------------------------
	
	interface Comparable{
		bool sosIgual(Comparable c);
		bool sosMenor(Comparable c);
		bool sosMayor(Comparable c);
	}
	
//	---  Ejercicio 2 -----------------------------

	class Numero : Comparable{
		private int valor;
		
		public Numero(int v){
			valor = v;
		}
		
		public int getValor(){
			return valor;
		}
		
		public bool sosIgual(Comparable c){
			return this.getValor() == ((Numero) c).getValor();
		}
		
		public bool sosMenor(Comparable c){
			return this.getValor() < ((Numero) c).getValor();
		}
		
		public bool sosMayor(Comparable c){
			return this.getValor() > ((Numero) c).getValor();
		}
	}
	
//	---  Ejercicio 3 -----------------------------
	
	interface Coleccionable{
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable c);
		bool contiene(Comparable c);
	}
	
//	---  Ejercicio 4 -----------------------------
	
	class Pila : Coleccionable{
		
		private List<Comparable> elementos;
		
		public Pila(){
			elementos = new List<Comparable>();
		}
		
		public void push(Comparable c){
			elementos.Add(c);
		}
		
		public void pop(){
			this.elementos.RemoveAt(elementos.Count -1);
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
	}
	
	class Cola : Coleccionable{
		
		private List<Comparable> elementos;
		
		public Cola(){
			elementos = new List<Comparable>();
		}
		
		public void push(Comparable c){
			elementos.Add(c);
		}
		
		public void pop(){
			this.elementos.RemoveAt(0);
		}
		
		public int cuantos(){
			return this.elementos.Count;
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
	}
	
//	---  Ejercicio 8 -----------------------------
	
	class ColeccionMultiple : Coleccionable{
		Pila pila;
		Cola cola;
		
		public ColeccionMultiple(Pila p, Cola c){
			this.pila = p;
			this.cola = c;
		}
		
		public int cuantos(){
			return pila.cuantos() + cola.cuantos();
		}
		
		public Comparable minimo(){
			if(pila.minimo().sosMenor(cola.minimo())){
				return pila.minimo();
			}
			return cola.minimo();
		}
		
		public Comparable maximo(){
			if(pila.maximo().sosMayor(cola.maximo())){
				return pila.maximo();
			}
			return cola.maximo();
		}
		
		public void agregar(Comparable c){
			// no hace nada
		}
		
		public bool contiene(Comparable c){
			
			if(pila.contiene(c) || cola.contiene(c)){
				return true;
			}
			return false;
		}
	}
	
//	---  Ejercicio 11 -----------------------------
	
//	class Persona : Comparable{
//		
//		string nombre;
//		int dni;
//		
//		public Persona(string nom, int dni){
//			this.nombre = nom;
//			this.dni = dni;
//		}
//		
//		public string getNombre(){
//			return nombre;
//		}
//		
//		public int getDni(){
//			return dni;
//		}
//		
//		public bool sosIgual(Comparable c){
//			
//			if(((Persona)c).dni == this.dni){
//				return true;
//			}
//			return false;
//		}
//		
//		public bool sosMenor(Comparable c){
//			
//			if(((Persona)c).dni < this.dni){
//				return true;
//			}
//			return false;
//		}
//		
//		public bool sosMayor(Comparable c){
//			
//			if(((Persona)c).dni > this.dni){
//				return true;
//			}
//			return false;
//		}
//	}
	
//	---  Ejercicio 15 -----------------------------
	
//	class Alumno : Persona, Comparable{
//		
//		int legajo;
//		int promedio;
//		
//		public Alumno(string n, int d, int l, int p):base(n, d){
//			
//			this.legajo = l;
//			this.promedio = p;
//		}
//		
//		public int getLegajo(){
//			return legajo;
//		}
//		
//		public int getPromedio(){
//			return promedio;
//		}
//		
//		//	---  Ejercicio 18 -----------------------------
//		
//		public bool sosIgual(Comparable c){
//			
//			if(((Alumno)c).promedio == this.promedio){
//				return true;
//			}
//			return false;
//		}
//		
//		public bool sosMenor(Comparable c){
//			
//			if(((Alumno)c).promedio < this.promedio){
//				return true;
//			}
//			return false;
//		}
//		
//		public bool sosMayor(Comparable c){
//			
//			if(((Alumno)c).promedio > this.promedio){
//				return true;
//			}
//			return false;
//		}
//	}
	
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
	

	

	
	class Program
	{
		
		//	---  Ejercicio 5 -----------------------------
		
		public static void llenar(Coleccionable c){
			Random random = new Random();
			for(int i = 0; i < 20; i++){
				c.agregar(new Numero(random.Next(1, 100)));
			}
		}
		
		//	---  Ejercicio 6 -----------------------------
		
		public static void informar(Coleccionable c){
			
			Console.WriteLine(c.cuantos());
			Console.WriteLine(c.minimo());
			Console.WriteLine(c.maximo());
			
			Comparable com = new Numero(Convert.ToInt32(Console.ReadLine()));
			
			if(c.contiene(com)){
				Console.WriteLine("El elemento leído está en la colección");
			}
			else{
				Console.WriteLine("El elemento leído no está en la colección");
			}
		}
		
		public static string stringAleatorio(){
			
			string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			char[] Charsarr = new char[8];
            Random random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }

            string resultString = new String(Charsarr);
            
            return resultString;
		}
		
		//	---  Ejercicio 12 -----------------------------
		public static void llenarPersonas(Coleccionable c){
			
			Comparable comparable;
			string nombre;
			int dni;
			Random random = new Random();
			
			for(int i = 0; i < 20; i++){
				
				dni = random.Next(1, 100000000);
				nombre = stringAleatorio();
				comparable = new Persona(nombre, dni);
				c.agregar(comparable);
			}
		}
		
		//	---  Ejercicio 16 -----------------------------
		
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
		
		
		public static void Main(string[] args)
		{
		
			//	---  Ejercicio 7 -----------------------------
			
//			Coleccionable pila = new Pila();
//			Coleccionable cola = new Cola();
//			
//			llenar(pila);
//			llenar(cola);
//			
//			informar(pila);
//			informar(cola);
			
			//	---  Ejercicio 9 -----------------------------
			
//			Coleccionable pila = new Pila();
//			Coleccionable cola = new Cola();
//			
//			Coleccionable multiple = new ColeccionMultiple((Pila)pila, (Cola)cola);
//			
//			llenar(pila);
//			llenar(cola);
//			
//			informar(pila);
//			informar(cola);
//			informar(multiple);
			
			//	---  Ejercicio 13 -----------------------------
			
//			Coleccionable pila = new Pila();
//			Coleccionable cola = new Cola();
//			
//			Coleccionable multiple = new ColeccionMultiple((Pila)pila, (Cola)cola);
//			
//			llenarPersonas(pila);
//			llenarPersonas(cola);
//			
//			informar(pila);
//			informar(cola);
//			
//			informar(multiple);
			
			//	---  Ejercicio 14 -----------------------------
			/*
				cree una funcion ramdon que me genere string aleatorios 
			*/
			
			//	---  Ejercicio 17 -----------------------------
			
			Coleccionable pila = new Pila();
			Coleccionable cola = new Cola();
			
			Coleccionable multiple = new ColeccionMultiple((Pila)pila, (Cola)cola);
			
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			
			informar(pila);
			informar(cola);
			
			informar(multiple);
			
			/*
			 Responda 
				¿Funcionó? 
					si
					
				¿Fue necesario decir explícitamente que Alumno tiene que implementar la interface Comparable? 
					no porque ya heredaba dicha funcionalidad de la clase persona
				
				¿Cuál fue el criterio por el cual se comparó a los alumnos? 
					lo compara con el criterio configurado en persona (por dni)
				
				¿Por qué?
					por herencia
			*/
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		//	---  Ejercicio 10 -----------------------------
		/*
			se tuvo que castear la pila y la cola al pasarlo como parametro de ColeccionMultiple 
		*/
		
	}
}