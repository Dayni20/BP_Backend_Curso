using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BP_Class_Objetos._10_Asincrono_Sincrono
{
    class Jugador
    {

            public string Nombre { get; set; }
            public Jugador(string nombre)
            {
                Nombre = nombre;
            }

            public async Task Jugar()

            {
                await Task.Delay(1000);

                for (int i = 0; i <= 5; i++)
                {

                    Console.WriteLine($"Jugador{Nombre}" + i);
                }
            }
        }
    }


