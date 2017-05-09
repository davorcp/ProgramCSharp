<Query Kind="Program" />

void Main()
{
	/*
	En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada cuenta
	corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe finalizar
	al ingresar un valor negativo en el número de cuenta.
    Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:
    a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
    Estado de la cuenta	
	                           'Acreedor' si el saldo es >0.
			                   'Deudor' si el saldo es <0.
			                   'Nulo' si el saldo es =0.
    b) La suma total de los saldos acreedores.
	*/
	int cuenta;
    float saldo,suma;
    suma=0;
	
    do 
	{
      Console.Write("Ingrese número de cuenta: ");
      cuenta = int.Parse(Console.ReadLine());
        if (cuenta>=0) 
        {
         Console.Write("Ingrese saldo: ");
         saldo=float.Parse(Console.ReadLine());
          if (saldo>0) 
          {
            Console.WriteLine("Saldo Acreedor.");
            suma=suma+saldo;
          } 
           else 
            {
             if (saldo<0) 
             {
               Console.WriteLine("Saldo Deudor.");
             } 
             else 
              {
               Console.WriteLine("Saldo Nulo.");
              }
            }
        }
    } 
	while(cuenta>=0);
            Console.Write($"Total de saldos Acreedores:{suma}");
            
    	
}

// Define other methods and classes here
