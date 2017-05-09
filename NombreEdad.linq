<Query Kind="Program" />

void Main()
{
	//Solicitar el ingreso del nombre y edad de dos personas. 
	//Mostrar el nombre de la persona con mayor edad.

    int edad1, edad2;
	string nombre1, nombre2;
	
	Console.Write("Ingrese nombre: ");
	nombre1 = Console.ReadLine();
	Console.WriteLine("Ingrese la edad: ");
	edad1 = int.Parse(Console.ReadLine());
	
	Console.Write("Ingrese nombre: ");
	nombre2 = Console.ReadLine();
	Console.WriteLine("Ingrese la edad: ");
	edad2 = int.Parse(Console.ReadLine());
	
     if (edad1 > edad2)
	  {
	    Console.WriteLine($"{nombre1} es mayor que {nombre2}.");
	  }
	  else
	    Console.WriteLine($"{nombre2} es mayor que {nombre1}.");
  


}

// Define other methods and classes here
