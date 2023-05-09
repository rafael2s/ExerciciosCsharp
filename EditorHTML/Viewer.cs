using System;
using System.Text.RegularExpressions;

namespace EditorHTML{
    public class Viewer{
        public static void Show(string text){
            Console.Clear();

            Console.WriteLine("Modo VISUALIZAÇÃO !!!");
            Console.WriteLine("=====================");
            Replace(text);
            Console.WriteLine("=====================");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text){
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            Console.WriteLine(strong);
        }
    }
}