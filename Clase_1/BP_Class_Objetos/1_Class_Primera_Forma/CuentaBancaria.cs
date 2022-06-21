using System;
using System.Collections.Generic;
using System.Text;

namespace BP_Class_Objetos.Class   //namespace es un espacio de nombre organizacion logica
{
    class CuentaBancaria
    {
        //Atributos o campos  siempre se define con un guion bajo
        private string _Propietario;
         private string _Numero;
        private decimal _Saldo;

        //El constructor nos permite inicializar un campo
        public CuentaBancaria(string propietario, string numero, decimal saldo)
        {
           Propietario = propietario;
            Numero = numero;
            Saldo = saldo;
     }

        
                public string Propietario
                {
                    get { return _Propietario; }
                    set { _Propietario = value; }
                }
                public string Numero
                {
                    get { return _Numero; }
                    set { _Numero = value; }
                }
                public decimal Saldo
                {
                    get { return _Saldo; }
                    set { _Saldo = value; }
                }

        public  void Mostrar()
        {
            Console.WriteLine($"Propietario:{Propietario} Numero:{Numero} Saldo:{Saldo}"); //asi se llama interpolacion de cadenas 
        }

    }
}
