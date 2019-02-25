```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Agenda
    {
        private string nombre;
        private List<Contacto> contactos;

        public Agenda(string Nombre)
        {
            this.nombre = Nombre;
            contactos = new List<Contacto>();
        }

        public void AgregarContacto(Contacto C)
        {
            contactos.Add(C);
        }

        public void AgregarContacto(string nombre, string correo, string celular)
        {
            contactos.Add(new Contacto(nombre, correo, celular));
        }

        public void ImprimeAgenda()
        {
            foreach(Contacto C in contactos)
            {
                C.Imprime();
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Contacto
    {
        private string Nombre;
        private string Correo;
        private string Celular;

        public Contacto(string n, string c, string cel)
        {
            this.Nombre = n;
            this.Correo = c;
            this.Celular = cel;
        }

        public void Imprime()
        {
            Console.WriteLine("{0}-cel:{1}", Nombre, Celular);
        }

        public static bool operator != (Contacto a, string nombre)
        {
            return a.Nombre != nombre;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Instrumentation;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Contacto C1 = new Contacto(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Contacto C2 = new Contacto(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Contacto C3 = new Contacto(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());

            C1.Imprime();
            C2.Imprime();
            C3.Imprime();
            */

            List<Contacto> Contactos = new List<Contacto>();
            Contactos.Add(new Contacto("Roberto", "robby@gmail.com", "6641234567"));
           
            //Contactos[0].Imrime();

            foreach (Contacto C in Contactos)
            {
                C.Imprime();

            }

            Agenda a = new Agenda("Trabajo");
            Agenda b = new Agenda("Amigos");

            a.AgregarContacto(new Contacto("Ana", "ana@gmail.com", "6641769745"));

            Console.Read();
        }
    }
}

```