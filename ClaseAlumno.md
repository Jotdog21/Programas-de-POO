```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlumnosClases
{
    class Alumno
    {
        public string Nombre = "";
        public int Edad = 0;
        public string Correo = "";

        public void Imprimir()
        {
            Console.WriteLine("{0}, {1}, {2}", Nombre , Edad , Correo);
        }

        public List<Grupo> grupos;
    }

    class Grupo
    {
        public string Materia = "";
        public string Profesor = "";
        public int Calificacion = 0;

        public void Imprimir()
        {
            Console.WriteLine("{0}, {1}, {2} ", Materia, Profesor, Calificacion);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.Nombre = "Juan";
            a.Edad = 18;
            a.Correo = "Juan18@gmail.com";
            a.Imprimir();

            Grupo g = new Grupo();
            g.Materia = "POO";
            g.Profesor = "Mario";
            g.Calificacion = 100;
            g.Imprimir();

            Console.Read();
        }
    }
}

```