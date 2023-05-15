using FundamentosOO.ContentContext;

namespace FundamentosOO;
class Program
{
    static void Main(string[] args)
    {
        
        var articles = new List<Article>();
        articles.Add(new Article("Artigo Sobre OO", "Fundamentos OO"));
        articles.Add(new Article("Artigo Sobre DOTNET", "Tudo sobre .NET"));
        articles.Add(new Article("Artigo Sobre C#", "Tudo sobre C# !!!"));

        foreach(var article in articles){
            Console.WriteLine(article.Id);
            Console.WriteLine(article.Title);
            Console.WriteLine(article.Url);
        }
    }
    
}
