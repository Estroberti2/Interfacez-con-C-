/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 13:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Actividad_7
{
	/// <summary>
	/// Description of Vendedor.
	/// </summary>
	public class Vendedor: Persona, IObservado
	{
		double sueldoBasico;
		double bonus;
		double montoVendido;
		Strategy strategy = new PorBonus();
		List<IObservador> iobservadores = new List<IObservador>();
		
		public Vendedor(string nom, int dni, double s):base(nom, dni)
		{
			this.sueldoBasico = s;
			this.bonus = 1;
		}
		
		public double getBonus(){
			return bonus;
		}
		
		public double getMontoVendido(){
			return montoVendido;
		}
		
		public override bool sosIgual(Comparable c){
			
			return strategy.sosIgual(this, c);
		}
		
		public override bool sosMenor(Comparable c){
			
			return strategy.sosMenor(this, c);
		}
		
		public override bool sosMayor(Comparable c){
			
			return strategy.sosMayor(this, c);
		}
		
		public override string toString(){
			string s = "Nombre: " + this.getNombre() + " DNI: " + this.getDni() + " Sueldo Base: "  + this.sueldoBasico + " Bonus: "  + this.bonus;
			return s;
		}
		
		public void venta(double monto){
			Console.WriteLine("La venta efectuada es de: " + monto);
			montoVendido = monto;
			notificar();
		}
		
		public void aumentaBonus(){
			this.bonus += 0.1;
		}
		
		public void agregarObservador(IObservador o){
			iobservadores.Add(o);
		}
		
		public void quitarObservador(IObservador o){
			iobservadores.Remove(o);
		}
		
		public void notificar(){
			foreach(IObservador o in iobservadores)
				o.actualizar(this);
		}
	}
}
