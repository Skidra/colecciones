using System;
using System.Collections;

namespace colecciones
{
	public class ejemploHashTable
	{
		public ejemploHashTable ()
		{
		}
		
		public void mostrar(){
			Console.WriteLine("Ejemplo de Hashtable");
	        Hashtable hashtable = new Hashtable();
	        
	        hashtable.Add("txt", "notepad.exe");
	        hashtable.Add("bmp", "paint.exe");
	        hashtable.Add("dib", "paint.exe");
	        hashtable.Add("rtf", "wordpad.exe");
	        
	        try
	        {
	            hashtable.Add("txt", "winword.exe");
	        }
	        catch
	        {
	            Console.WriteLine("Un elemento con la llave = \"txt\" ya existe.");
	        }
	
	        Console.WriteLine("Para la llave = \"rtf\", valor = " + hashtable["rtf"]);
	        
	        hashtable["rtf"] = "winword.exe";
	        Console.WriteLine("Para la llave = \"rtf\", valor = " + hashtable["rtf"]);
	        
	
	        hashtable["doc"] = "winword.exe";
	
	        try
	        {	Console.WriteLine("Para la llave = \"tif\", valor = " + hashtable["tif"]);
	        }
	        catch
	        {
	            Console.WriteLine("Llave = \"tif\" no existe.");
	        }
	
	        if (!hashtable.ContainsKey("ht"))
	        {
	            hashtable.Add("ht", "hypertrm.exe");
	            Console.WriteLine("Valor agregado para la llave = \"ht\": " + hashtable["ht"]);
	        }
	
	        Console.WriteLine();
	        foreach( DictionaryEntry de in hashtable )
	        {
	            Console.WriteLine("Llave = " + de.Key + ", Valor = " + de.Value);
	        }
	
	        ICollection valueColl = hashtable.Values;
	        
	        Console.WriteLine();
	        foreach( string s in valueColl )
	        {
	            Console.WriteLine("Valor = " + s);
	        }
	
	        ICollection keyColl = hashtable.Keys;
	        
	        Console.WriteLine();
	        foreach( string s in keyColl )
	        {
	            Console.WriteLine("Llave = " + s);
	        }
	
	        Console.WriteLine("\nRemover(\"doc\")");
	        hashtable.Remove("doc");
	        
	        if (!hashtable.ContainsKey("doc"))
	        {
	            Console.WriteLine("Llave \"doc\" no se encuentra.");
	        }
		}
	}
}

