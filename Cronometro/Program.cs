using System;
using System.Threading;

namespace Cronometro{
    class Program{
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
        
            Console.Clear();

            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja cronometrar?");

            string data = Console.ReadLine().ToLower(); // Pegando o dado que o cliente digitou, ToLower coloca qualquer letra digitada em minusculo
            char type = char.Parse(data.Substring(data.Length-1, 1)); //Pegando o ultimo caracter.
            int time = int.Parse(data.Substring(0, data.Length-1)); // Pegando todos os caracteres, menos o ultimo.
            Console.WriteLine(type);
            Console.WriteLine(time);
        }



        static void Start(int time){
            
            int currentTime = 0;

            while(currentTime != time){
                
                Console.Clear();
                currentTime++; // exibir de 1 a 10
                Console.WriteLine(currentTime);
                // currentTime++; // exibir de 0 a 10
                Thread.Sleep(1000); // a cada interação demora 1 segundo.
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(2000);
        }
    }
}

