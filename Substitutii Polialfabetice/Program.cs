using System;

namespace Substitutii_Polialfabetice
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, cuvantcheie, cheie,textcv;
            text = "ATTACKATDAWN";
            Cifrul_Vigenere cv = new Cifrul_Vigenere();

            Console.Write("Cuvantul cheie:");
            cuvantcheie = Console.ReadLine();
            
            cheie=cv.Crearecheie(cuvantcheie, text);
            Console.WriteLine("Cheia generata este:{0}",cheie);
            textcv = cv.Criptare(cheie, text);
            Console.Write("Textul criptat este:{0}",textcv);
            Console.WriteLine();
            Console.Write("Textul decriptat este:");cv.Decriptare(textcv, cheie);
        }
    }
}
