using System;
using System.Collections.Generic;
using System.Text;

namespace BP_Class_Objetos._7_Interfaz_Figura
{
    class Circulo : IFiguraGeometrica
    {
        public Circulo(string nombre, decimal radio)
        {
             Nombre = nombre;
            Radio = radio;
        }

        public decimal Radio { get; set; }
       public string Nombre { get ; set ; }

        public decimal CalcularArea()
        {


            return (decimal)Math.PI * Radio * Radio;//esta es una libreria Math para usar el PI
        }
        public override string ToString()
        {
            return $"Nombre:{Nombre}, Radio:{Radio}.area:{CalcularArea()}";
        }

    }
}