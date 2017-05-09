<Query Kind="Program" />

void Main()
{
	/*
	Escribir un programa que solicite la carga de números por teclado, obtener su promedio.
	Finalizar la carga de valores cuando se cargue el valor 0.
	*/
	int x;
	float valor, suma, promedio;
	suma=0;
	promedio=0;
	x=0;
	
	do 
	{
	  Console.WriteLine("Ingrese un valor, finaliza carga con 0");
	  valor = float.Parse(Console.ReadLine());
	  Console.WriteLine($"________Valor ingresado: {valor}________");
	  suma = suma + valor;
	  x++;
	} 
	while (valor!=0);
	
	promedio = suma / x;
	Console.Write($"El promedio es de: {promedio}");
	
	
	
	
	
}

// Define other methods and classes here
