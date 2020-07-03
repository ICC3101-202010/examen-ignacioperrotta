using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen
{
    public class Person
    {
        protected string nombre;
        protected int edad;
        protected string nacion;
        protected int sueldo;
        public Person(string nombre, int edad, string nacion, int sueldo)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacion = nacion;
            this.Sueldo = sueldo;
        }
        public string Nombre
        {
            get => nombre; set => nombre = value;
        }
        public int Edad
        {
            get => edad; set => edad = value;
        }
        public string Nacion
        {
            get => nacion; set => nacion = value;
        }
        public int Sueldo
        {
            get => sueldo; set => sueldo = value;
        }
        public void InfoPerson()
        {
            Console.WriteLine("Nombre: " + Nombre + ", Edad: " + Edad + ", Nación: " + Nacion + ", Sueldo: " + Sueldo);
        }
    }
}
