<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.Linq</Namespace>
  <Namespace>System.Text</Namespace>
</Query>

void Main()
{
                          //Variables para guardar los grados Celsius y Fahrenheit
  int cel, far;
  string usuario;

                          // Elige la opción que necesita convertir

  Console.WriteLine("Presiona F si quieres convertir Celsius a Fahrenheit");
  Console.WriteLine("Presiona C si quieres convertir Fahrenheit a Celsius");
                            
  usuario = Console.ReadLine();
  switch (usuario)

   {
                           //Da igual si utiliza F mayúscula o minuscula
    case "F":
    case "f":
    Console.WriteLine("Conversion a F");
    Console.Write("Escribe los grados Celsius: ");

    cel = int.Parse(Console.ReadLine());
    far = (9 / 5) * cel+32;

    Console.WriteLine("{0} grados Celsius son {1} grados Fahrenheit", cel, far);

    break;

                           //Da igual si utiliza C mayúscula o minuscula
    case "C":
    case "c":
    Console.WriteLine("Conversion a C");
    Console.Write("Escribe los grados Fahrenheit: ");

    far = int.Parse(Console.ReadLine());
    cel = (9 / 5) * far-32;

    Console.WriteLine("{0} grados Fahrenheit son {1} grados Celsius", far, cel);

    break;
  }

}

// Define other methods and classes here