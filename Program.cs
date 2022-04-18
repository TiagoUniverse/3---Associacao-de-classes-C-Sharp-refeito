using System;

namespace _3___Associacao_de_classes_C_Sharp_refeito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Professor prof1 = new Professor();
            
            
            prof1.setNome ("Tiago");

            Console.WriteLine(prof1.getNome());
        }
    }
}
