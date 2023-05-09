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
            var words = text.Split(' ');

            for (var word = 0; word < words.Length; word++){
                if(strong.IsMatch(words[word])){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(
                        words[word].Substring(
                            words[word].IndexOf('>') + 1),
                        (
                            (words[word].LastIndexOf('<') - 1) - words[word].IndexOf('>')
                        )
                    );
                    Console.Write(" ");
                }else{
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(words[word]);
                    Console.Write(" ");
                }
            }
        }
    }
}