/*
 * Creado por SharpDevelop.
 * Usuario: almma
 * Fecha: 29/9/2022
 * Hora: 11:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Actividad_7
{
	/// <summary>
	/// Description of Aula.
	/// </summary>
	public class Aula
	{
		Teacher t = null;
		public Aula()
		{
		}
		public void Comenzar()
		{
			t = new Teacher();
		}
		public void nuevoAlumno(IAlumnos a)
		{
			Adapter ad = new Adapter(a);
			t.goToClass(ad);
		}
		public void claseLista()
		{
			t.teachingAClass();	
		}
	}
}
