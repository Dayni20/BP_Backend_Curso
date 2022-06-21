using BP_Class_Objetos._10_Asincrono_Sincrono;
using BP_Class_Objetos._7_Interfaz_Figura;
using BP_Class_Objetos._8_Generico_Biblioteca;
using BP_Class_Objetos.Class;
using BP_Class_Objetos.Herencia;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BP_Class_Objetos
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("*************************************Class_Objetos_Primera_Forma********************************");
            CuentaBancaria cb = new CuentaBancaria(propietario: "Dayana", numero: "27998827272", saldo: 123);//primera forma de usar //pasar parametros con valor Esto es bueno cuando utilizamos muchos parametros
            CuentaBancaria cbb = new CuentaBancaria("Erika", "9283747", 98656);//segunda forma de usar
            var cbbb = new CuentaBancaria("Daniel", "12345", 9123445);//tercera forma de declarar

            cb.Mostrar();
            cbb.Mostrar();
            cbbb.Mostrar();

            cb.Saldo = cb.Saldo + 700;
            cb.Mostrar();

            Console.WriteLine("\n\n*************************************Class_Objetos_Segunda_Forma********************************");
            var cb1 = new CuentaBancaria1("Luisa", "83764378290384738", 345678909876543);
            cb1.Mostrar();

            Console.WriteLine("\n\n*************************************Protected_Just_Get********************************");
            var cb2 = new CuentaBancaria2("Holi", "2345678", 100);
            cb2.EstablecerSaldo(500);//la suma siempre se hace en la clase y aqui solo mandamos a llamar
            cb2.Mostrar();

            Console.WriteLine("\n\n*************************************HERENCIA********************************");
            var cc = new CuentaCorriente("Ccorriente", "2345643", 23456, "23");
            cc.Mostrar();

            Console.WriteLine("\n\n*************************************PROTECTED PROPIEDAD********************************");
            var cc1 = new CuentaCorriente1("Ccorrienteuno", "12345numero", 23456, "23");
            Console.WriteLine(cc1.ObtenerNumero());
            cc.Mostrar();

            Console.WriteLine("\n\n*************************************CLASE ABSTRACTA********************************");
            var cc2 = new CuentaCorriente2("ClaseABstracta", "12345numero", 23456, "23");
            Console.WriteLine(cc2.ObtenerNumero());
            cc.Mostrar();


            Console.WriteLine("\n\n*************************************INTERFAZ********************************");
            var c = new Circulo("Daya", 5);
            Console.WriteLine("EL ARE DEL CIRCULO ES: " + c.CalcularArea());

            // Console.WriteLine($"EL ARE DEL CIRCULO ES:  {c.CalcularArea():C2}");//Este formato hace el valor de moneda

            var t = new Triangulo("Trian", 5, 3);
            Console.WriteLine("EL AREA DEL TRIANGULO ES: " + t.CalcularArea());


            Console.WriteLine("\n\n*************************************COLECCION EJEMPLO ARREGLO********************************");

            //LLo arrays son limitados solo puede darse un numero finitas o q no creo q vaya aumentar el numero de elementos q tiene

            var numeros = new int[5];//aca es explicita
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i;
            }


            string[] vocales = { "a", "e", "i", "o", "u" };//no puede usar var porq es implicita

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < vocales.Length; i++)
            {
                Console.WriteLine(vocales[i]);
            }

            Console.WriteLine("\n\n*************************************EJEMPLO LISTA********************************");
            //Las listas son List Que permite agregar y quitar elementos no da limite solo va almacenar figuras

            var figuras = new List<IFiguraGeometrica>();

            var circu = new Circulo("Circulo", 5);
            var triangu = new Triangulo("Trian", 8, 2);
            var triangu1 = new Triangulo("Triang", 4, 2);

            figuras.Add(circu);
            figuras.Add(triangu);
            figuras.Add(triangu1);

            foreach (var figura in figuras)
            {
                Console.WriteLine($"El area de la figura {figura.GetType().ToString()} es :  {figura.CalcularArea()} ");
            }
            Console.WriteLine("\n\n*************************************EJEMPLO LISTA AÑADIENDO OTRO CIRCULO********************************");

            //OTRA FORMA DE HACERLO ES AÑADIENDPO OTRO CIRCULO
            IFiguraGeometrica c2 = new Circulo("Circulo2", 4);
            figuras.Add(c2);
            Console.WriteLine();
            foreach (var figura in figuras)
            {
                Console.WriteLine($"El area de la figura {figura.GetType().ToString()} es : {figura.CalcularArea()}");
            }

            /*  Console.WriteLine("\n\n*************************************EJEMPLO LISTA ELIMINAR UN VALOR********************************");

             //pARA ELIMINAR UN VALOR ES
             foreach (var figura in figuras)
             {
                 if (figura.GetType() == typeof(Circulo))

                 {

                     figuras.Remove(figura);
                     break;//finaliza el bucle pero solo elimina un triangulo en ese caso se hace el metodo de abajo

                 }
             }
                 foreach (var figura in figuras)
                 {
                     Console.WriteLine($"El area de la figura {figura.GetType().ToString()} es : {figura.CalcularArea()}");
                 }

             */
            Console.WriteLine("\n\n*************************************EJEMPLO LISTA ELIMINAR SIN BREAK********************************");

            var FigurasQuitar = new List<IFiguraGeometrica>();
            foreach (var figura in figuras)
            {
                if (figura.GetType() == typeof(Triangulo))
                {
                    FigurasQuitar.Add(figura);//estamos guardando en un espacio temporal las figuras
                }
            }
            foreach (var item in FigurasQuitar)//y aqui eliminamos las figuras que queremos quitar en estecaso triangulo
            {         
                    figuras.Remove(item);

            }
                Console.WriteLine();
                foreach (var figura in figuras)
                {
                    Console.WriteLine($"El area de la figura{figura.GetType().ToString()}es : {figura.CalcularArea()}");
                }

            /*   Console.WriteLine("\n\n*************************************EJEMPLO GENERICO  mMMM No entendi********************************");

               var objetos = new List<Util<Circulo>>();
                   var util1 = new Util<Circulo>(new Circulo("Circulo",7), "Circulo");
                   var util2 = new Util<Circulo>(new Circulo("Circulo2",9), "Circuloo");
                   objetos.Add(util1);
                           objetos.Add(util2);


                           foreach (var item in objetos)
                           {
                               var result = item.Figura.CalcularArea();
                             item.Error = false;
                               item.TpoFigura = "Circulo";
                               Console.WriteLine(result);
                           }

                       }
                   }*/
            Console.WriteLine("\n\n*************************************EJEMPLO GENERICO  Si entendi********************************");

            var l = new Libros<string>();
            l.Libro = "Las mil y una noche";

            var l1 = new Libros<int>();
            l1.Libro =  5;

            var l2 = new Libros<IFiguraGeometrica>();
            l2.Libro = new Circulo("Generico",8);
            Console.WriteLine("Libro A: "  + l.Libro);
            Console.WriteLine("Libro B: "  + l1.Libro);
            Console.WriteLine("Libro C: "  + l2.Libro);

            Console.WriteLine("\n\n*************************************DICCIONARIO_USUARIO_VALOR********************************");




            //Dicionario tiene clave y valor el diccionario es util cuando quiere almacenar
            //cierta informAacion yes compartida por ejemplo trabajar con cache ya qse trabaja con informacion compartida como inicio de sesion del usuario
            //y desde ay se recupera si el usuario esta logeado 

            //se pude mandar tipo string

            Dictionary<string, string> map = new Dictionary<string, string>();


            map.Add("A", "Juan");
            map.Add("B", "Daya");
            map.Add("100", "Erika");

            Console.WriteLine(map["A"]);

            //se puede mandar tipo int
            Dictionary<int, string> map2 = new Dictionary<int, string>();


            map2.Add(1, "Juan");
            map2.Add(2, "Daya");
            map2.Add(3, "Erika");

            Console.WriteLine(map2[2]);

           //Se puede mandar tipo objeto
            Dictionary<int, IFiguraGeometrica> map3 = new Dictionary<int, IFiguraGeometrica>();

            var cir = new Circulo("Daya", 5);
            map3.Add(100,cir);

            Console.WriteLine(map3[100]);


            //EJEMPLO EN AMBOS CASOS NECESITO AL CLIENTE EN ESTE CASO SE GENERA CLAVE Y VALOR OSEA EL DICCCIONARIO:
            // Pedido

            //  Factura
            Console.WriteLine("\n\n*************************************SINCRONO Y ASINCRONO********************************");

            var jugador = new Jugador("Dayan");
            var jugador2 = new Jugador("Luisa");
            var jugador3 = new Jugador("Pedro");

            // var timer = new System.Timers.Timer(2000);
            //timer.Start();


           await jugador.Jugar();
           await jugador2.Jugar();
           await jugador3.Jugar();
        }
    }
}

