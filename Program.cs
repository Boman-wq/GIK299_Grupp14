using System;

namespace Projekt_GIK299
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; // Be able to print unicode text into console.
            Console.Clear();
            Console.WriteLine("██████╗░██████╗░░█████╗░░░░░░██╗███████╗██╗░░██╗████████╗  ░░███╗░░");
            Console.WriteLine("██╔══██╗██╔══██╗██╔══██╗░░░░░██║██╔════╝██║░██╔╝╚══██╔══╝  ░████║░░");
            Console.WriteLine("██████╔╝██████╔╝██║░░██║░░░░░██║█████╗░░█████═╝░░░░██║░░░  ██╔██║░░");
            Console.WriteLine("██╔═══╝░██╔══██╗██║░░██║██╗░░██║██╔══╝░░██╔═██╗░░░░██║░░░  ╚═╝██║░░");
            Console.WriteLine("██║░░░░░██║░░██║╚█████╔╝╚█████╔╝███████╗██║░╚██╗░░░██║░░░  ███████╗");
            Console.WriteLine("╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░  ╚══════╝");
            Console.WriteLine("av Pontus Bohman och Isak Ljunggren.\n ");
            Menu menu = new Menu();
            menu.Wait();
            menu.MenuAlternative();
        }
    }
}

