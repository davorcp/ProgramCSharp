<Query Kind="Program" />

void Main()
{
	/*
	Se ingresan un conjunto de n alturas de personas por teclado. Mostrar la altura promedio de las personas.
	*/
	
	int x, n;
	float alt, prom;
	
	Console.WriteLine("Ingrese la cantidad de personas: ");
	n = int.Parse(Console.ReadLine());
	Console.WriteLine("-");
	prom = 0;
	x = 1;
	
	while (x <= n)
	 {	   	   
	   Console.WriteLine ("Ingrese la altura: ");
	   alt = float.Parse(Console.ReadLine());
	   prom = prom + alt;
	   x++;
	 }
	 prom = prom / n;
	 Console.WriteLine(prom);
}

// Define other methods and classes here
