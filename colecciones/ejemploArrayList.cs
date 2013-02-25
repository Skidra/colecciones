using System;
using System.Collections;

namespace colecciones
{
	public class ejemploArrayList
	{
		public ejemploArrayList ()
		{
		}
		
		public void mostrar(){
			ArrayList myArrayList = new ArrayList();
	      	myArrayList.Add("Hola");
	      	myArrayList.Add("Mundo");
	      	myArrayList.Add("!");
			
			myArrayList.Remove("!");
	
	      	Console.WriteLine( "Ejemplo de ArrayList" );
	      	Console.WriteLine( "    Count:    {0}", myArrayList.Count );
	      	Console.WriteLine( "    Capacity: {0}", myArrayList.Capacity );
	      	Console.Write( "    Values:" );
	      	PrintValues( myArrayList );
			Console.WriteLine();
		}
		
		private static void PrintValues( IEnumerable myList )  {
      		foreach ( Object obj in myList ){
         		Console.Write( "   {0}", obj );
			}
      		Console.WriteLine();
   		}
	}
}

