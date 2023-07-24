using Dapper;
using Microsoft.Data.SqlClient;
using DataAcess.Models;


namespace DataAcess;
class Program
{
    static void Main(string[] args)
    {
        const string connectionString = "Server=localhost,1433;Database=dataacessdb;User ID=SA;Password=#sa123456;TrustServerCertificate=true"; // TrustServerCertificate=true utilizado pois estava dando erro de certificado ao tentar ler dados do banco

        using (var connection = new SqlConnection(connectionString)){
            UpadeteCategory(connection);
            ListCategories(connection);
            //CreateCategory(connection);
        } 
    }

    static void ListCategories(SqlConnection connection){

        var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
        foreach(var item in categories ){
            Console.WriteLine($"{item.Id} - {item.Title}");
        }
    }

    static void CreateCategory(SqlConnection connection){
        var category = new Category();
        category.Id = Guid.NewGuid();
        category.Title = "Amazon AWS";
        category.Url = "amazon";
        category.Description = "Categoria destinado a serviçoes do AWS";
        category.Order = 8;
        category.Summary = "AWS Cloud";
        category.Featured = false;

        var insertSql = @"INSERT INTO [Category] 
                        VALUES(
                            @Id, 
                            @Title, 
                            @Url, 
                            @Summary, 
                            @Order, 
                            @Description, 
                            @Featured)";   

        var rows = connection.Execute(insertSql, new {
            category.Id,
            category.Title,
            category.Url,
            category.Summary,
            category.Order,
            category.Description,
            category.Featured
        });
        Console.WriteLine($"{rows} linhas inseridas!");
    }

    static void UpadeteCategory(SqlConnection connection){
        var updadeQuery = "UPDATE [Category] SET [Title]=@title WHERE [Id]=@id";
        var rows = connection.Execute(updadeQuery, new{
            id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"),
            title = "Frontend 2023"
        });

        Console.WriteLine($"{rows} registros atualizadas!");
    }
}
