using System;
using System.Collections.Generic;
using System.Text;

namespace BP_Class_Objetos._8_Generico_Biblioteca
{
    public class Libros<T>
    {
        private T _libro;
        public T Libro
        {
            get { return _libro; }
            set { _libro = value; }
        }
    }
}
