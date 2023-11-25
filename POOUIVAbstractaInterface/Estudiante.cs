using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIVAbstractaInterface
{
    public class Estudiante : Persona
    {
        //Propiedades
        private string carnet;

        public string Carnet
        {
            get { return carnet; }
            set { carnet = value; }
        }

        public override string Cedula { get; set; }

        public Estudiante()
        {

        }

        public Estudiante(string cedula, string carnet, string nombre, int edad)
        {
            Cedula = cedula;
            this.carnet = carnet;
            Nombre = nombre;
            Edad = edad;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Cedula: {Cedula}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Carnet: {carnet}");
        }
    }
}
