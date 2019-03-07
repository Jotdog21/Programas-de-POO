using System;

namespace program
{
    class Vocalista : Musico
    {
        public Vocalista(string n):base(n)
        {

        }

        public override stirng saludo()
        {
            return String.Format("Hola, soy {0} ", nombre);
        }
    }
}