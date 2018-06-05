using System;

namespace calculadora
{
    class Operaciones
    {
        public double Sumar(double sumando1, double sumando2)
        {
            return sumando1 + sumando2;
        }
         public double Restar(double minuendo, double sustraendo)
        {
            return minuendo - sustraendo;
        }
         public double Multiplicar(double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }
         public double Dividir(double dividendo, double divisor)
        {
            return dividendo / divisor;
        }
        public double Raiz(double radicando)
        {
            return Math.Sqrt(radicando);
        }

    }
}
