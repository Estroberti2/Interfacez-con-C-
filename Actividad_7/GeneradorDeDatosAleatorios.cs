/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 10/9/2022
 * Hora: 12:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorios.
	/// </summary>
	public class GeneradorDeDatosAleatorios : ChainOfResponsability
	{
		static Random random = new Random();
		
		public GeneradorDeDatosAleatorios(ChainOfResponsability s):base(s){
			
		}
		
		public override int numeroAleatorio(int max){
			
//			Random random = new Random();
			int num  = random.Next(0, (max + 1));
			return num;
		}
		
		public override string stringAleatorio(int cant){
			
			string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			char[] Charsarr = new char[cant];
			//            Random random = new Random();

			for (int i = 0; i < Charsarr.Length; i++){
				Charsarr[i] = characters[random.Next(characters.Length)];
			}

			string resultString = new String(Charsarr);
			return resultString;
		}
	}
}
