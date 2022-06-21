using BP_Class_Objetos.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace BP_Class_Objetos.Herencia
{
    public class CuentaCorriente1 : CuentaBancaria4

    {
        public string TasaInteres { get; set; }


        public CuentaCorriente1(string propietario, string numero, decimal saldo, string tasaInteres)//el constructor se va a manejar desde esta clase hija
        {
            Propietario = propietario;
            Numero = numero;
            Saldo = saldo;
            TasaInteres = tasaInteres;

        }
        public override void Mostrar()//Permite modificar y agregar otra propiedad en este caso tasa de interes 
        {
            Console.WriteLine($"Propietario:{Propietario} Numero:{Numero} Saldo:{Saldo} TasaInteres{TasaInteres}" ); //asi se llama interpolacion de cadenas 
        }
    }
}
