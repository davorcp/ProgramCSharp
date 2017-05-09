<Query Kind="Program" />

void Main()
{
	/*
	En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, realizar un programa que lea los sueldos
	que cobra cada empleado e informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300. Además el 
	programa deberá informar el importe que gasta la empresa en sueldos al personal.
	*/
	
	int cantem, x, sueldo, mas, menos, gasto;
	
	Console.WriteLine("Ingrese cuantos empleados estan trabajando actualmente: ");
	cantem = int.Parse(Console.ReadLine());
	x = 1;
	mas = 0;
	menos = 0;
	gasto = 0;
	
	while (x <= cantem)
	{
	 
	 Console.WriteLine("Ingrese el sueldo de su empleado: ");
	 sueldo = int.Parse(Console.ReadLine());
	  if (sueldo > 300)
	   {
	   mas++;
	   gasto = gasto + sueldo;
	   }
	  else
	   {
	   menos++;
	   gasto = gasto + sueldo;
	   }
	 x++;
	}
	
	Console.WriteLine($"Cantidad de empleados que cobran entre $100 y $300: {menos}");
	Console.WriteLine($"Cantidad de empleados que cobran mas de $300: {mas}");
	Console.WriteLine($"Gasto en sueldos de la empresa es: ${gasto}");	
}

// Define other methods and classes here
