using System;
using System.Collections.Generic;
using System.Text;


//PROPIEDADES IMPLEMENTADAS AUTOMATICAMENTE
namespace BP_Class_Objetos.Class   //namespace es un espacio de nombre organizacion logica
{
   public class CuentaBancaria4
    {
       
        //El constructor nos permite inicializar un campo
    /*    public CuentaBancaria4(string propietario, string numero, decimal saldo)
        {
           Propietario = propietario;
            Numero = numero;
            Saldo = saldo;
     }*/

   
        public string Propietario { get; set; }
        protected string Numero { get; set; }
        public decimal Saldo { get; protected set; }//desde afuera nadie lo puede lerr pero si se lo puede leer desde la misma clase


        public void EstablecerSaldo(decimal valor)
        {
            //Logica de negocio
            Saldo = valor + Saldo;
        }

        public string ObtenerNumero()
        {
            return $"El numero de cuenta es {Numero}";
        }


        public virtual void Mostrar()//Metodo virtual permite q las clases derivadas puedan hacer sobreescrituras del metodo
        {
            Console.WriteLine($"Propietario:{Propietario} Numero:{Numero} Saldo:{Saldo}"); //asi se llama interpolacion de cadenas 
        }

    }
}
