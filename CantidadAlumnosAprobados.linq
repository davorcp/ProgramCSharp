<Query Kind="Program" />

void Main()
{
	
	int a, na, cant;
	float nota;
	a = na = 0;
	Console.WriteLine("Por favor indique la cantidad de notas que va a ingresar: ");
	cant = int.Parse(Console.ReadLine());
	while ((a+na) < cant)
	  {
	  
	   Console.WriteLine("Ingrese nota de alumno: ");
	   nota = float.Parse(Console.ReadLine());
	   if (nota >= 7)
	     a = a + 1;		 
		 
		 else
	     na = na + 1;
	  
	  }
	
	Console.WriteLine($"Cantidad de alumnos aprobados: {a}, y alumnos no aprobados: {na}");
	
}

// Define other methods and classes here
