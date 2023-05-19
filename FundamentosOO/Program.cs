using FundamentosOO.ContentContext;
using FundamentosOO.SubscriptionContext;

namespace FundamentosOO;
class Program
{
    static void Main(string[] args)
    {
        
        var articles = new List<Article>();
        articles.Add(new Article("Artigo Sobre OO", "Fundamentos OO"));
        articles.Add(new Article("Artigo Sobre DOTNET", "Tudo sobre .NET"));
        articles.Add(new Article("Artigo Sobre C#", "Tudo sobre C# !!!"));

        // foreach(var article in articles){
        //     Console.WriteLine(article.Id);
        //     Console.WriteLine(article.Title);
        //     Console.WriteLine(article.Url);
        // }

        var courses = new List<Course>();
        var courseOO = new Course("Fundamentos OO", "Fundamentos-oo");
        var courseCsharp = new Course("Fundamentos C#", "Fundamentos-csharp");
        var courseAspNet = new Course("Fundamentos ASP.NET", "Fundamentos-aspnet");

        courses.Add(courseOO);
        courses.Add(courseCsharp);
        courses.Add(courseAspNet);

        var carrers = new List<Carrer>();
        var carrerDotNet = new Carrer("Especialist .NET", "especialista-dotnet");
        var CarrerItem2 = new CarrerItem(2, "Aprenda C#", "", null);
        var CarrerItem = new CarrerItem(1, "Comece por aqui", "", courseCsharp);
        var CarrerItem3 = new CarrerItem(3, "Aprenda AspNet", "", courseAspNet);

        carrerDotNet.Items.Add(CarrerItem2);
        carrerDotNet.Items.Add(CarrerItem3);
        carrerDotNet.Items.Add(CarrerItem);
        carrers.Add(carrerDotNet);

        foreach(var carrer in carrers){
            Console.WriteLine(carrer.Title);
            foreach(var item in carrer.Items.OrderBy(x => x.Order)){
                Console.WriteLine($"{item.Order} - {item.Title}");
                Console.WriteLine(item.Course?.Title);
                Console.WriteLine(item.Course?.Level);

                foreach(var notification in item.Notifications){
                    Console.WriteLine($"{notification.Property} - {notification.Message}");
                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.Subscriptions.Add(payPalSubscription);
            }
        }
    }  
}
