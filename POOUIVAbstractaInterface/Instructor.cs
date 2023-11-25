using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace POOUIVAbstractaInterface
{
    public class Instructor : Persona, IPersona
    {
        //Propiedades
        private string inss;

        public string INSS
        {
            get { return inss; }
            set { inss = value; }
        }
        public override string Cedula { get ; set; }
        public double Peso { get ; set; }
        public double Altura { get; set; }

        //Constructor

        public Instructor()
        {

        }

        public Instructor(string inss, string cedula, string nombre, int edad, double peso, double altura)
        {
            this.inss = inss;
            Cedula = cedula;
            Nombre = nombre;
            Edad = edad;
            Peso = peso;
            Altura = altura;
        }

        //Metodos

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Cedula: {Cedula}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"INSS: {inss}");
        }

        public void Felicitaciones(string nombre, string motivo)
        {
            Console.WriteLine($"{nombre} el motivo de esta felicitacion es: {motivo}");
        }

        public void CalcularIMC()
        {
            var IMC = Peso / (Altura * Altura);
            Console.WriteLine("El IMC es: "+IMC);
        }
    }
}
