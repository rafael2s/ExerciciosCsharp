using System;

namespace EditorHTML{
    public static class Menu{
        public static void Show(){
            Console.Clear();


            DrawScreen();
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
    }
}