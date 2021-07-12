using System;

namespace Week1Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //serve per sampare a video Hello World!
            /* questo è 
             * un commento
             * su più righe*/
            int a; //dichiarazione
            a = 1; //assegnazione
            //int a = 1; //inizializzazione
            int b = 2;
            b = 5;

            int numeroSceltoDallUtente;

            const int N = 50;
            //N = 40; //non può essere modificato il valore di una costante
            
            int var1 = 1, var2 = 2, var3 = 3; //inizializzazione di più variabili su un'unica riga.

            string parola = "ciao a tutte";
            char carattere = 'a';

            //string s = "20";
            //int ss = 20;

            //Value type
            //Interi
            byte c; //tra 0 e 255, 8 bit
            short d; //16 bit
            int i; //32 bit
            long l; //64 bit

            //Numeri a virgola mobile
            float f = 2.33f;
            double pi = 3.1415967322d;
            decimal dec = 123.452m;

            //Booleani: true/false;
            bool isSunny = true;
            bool isRed;

            Console.WriteLine(parola);
            Console.WriteLine(carattere);

            int x = 1;
            int y = 2;

            Console.WriteLine($"Ciao, il valore della prima variabile è {x}. Il valore della seconda variabile è {y}");
            Console.WriteLine("Ciao, il valore della prima variabile è {0}. Il valore della seconda variabile è {1}", x, y);
            Console.WriteLine("Ciao, il valore della prima variabile è " + x + ". Il valore della seconda variabile è " + y);
            
            Console.WriteLine($"{x}\t{y}");

            Console.WriteLine("Ciao, come ti chiami?");
            string nome;
            nome = Console.ReadLine();
            Console.WriteLine($"Il tuo nome è {nome}");

            Console.WriteLine("Scrivi un carattere");
            char caracter = Console.ReadKey().KeyChar;

            DateTime data = new DateTime(2021, 6, 6);
            Console.WriteLine(data);
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            DateTime today = DateTime.Today;
            Console.WriteLine(today.ToShortDateString());

        }
    }
}
