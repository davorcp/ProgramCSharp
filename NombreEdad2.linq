<Query Kind="Program" />

//Confeccionar una clase que permita carga el nombre y la edad de una persona. 
//Mostrar los datos cargados. Imprimir un mensaje si es mayor de edad (edad>=18)

class Persona
  {
   private string nombre;
   private int edad;
    
	public void Inicializar()
    {
	  
	  Console.Write("Ingrese el nombre: ");
	  nombre = Console.ReadLine();
	  Console.WriteLine("Ingrese la edad: ");
	  edad = int.Parse(Console.ReadLine());	
		
    }
	
	public void Imprimir()
	{
	 
	  Console.WriteLine($"{nombre}");
	  Console.WriteLine($"{edad}");
		
	}
	
	public void EsMayorEdad()
	{
	
	  if (edad>18)
	    Console.WriteLine("Es mayor de edad");
		else
		  Console.WriteLine("Es menor de edad");
	
	}
	
	static void Main(string[] args)
	{
	
	  Persona per1 = new Persona();
        per1.Inicializar();
        per1.Imprimir();
        per1.EsMayorEdad();
	
	}
   
  }
// Define other methods and classes here
