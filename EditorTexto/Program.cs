using System;
using System.IO;

namespace EditorTexto{
    class Program{
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            
            Console.Clear();
            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine("1 - Abrir Arquivo");
            Console.WriteLine("2 - Criar Novo Arquivo");
            Console.WriteLine("0 - Sair");

            short opt = short.Parse(Console.ReadLine());

            switch(opt){
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }  
        }

        static void Abrir(){

        }
        static void Editar(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo");
            Console.WriteLine("-----------------------");
            string text = "";

            do{
                text += Console.ReadLine();
                text += Environment.NewLine;
            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }
        static void Salvar(string text){
            
            Console.Clear();
            Console.WriteLine("Escolha o caminho que deseja salvar o arquivo!");
            var caminho = Console.ReadLine();

            using(var arquivo = new StreamWriter(caminho)){
                arquivo.Write(text);
            }

            Console.WriteLine($"Arquivo {caminho} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
}