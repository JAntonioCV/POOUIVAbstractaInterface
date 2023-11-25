using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIVAbstractaInterface
{
    public abstract class Persona
    {
        //propiedades abtracta
        public abstract string Cedula { get; set; }

        //propiedad normal 
        public string Nombre { get; set; }
        public int Edad { get; set; }

        //Metodo abstracto
        public abstract void MostrarInformacion();

        //Metodo normal
        public void Saludar() 
        {
            Console.WriteLine($"Cedula: {Cedula}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
        }
    }
}
