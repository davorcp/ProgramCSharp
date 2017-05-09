<Query Kind="Program" />

void Main()
{
	/*
	Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar
	el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el valor 
	acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.
	*/
	int valor, suma;
	Console.WriteLine("***PARA FINALIZAR INGRESE 9999 Y PRESIONE ENTER");
	suma = 0;
	
	do
	{
	  Console.WriteLine("Ingrese un valor: ");
	  valor = int.Parse(Console.ReadLine());
	  Console.WriteLine("-_-_-_-_-_-_-_-_-");
	  
	  if (valor!=9999)
	  suma = suma + valor;
	  
	}
	while (valor!=9999);
	
	if (suma>0)
	  {
	    Console.WriteLine($"El valor acumulado es {suma} y es mayor que 0");
	  }
	  else
	   if (suma == 0)
	   {
	     Console.WriteLine($"El valor acumulado es {suma}");
	   }
	   else
	     {
	     Console.WriteLine($"El valor acumulado es {suma} y es menor que 0");
		 }
}

// Define other methods and classes here
