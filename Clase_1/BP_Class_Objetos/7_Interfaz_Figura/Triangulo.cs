using System;
using System.Collections.Generic;
using System.Text;

namespace BP_Class_Objetos._7_Interfaz_Figura
{
    public class Triangulo : IFiguraGeometrica
    {
        public Triangulo(string nombre,decimal @base, decimal altura)
        {
            Nombre = nombre;
            Base = @base;//El arroba base es una palabra reservada q permite llamar al constructor de una clase padre
            Altura = altura;
        }

        public decimal Base { get; set; }
        public decimal Altura { get; set; }
        public string Nombre { get ; set; }

        public decimal CalcularArea()
        {
            return Base * Altura / 2;
        }

    }
}
