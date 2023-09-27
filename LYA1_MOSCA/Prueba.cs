using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LYA1
{
    public class Prueba : IDisposable
    {
        private StreamReader archivo;
        private StreamWriter encriptado;

        public Prueba()
        {
            Console.WriteLine("Constructor sin argumentos");
            archivo = new StreamReader("prueba.cpp");
            encriptado = new StreamWriter("encriptado.cpp");
        }

        public Prueba(string nombre)
        {
            Console.WriteLine("Constructor con argumento");
            archivo = new StreamReader(nombre);
            encriptado = new StreamWriter("encriptado.cpp");
        }

        public void Dispose()
        {
            Console.WriteLine("Destructor");
            archivo.Close();
            encriptado.Close();
        }

        bool EsVocal(char c)
        {
            if (c == 'a')
            {
                return true;
            }
            return false;
        }

        public void Encripta(char constante)
        {
            char c;
            while (!archivo.EndOfStream)
            {
                c = (char)archivo.Read();
                if (char.IsLetter(c))
                {
                    c = (char)((int)c - 2);
                }
                encriptado.Write(c);
            }
        }

        public void Display()
        {
            char c;
            int letras = 0;
            int numeros = 0;
            int vocales = 0;
            while (!archivo.EndOfStream)
            {
                c = (char)archivo.Read();
                Console.Write(c);
                if (EsVocal(c))
                {
                    vocales++;
                }
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
            Console.WriteLine("Letras = " + letras);
            Console.WriteLine("Vocales = " + vocales);
            Console.WriteLine("Numeros = " + numeros);
        }

        public static void Main(string[] args)
        {
.
            using (Prueba prueba = new Prueba("Prueba.cpp"))
                prueba.Encripta('X');
                prueba.Display();
            }
        }
    }

}dotnet