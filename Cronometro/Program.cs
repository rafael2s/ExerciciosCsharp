using System;
using System.Threading;

namespace Cronometro{
    class Program{
        static void Main(string[] args){
            Start();
        }

        static void Start(){
            
            int time = 10;
            int currentTime = 0;

            while(currentTime != time){
                
                Console.Clear();
                currentTime++; // exibir de 1 a 10
                Console.WriteLine(currentTime);
                // currentTime++; // exibir de 0 a 10
                Thread.Sleep(1000); // a cada interação demora 1 segundo.
            }
        }
    }
}

