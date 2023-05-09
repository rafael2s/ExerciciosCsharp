using System;

namespace EditorHTML{
    public static class Menu{
        public static void Show(){
            Console.Clear();


            DrawScreen();
            WriteOptions();

            var opt = short.Parse(Console.ReadLine());
            HandleMenuOption(opt);
        }

        public static void DrawScreen(){
            Console.Clear();

            Console.Write("+");
            for(int i = 0; i<=30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for(int lines = 0; lines <= 10; lines++){
                Console.Write("|");
                for(int i = 0; i<=30; i++)
                    Console.Write(" ");
                    
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for(int i = 0; i<=30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions(){
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Seleciona uma opção");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir Arquivo");                                    
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - Sair do programa!");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção: ");                        
        }
    
        public static void HandleMenuOption(short opt){
            switch(opt){
                case 1: Console.WriteLine("Editor"); break;
                case 2: Console.WriteLine("View"); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}