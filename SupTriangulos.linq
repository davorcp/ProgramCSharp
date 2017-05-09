<Query Kind="Program" />

void Main()
{
	/*
	Confeccionar un programa que lea n pares de datos, cada par de datos corresponde
	a la medida de la base y la altura de un triángulo. El programa deberá informar:
    a) De cada triángulo la medida de su base, su altura y su superficie. 
    b) La cantidad de triángulos cuya superficie es mayor a 12.
	*/
	
	int f, cant, supmayor;
	float ba, alt, sup;
	Console.WriteLine("Ingrese la cantidad de triángulos que desee: ");
	cant = int.Parse(Console.ReadLine());
	Console.WriteLine("--");
	supmayor = 0;
	
	for (f=1;f<=cant;f++)
	
	  {
	    Console.WriteLine($"Ingrese la medida de la base del triángulo {f} en cm: ");
	    ba = float.Parse(Console.ReadLine());
		Console.WriteLine($"Ahora ingrese la altura del triángulo {f} también en cm: ");
	    alt = float.Parse(Console.ReadLine());
		sup = (ba * alt) / 2;
		Console.WriteLine($"Triangulo {f}, su base es de: {ba} cm, su altura es: {alt} cm, y su superficie es de: {sup} cm2");
		Console.WriteLine("--");
		if (sup>12)
		 supmayor++;
	
	  }
    Console.WriteLine("--");
	Console.WriteLine($"Cantidad de triangulos con superficie mayor a 12 cm2: {supmayor}");
		
}

// Define other methods and classes here
