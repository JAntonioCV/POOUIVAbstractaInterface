using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIVAbstractaInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("1","18124520","Pedro",28);
            estudiante.Saludar();
            Console.WriteLine();
            estudiante.MostrarInformacion();

            Console.WriteLine();

            Instructor  instructor = new Instructor("4879","2","Alonso",30,60,1.90);
            instructor.Saludar();
            Console.WriteLine();
            instructor.MostrarInformacion();
            Console.WriteLine();
            instructor.Felicitaciones("Juan", "Ascenso");
            instructor.CalcularIMC();

            Console.ReadKey();
        }
    }
}
