﻿using System;

namespace calculadora
{
    class Program
    {
        public static void Opciones ()
        {
            // variables
            double numero1, numero2;
            int operacion;
            string repetir;

            do{
                Console.WriteLine("Ingrese el numero de la Operacion :\n");
                Console.WriteLine("1.- Suma\n2.-Resta\n3.-Multiplicacion\n4.-Division\n");

                operacion=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el primer numero  :\n");
                numero1=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero  :\n");
                numero2=Convert.ToDouble(Console.ReadLine());

                Operaciones op=new Operaciones(); 

                switch (operacion)
                {
                     case 1: 
                            Console.WriteLine("la suma de los numeros es:  \n"+op.Suma(numero1,numero2));
                     break;
                     case 2: 
                            Console.WriteLine("la resta de los numeros es:  \n"+op.Resta(numero1,numero2));
                     break;
                     case 3: 
                            Console.WriteLine("la multiplicacion de los numeros es:  \n"+op.Multiplicacion(numero1,numero2));
                     break;
                     case 4: 
                            Console.WriteLine("la division de los numeros es:  \n"+op.Diviison(numero1,numero2));
                     break;

                     default: 
                            Console.WriteLine("la operacion no existe\n"+op.Suma(numero1,numero2));
                     break;        
                } 

                Console.WriteLine("Para repetir presione la s");
                repetir=Console.ReadLine();

            }while(repetir == "s");
        } 
        static void Main(string[] args)
        {
            Opciones();
        }
    }
}
