using System;

namespace program
{
    class Bajista : Musico
    {
        public string bajo;

        public Bajista(string nombre, string bajo):base(nombre)
        {
            this.bajo = bajo;
        }

        public override string saludo()
        {
            return base.saludo() + " soy bajista";
        }
    }
}