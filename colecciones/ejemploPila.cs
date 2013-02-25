using System;
using System.Collections;

namespace colecciones
{
	public class ejemploPila
	{
		public ejemploPila ()
		{
		}
		
		public void mostrar(){
			Stack miPila = new Stack();
	       	miPila.Push("Hola");
	       	miPila.Push("Mundo");
	       	miPila.Push("!");
	
	       	Console.WriteLine( "Ejemplo de Pila" );
	       	Console.WriteLine( "\tCount:    {0}", miPila.Count );
	       	Console.Write( "\tValues:" );
	       	PrintValues( miPila );
			Console.WriteLine();
		}
		
		private static void PrintValues( IEnumerable myCollection )  {
			foreach ( Object obj in myCollection ){
          		Console.Write( "    {0}", obj );
			}
			
       		Console.WriteLine();
    	}
	}
}

