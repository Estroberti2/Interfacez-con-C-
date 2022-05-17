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
	interface Comparable{
		
		bool sosIgual(Comparable c);
		bool sosMenor(Comparable c);
		bool sosMayor(Comparable c);
		string toString();
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
		
		public virtual string toString(){
			string s = this.nombre + " " + this.dni;
			return s;
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
		public override string toString(){
			string s = "Nombre: " + this.getNombre() + " DNI; " + this.getDni() + " Legajo: "  + this.getLegajo() + " Promedio: "  + this.getPromedio();
			return s;
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
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();
	}
	
	class Iterador : Iterator{
		
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
	
	class Conjunto : Coleccionable, Iterable{
		
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
		
		#region Iterable implementation

		public Iterator crearIterator()
		{
			return new Iterador(conjunto);
		}
		
		#endregion
	}
	
	class ClaveValor : Comparable{
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
	
	class Diccionario : Coleccionable, Iterable{
		
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
			bool agregado = false;
			foreach(ClaveValor c in dic){
				if(!c.tieneClaveNum()){
					if(c.getClave().sosIgual(v)){
						c.cambiarValor(v);
						agregado = true;
					}
				}
			}
			if(!agregado){
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
	
	class Pila : Coleccionable, Iterable{
		
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

		#region Iterable implementation

		public Iterator crearIterator()
		{
			return new Iterador(elementos);
		}

		#endregion
	}
	
	class Cola : Coleccionable, Iterable{
		
		List<Comparable> elementos;
		
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

		#region Iterable implementation

		public Iterator crearIterator()
		{
			return new Iterador(elementos);
		}

		#endregion
	}
	
	
	
	
	
	class Program
	{
		
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
				if(i%3 == 0){
					Strategy s = new PorDni();
					((Alumno)comparable).cambiarEstrategia(s);
				}
				if(i%5 == 0){
					Strategy s = new PorNombre();
					((Alumno)comparable).cambiarEstrategia(s);
				}
				if(i%7 == 0){
					Strategy s = new PorPromedio();
					((Alumno)comparable).cambiarEstrategia(s);
				}
				c.agregar(comparable);
			}
		}
		
		public static void cambiarEstrategia(Coleccionable c, Strategy s){
			
			Iterador i = (Iterador)(c as Iterable).crearIterator();
			while(!i.fin()){
				((Alumno)i.actual()).cambiarEstrategia(s);
				i.siguiente();
			}
		}
		
		public static void imprimirElementos(Iterable c){
			
			Iterador i = (Iterador)c.crearIterator();
			while(!i.fin()){
				Console.WriteLine( (i.actual()).toString() );
				i.siguiente();
			}
		}
		
		public static void llenarDiccionario(Diccionario d){
			
			Comparable comparableC;
			Comparable comparableV;
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
				
				comparableC = new Alumno(nombre, dni, legajo, promedio);
				
				dni = random.Next(1, 100000000);
				nombre = stringAleatorio();
				legajo = random.Next(1, 1000000);
				promedio = random.Next(1, 10);
				
				comparableV = new Alumno(nombre, dni, legajo, promedio);
				
				d.agregar(comparableC, comparableV);
			}
		}
		
		public static void Main(string[] args)
		{
			// --  EJERCICIO 2 ----------------------------------------------------------------------------
		
			Iterable pila = new Pila();
			Iterable cola = new Cola();
			Iterable conjunto = new Conjunto();
			Iterable diccionario = new Diccionario();
			
			llenarAlumnos((Coleccionable)pila);
			llenarAlumnos((Coleccionable)cola);
			llenarAlumnos((Coleccionable)conjunto);
			llenarDiccionario(diccionario as Diccionario);
			
//			Console.WriteLine(" Iterable Pila \n");
//			imprimirElementos(pila);
//			Console.ReadKey(true);
//			
//			Console.WriteLine("\n Iterable Cola \n");
//			imprimirElementos(cola);
//			Console.ReadKey(true);
//			
//			Console.WriteLine("\n Iterable Conjunto \n");
//			imprimirElementos(conjunto);
//			Console.ReadKey(true);
//			
//			Console.WriteLine("\n Iterable Diccionario \n");
//			imprimirElementos(diccionario);
//			Console.ReadKey(true);
			
			Console.WriteLine("\n Cambio Estrategia Promedio \n");
			Strategy p = new PorPromedio();
			cambiarEstrategia((Coleccionable)pila, p);
			Console.WriteLine(((Coleccionable)pila).minimo().toString());
			Console.ReadKey(true);
			
			Console.WriteLine("\n Cambio Estrategia Legajo \n");
			Strategy l = new PorLegajo();
			cambiarEstrategia((Coleccionable)pila, l);
			Console.WriteLine(((Coleccionable)pila).minimo().toString());
			Console.ReadKey(true);
			
			Console.WriteLine("\n Cambio Estrategia Dni \n");
			Strategy d = new PorDni();
			cambiarEstrategia((Coleccionable)pila, d);
			Console.WriteLine(((Coleccionable)pila).minimo().toString());
			Console.ReadKey(true);
			
			Console.WriteLine("\n Cambio Estrategia Nombre \n");
			Strategy n = new PorNombre();
			cambiarEstrategia((Coleccionable)pila, n);
			Console.WriteLine(((Coleccionable)pila).minimo().toString());
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}