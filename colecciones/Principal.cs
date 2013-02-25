using System;

namespace colecciones
{
	class Principal
	{
		public static void Main (string[] args)
		{
			ejemploArrayList arraylist = new ejemploArrayList();
			arraylist.mostrar();
			
			ejemploPila pila = new ejemploPila();
			pila.mostrar();
			
			ejemploCola cola = new ejemploCola();
			cola.mostrar();
			
			ejemploHashTable hashtable = new ejemploHashTable();
			hashtable.mostrar();
		}
	}
}

