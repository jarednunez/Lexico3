using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace LYA1
{
    public class Prueba : IDisposable
    {
        private StreamReader archivo;
        public Prueba()
        {
            Console.WriteLine("Constructor sin argumentos");
            archivo = new StreamReader("prueba.cpp");
        }
        public Prueba(string nombre)
        {
            Console.WriteLine("Constructor con argumento");
            archivo = new StreamReader(nombre);
        }
        public void Dispose()
        {
            Console.WriteLine("Destructor");
            archivo.Close();
        }
        public void display()
        {
            char c;
            int  letras = 0;
            int  numeros = 0;
            while (!archivo.EndOfStream)
            {
                c = (char)archivo.Read();
                Console.Write(c);
                if (char.IsLetter(c))
                {
                    letras++;
                }
                else if (char.IsDigit(c))
                {
                    numeros++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Letras = "+letras);
            Console.WriteLine("Numeros = "+numeros);
        }
    }
}