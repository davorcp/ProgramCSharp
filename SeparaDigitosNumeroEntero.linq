<Query Kind="Program" />

void Main()
{
	int numero, num1, num2, num3, num4, num5;
	
	Console.WriteLine("Ingrese un numero de 5 cifras:");
	numero = int.Parse(Console.ReadLine());
	if (numero > 10000 && numero <= 99999)
	{	 
	 num1 = numero / 10000;
	 num2 = (numero % 10000) / 1000;
	 num3 = (numero % 10000) % 1000 / 100;
	 num4 = ((numero % 10000) % 1000) % 100 / 10;
	 num5 = (((numero % 10000) % 1000) % 100) % 10;
	 
	 Console.WriteLine("Los numeros del numero de 5 cifras son:");
	 Console.WriteLine($"{num1}, {num2}, {num3}, {num4}, {num5}");
	}
	else
	{
	 Console.WriteLine("El numero ingresado tiene no tiene 5 cifras");	
	}



	
}

// Define other methods and classes here
