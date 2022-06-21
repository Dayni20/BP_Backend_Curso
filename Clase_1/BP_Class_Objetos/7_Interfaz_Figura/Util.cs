using System;
using System.Collections.Generic;
using System.Text;

namespace BP_Class_Objetos._7_Interfaz_Figura
{
        public class Util<T>
        {
            public Util(T figura, string tpoFigura)
            {
                Figura = figura;
                TpoFigura = tpoFigura;
            }

            public T Figura { get; set; }
            public string TpoFigura { get; set; }

        }
    }

