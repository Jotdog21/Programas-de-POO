using System;

namespace program
{
    class Musico
    {
        protected string nombre;

        public Musico(string n)
        {
            nombre = n;
        }
        public abstract string saludo();
    }
}