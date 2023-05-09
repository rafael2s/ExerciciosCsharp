using System;
using System.Text;

namespace EditorHTML{
    public static class Editor{
        public static void Show(){
            Console.Clear();
            
            Console.WriteLine("Modo EDITOR");
            Console.WriteLine("===========");

            Start();
        }
        public static void Start(){
            var arquivo = new StringBuilder();

            do{
                arquivo.Append(Console.ReadLine());
                arquivo.Append(Environment.NewLine);
            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("===========");
            Console.WriteLine("Salvar arquivo?");
        }
    }
}