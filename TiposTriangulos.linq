<Query Kind="Program" />

void Main()
{
	/*
	Realizar un programa que lea los lados de n triángulos, e informar:
    a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados iguales),
    isósceles (dos lados iguales), o escaleno (ningún lado igual)
    b) Cantidad de triángulos de cada tipo.
    c) Tipo de triángulo que posee menor cantidad.
	*/
	
	
	int f, n, equi, isos, esca;
	float lado1, lado2, lado3;
	Console.WriteLine("Cantidad de triangulos que va a ingresar: ");
	n = int.Parse(Console.ReadLine());
	equi = 0;
	isos = 0;
	esca = 0;
	
	for (f=1;f<=n;f++)
	{
	  Console.WriteLine($"Ingrese un lado del triangulo nª {f}: ");
	  lado1 = float.Parse(Console.ReadLine());
	  Console.WriteLine("--");
	  Console.WriteLine("Ingrese otro lado: ");
	  lado2 = float.Parse(Console.ReadLine());
	  Console.WriteLine("--");
	  Console.WriteLine("Ingrese el último lado: ");
	  lado3 = float.Parse(Console.ReadLine());
	  Console.WriteLine("--");
	  
	  if (lado1==lado2 && lado2==lado3)
	    {
		  Console.WriteLine($"El triangulo {f} es equilatero");
		  Console.WriteLine("--");
		  equi++;
		}
	  if ((lado1==lado2 && lado2!=lado3) || (lado1!=lado2 && lado2==lado3) || (lado3==lado1 && lado1!=lado2))
	    {
		  Console.WriteLine($"El triangulo {f} es isósceles");
		  Console.WriteLine("--");
		  isos++;
		}
	  if (lado1!=lado2 && lado2!=lado3 && lado3!=lado1)
	    {
	      Console.WriteLine($"El triangulo {f} es escaleno");
		  Console.WriteLine("--");
		  esca++;
	    }  
	  
	}
		
	Console.WriteLine($"Cantidad de triangulos equilateros: {equi} ");
	Console.WriteLine($"Cantidad de triangulos isósceles: {isos}");
	Console.WriteLine($"Cantidad de triangulos escalenos: {esca}");
	
	if (equi<isos && equi<esca) 
         {
            Console.WriteLine("Hay menor cantidad de triángulos equilateros.");
         }
         else
           {
             if (isos<esca) 
             {
                Console.WriteLine("Han menor cantidad de triángulos isósceles");	
             }
             else
             {
                Console.WriteLine("Han menor cantidad de triángulos escalenos");	                
             }
           }
   
}

// Define other methods and classes here
