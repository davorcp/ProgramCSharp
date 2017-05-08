<Query Kind="Program" />

void Main()
{
	int x, cantidad, n;
            float largo;
            x = 1;
            cantidad = 0;

            Console.WriteLine("Ingrese la cantidad de piezas: ");
            n = int.Parse(Console.ReadLine());

            while (x <= n)
            {
                Console.WriteLine("Ingrese el largo: ");
                largo = float.Parse(Console.ReadLine());

                if (largo >= 1.20 && largo <= 1.30)
                {
                    cantidad = cantidad + 1;

                }

                x = x + 1;
                        
            }

            Console.WriteLine($"La cantida de piezas aptas son: {cantidad}");
            Console.ReadKey();
          
}

// Define other methods and classes here
