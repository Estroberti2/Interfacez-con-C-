/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 11:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;


namespace Actividad_7
{
	class Program
	{
		public static void CrearProxyYComposite(Pila p)
		{
			for (int i = 0; i < 16; i++) {
				if(i == 0){
					// composite
					p.push((FactoryMethod.crearAleatorio(6, 0)));
				}
				else{
					// alumno normal/estudioso
					p.push((FactoryMethod.crearAleatorio(5, 0)));	
				}
			}
			p.terminar();
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("--------------------- TEMPLATE METHOD -----------------");
			Console.WriteLine("----------------------- Composite");
			
			Aula a = new Aula();
			Pila p = new Pila();
			
			// creamos las ordenes
			OrdenEnAula1 o1= new OrdenInicio(a);
			OrdenEnAula2 o2= new OrdenLlegaAlumno(a);
			OrdenEnAula1 o3= new OrdenAulaLlena(a);
			
			// las seteamos a pila
			p.setOrdenInicio(o1);
			p.setOrdenLlegaAlumno(o2);
			p.setOrdenAulaLlena(o3);
			
			// llenamos
			CrearProxyYComposite(p);
            
			Console.ReadKey(true);
		}
	}
}