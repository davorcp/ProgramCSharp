<Query Kind="Program" />

void Main()
{
	/*
	Realizar un programa que permita ingresar el peso (en kilogramos) de piezas. 
	El proceso termina cuando ingresamos el valor 0. Se debe informar:
    a) Cuántas piezas tienen un peso entre 9.8 Kg. y 10.2 Kg.?, cuántas con más de 10.2 Kg.?
	y cuántas con menos de 9.8 Kg.?
    b) La cantidad total de piezas procesadas.
	*/
	
	int cant1, cant2, cant3, canttot;
	float peso;
	Console.WriteLine("***PARA FINALIZAR LA CARGA, CARGUE EL VALOR 0 Y PRESIONE ENTER***");
	cant1 = 0;
	cant2 = 0;
	cant3 = 0;
	
	do
    {
	  Console.WriteLine("Ingrese el peso (en kilogramos) de la pieza: ");
	  peso = float.Parse(Console.ReadLine());
	  Console.WriteLine($"_______________El peso ingresado es: {peso}_______________");
	
	if ((peso>=9.8) && (peso<=10.2))
	  {
	   cant1++;
	  }
	  
	  else
	  {
	    if (peso>10.2)
	    {
		  cant2++;
		}
	    else
	      cant3++;
	  }
	  if (peso == 0)
	   cant3--;
	}
	while (peso!=0);
	
	 canttot = cant1 + cant2 + cant3;
	 Console.WriteLine($"Cantidad de piezas con peso entre 9.8kg y 10.2kg: {cant1}");
	 Console.WriteLine("__________");
	 Console.WriteLine($"Cantidad de piezas con peso mayor a 10.2kg: {cant2}");
	 Console.WriteLine("__________");
	 Console.WriteLine($"Cantidad de piezas con peso menor a 9.8kg: {cant3}");
	 Console.WriteLine("__________");
	Console.WriteLine($"Cantidad total de piezas ingresadas: {canttot}");
	
	
}

// Define other methods and classes here
