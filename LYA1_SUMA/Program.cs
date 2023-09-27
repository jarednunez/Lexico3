using System;

namespace LYA1
{
    class Program
    {
        static void Main(string[] args) 
        {
            try
            {
                Console.WriteLine("Hola mundo");

                using (Prueba P = new Prueba("suma.cpp"))
                {
                    P.display();
                    /*L.Programa();
                    
                    while (!L.FinArchivo())
                    {
                        L.nextToken();
                    }*/
                    
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine("Error: "+e.Message);
            }
        }
    }
}