/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 12/10/2022
 * Hora: 15:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of TemplateMethod.
	/// </summary>
	public abstract class TemplateMethod
	{
		public void jugar(){
			mezclarMazo();
			repartir();
			while(!hayGanador()){
				jugarMano();
			}
			mostrarGanador();
		}
		public abstract void mezclarMazo();
		
		public abstract void repartir();
		
		public abstract void jugarMano();
		
		public abstract bool hayGanador();

		public abstract void mostrarGanador();
	}
}
