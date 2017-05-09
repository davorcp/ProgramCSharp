<Query Kind="Program" />

void Main()
{
	/*
	Escribir un programa que lea 10 números enteros y luego muestre
	cuántos valores ingresados fueron múltiplos de 3 y cuántos de 5.
	Debemos tener en cuenta que hay números que son múltiplos de 3 y de 5 a la vez.
	*/
	
	int f, mul3, mul5, valor;
	mul3 = 0;
	mul5 = 0;
	
	for (f=1;f<=10;f++)
	{
	  Console.WriteLine($"Ingrese el valor nº {f}:");
	  valor = int.Parse(Console.ReadLine());
	  Console.WriteLine("--");
	  
	  if ((valor%3)==0)
	   mul3++;
	  
	  if ((valor%5)==0)
	   mul5++;
	  
			
	}
	Console.WriteLine($"Multiplos de 3: {mul3}");
	Console.WriteLine("--");
	Console.WriteLine($"Multiplos de 5: {mul5}");
}



// Define other methods and classes here
