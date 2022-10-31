/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 28/9/2022
 * Hora: 11:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of FabricaDeProxyAlumno.
	/// </summary>
	public class FabricaDeProxyAlumno : FactoryMethod
	{
		public override Comparable crearAleatorio(ChainOfResponsability s,int que = 0){
			// generamos uno texto max 8
			
			if(que == 0){
				que = ((s.numeroAleatorio(10) %2 == 0) ? 1 : 2);
			}
			return new ProxyAlumno(
					s.stringAleatorio(8),
					s.numeroAleatorio(99999999),
					s.numeroAleatorio(99999),
					s.numeroAleatorio(9),
					que
			);
		}
//		public override Comparable crearAleatorio(){
//			// generamos uno texto max 8
//			GeneradorDeDatosAleatorios rng = new GeneradorDeDatosAleatorios();
//			int a = 0;
//			a = (rng.numeroAleatorio(10) %2 == 0) ? 1 : 2;
//			return new ProxyAlumno(
//					rng.stringAleatorio(8),
//					rng.numeroAleatorio(99999999),
//					rng.numeroAleatorio(99999),
//					rng.numeroAleatorio(9),
//					a
//			);
//		}
		public override Comparable crearTeclado(ChainOfResponsability s){
			
			return new ProxyAlumno( 
					s.stringPorTeclado(),
					s.numeroPorTeclado(),
					s.numeroPorTeclado(),
					s.numeroPorTeclado(),
					s.numeroPorTeclado()
			);
		}
	}
}
