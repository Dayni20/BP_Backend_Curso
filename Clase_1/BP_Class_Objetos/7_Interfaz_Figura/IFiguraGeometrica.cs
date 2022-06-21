using System;
using System.Collections.Generic;
using System.Text;

namespace BP_Class_Objetos._7_Interfaz_Figura
{
    interface IFiguraGeometrica
    {
        public string Nombre { get; set; }
        public decimal CalcularArea();
    }
}
