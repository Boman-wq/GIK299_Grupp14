using System;
namespace Projekt_GIK299
{
    public class DoNotLook
    {
        public void Whoops(){
            bool k = false;
            while(!k){
                Console.Clear();
                Console.WriteLine("░██╗░░░░░░░██╗░█████╗░░██╗░░░░░░░██╗░█████╗░░██╗░░░░░░░██╗██╗░██╗░░░░░░░██╗░█████╗░");
                Console.WriteLine("░██║░░██╗░░██║██╔══██╗░██║░░██╗░░██║██╔══██╗░██║░░██╗░░██║██║░██║░░██╗░░██║██╔══██╗");
                Console.WriteLine("░╚██╗████╗██╔╝███████║░╚██╗████╗██╔╝███████║░╚██╗████╗██╔╝██║░╚██╗████╗██╔╝███████║");
                Console.WriteLine("░░████╔═████║░██╔══██║░░████╔═████║░██╔══██║░░████╔═████║░██║░░████╔═████║░██╔══██║");
                Console.WriteLine("░░╚██╔╝░╚██╔╝░██║░░██║░░╚██╔╝░╚██╔╝░██║░░██║░░╚██╔╝░╚██╔╝░██║░░╚██╔╝░╚██╔╝░██║░░██║");
                Console.WriteLine("░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝");
                switch(Console.ReadLine()){
                    case "q":
                        k = true;
                        Console.Clear();
                        break;
                }
            }
        }
    }
}