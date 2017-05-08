<Query Kind="Program" />

void Main()
{
	    int num, numx, numf;

            Console.WriteLine("Ingrese un numero entero:");
            num = int.Parse(Console.ReadLine());
            numf = 0;

            while (num > 0)

            {

                numx = (num % 10);  //Aqui obtengo el resto de la division (el primer dígito)

                num = (num / 10);  //Aqui le saco el primer dígito

                numf = numf + numx; //Aqui va guardando el resultado

            }

            Console.WriteLine($"La suma de cada digito del numero es:{numf}");
			
}

// Define other methods and classes here