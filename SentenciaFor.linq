<Query Kind="Program" />

void Main()
{
  int f, suma, valor;
  float prom;
  suma = 0;
  
  for (f=1;f<=10;f++)
  {
    Console.WriteLine($"Ingrese el valor nº {f}: ");
    valor = int.Parse(Console.ReadLine());
	suma = suma + valor;
  }
  
  prom = suma / 10;
  
  Console.WriteLine("-");
  Console.WriteLine($"La suma de los valores es: {suma}");
  Console.WriteLine("-");
  Console.WriteLine($"El promedio de los valores es: {prom}");
}

// Define other methods and classes here
