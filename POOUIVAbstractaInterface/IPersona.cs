using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIVAbstractaInterface
{
    public interface IPersona
    {
        //Propiedades
        double Peso { get; set; }
        double Altura { get; set; }

        //Metodos
        void Felicitaciones(string nombre, string motivo);
        void CalcularIMC();
    }
}
