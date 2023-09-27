
namespace LA{
    public class Prueba : IDisposable{
        
        private StreamReader _archivo;
        private StreamWriter encriptado;
        
        public Prueba(){
            
            //Console.WriteLine("Constructor sin argumentos");
            _archivo = new StreamReader("prueba.cpp");
            encriptado = new StreamWriter("ecriptado.cpp");
        }
        public Prueba(string nombre){
            
            //Console.WriteLine("Constructor con argumento");
            _archivo = new StreamReader(nombre);
            encriptado = new StreamWriter("ecriptado.cpp");
        }
        public void Dispose(){
            
            //Console.WriteLine("Destructor");
            _archivo.Close();
            encriptado.Close();
        }
        public void Encripta(char vowel){
            
            char c;
            while (!_archivo.EndOfStream)
            {
                c = (char)_archivo.Read();
                
                //if ("aeiou".Contains(c) || "AEIOU".Contains(c)){
                
                if ( "aeiouAEIOU".IndexOf(c) >= 0){
                    c = vowel;
                }
                encriptado.Write(c);
            }
        }
        public void Display(){
            
            char c;
            int letras = 0;
            int numeros = 0;
            int vocal = 0;
            
            while (!_archivo.EndOfStream){
                
                c = (char)_archivo.Read();
                Console.Write(c);
                
                if ("aeiou".Contains(c) || "AEIOU".Contains(c)){
                    
                    vocal++;
                    letras++;
                }
                else if (char.IsDigit(c)){
                    numeros++;
                }
                else if (char.IsLetter(c)){
                    letras++;
                }
            }
            Console.WriteLine("\nLetras = " + letras +
                    "Vocales = " + vocal +
                    "Numeros = " + numeros);
        }
    }
}