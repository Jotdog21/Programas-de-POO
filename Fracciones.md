```C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraccion
{
    class Fraccion
    {
        private int Numerador;
        private int Denominador;

        public Fraccion(int Numerador, int Denominador)
        {
            this.Numerador = Numerador;
            this.Denominador = Denominador;
        }

        public Fraccion()
        {
            Numerador = 1;
            Denominador = 1;
        }

        public void Imprime()
        {
            Console.WriteLine("{0} / {1}", Numerador, Denominador);
        }

        public decimal A_Decimal()
        {

            return Numerador / Denominador;
        }

        public static Fraccion operator +(Fraccion X, Fraccion Y)
        {
            int numerador = X.Numerador * Y.Denominador + X.Denominador * Y.Numerador;
            int denominador = X.Denominador * Y.Denominador;


            return new Fraccion(numerador, denominador);
        }

        public static Fraccion operator *(Fraccion X, Fraccion Y)
        {
            int numerador = X.Numerador * Y.Numerador;
            int denominador = X.Denominador * Y.Denominador;

            return new Fraccion(numerador, denominador);
        }

        public static Fraccion operator /(Fraccion X, Fraccion Y)
        {
            int numerador = X.Numerador * Y.Denominador;
            int denominador = X.Denominador * Y.Numerador;

            return new Fraccion(numerador, denominador);
        }

        public static Fraccion operator -(Fraccion X, Fraccion Y)
        {
            int numerador = X.Numerador * Y.Denominador - X.Denominador * Y.Numerador;
            int denominador = X.Denominador * Y.Denominador;


            return new Fraccion(numerador, denominador);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraccion A = new Fraccion(1,2);
            Fraccion B = new Fraccion(1,3);
            Fraccion C = A + B;
            Fraccion D = A - B;
            Fraccion E = A * B;
            Fraccion F = A / B;

            A.Imprime();
            B.Imprime();
            C.Imprime();
            D.Imprime();
            E.Imprime();
            F.Imprime();

            Console.Read();
        }
    }
}

```