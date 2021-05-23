using Figgle;
using System;

namespace ConversorASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "";

            Console.WriteLine("Insira um texto: ");
            texto = Console.ReadLine();

            Console.WriteLine(FiggleFonts.Ogre.Render(texto));

            Console.Write("Pressione qualquer tecla para fechar a aplicação...");
            Console.ReadKey();
        }
    }
}