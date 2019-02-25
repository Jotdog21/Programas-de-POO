```Csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Alumno : Persona
    {
        private string num_control;

        public Alumno(string nombre, int edad, string NControl):base(nombre, edad)
        {
            /*
            this.Nombre = nombre;
            this.edad = edad;
            */
            num_control = NControl;
        }

        public void Imprime()
        {
            Console.WriteLine(num_control);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Persona
    {
        protected string nombre;
        protected int edad;

        /*
        private string CURP { get; set; }

        private string lugar_nacimiento;

        public string Nombre
        {
            set
            {
                _nombre = value;
            }
            get
            {
                return Nombre;
            }
        }
        
        public string Lugar_nacimiento { get => lugar_nacimiento; set => lugar_nacimiento = value; }
        */
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        
        ~Persona()
        {
            Console.WriteLine("Destructor");
        }

        public void Imprime()
        {
            Console.WriteLine(nombre);
        }

        public void Imprime(int veces)
        {
            for (int i= 0; i<=veces; i++)
            {
                Imprime();
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona P = new Persona("zoe",69);
            P.Imprime();
            // P.nombre = "noe";
            // P.set_nombre = "noe";
            P.Imprime();
            List<Persona> personas = new List<Persona>();
            //personas.Add(p);
            personas.Add(new Alumno("Jim", 18, "18212278"));
            personas.Add(new Persona("Ana", 19));
            P.Imprime(3);
            personas[1].Imprime();



            Console.Read();
        }
    }
}
 ```