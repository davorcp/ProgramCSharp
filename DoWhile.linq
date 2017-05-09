<Query Kind="Program" />

void Main()
{
	int valor;
	
	do
	{
	Console.WriteLine("Ingrese un valor entre 0 y 999, (finaliza con 0): ");
	valor = int.Parse(Console.ReadLine());
	
	if (valor>=100)
	  {
	  Console.WriteLine("Tiene 3 dígitos.");
	  Console.WriteLine("________");
	  }
	else
	  {
	   if (valor>=10)
	   {
	    Console.WriteLine("Tiene 2 dígitos.");
		Console.WriteLine("________");
	   }
	   else
	   {
	    Console.WriteLine("Tiene 1 dígito.");
		Console.WriteLine("________");
		}
	  }  
		
	}
     while (valor != 0);
	 
	 Console.WriteLine("Fin del programa");
	
	
}

// Define other methods and classes here
