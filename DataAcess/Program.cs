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
            //CreateCategory(connection);
            //CreateManyCategories(connection);
            //UpadeteCategory(connection);
            //DeleteCategory(connection);
            //ListCategories(connection);
            //GetCategory(connection);
            ExecuteProcedure(connection);
            
        } 
    }

    static void ListCategories(SqlConnection connection){

        var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
        foreach(var item in categories ){
            Console.WriteLine($"{item.Id} - {item.Title}");
        }
    }

    static void GetCategory(SqlConnection connection)
    {
        var category = connection
            .QueryFirstOrDefault<Category>(
                "SELECT TOP 1 [Id], [Title] FROM [Category] WHERE [Id]=@id",
                new
                {
                    id = "af3407aa-11ae-4621-a2ef-2028b85507c4"
                });
        Console.WriteLine($"{category.Id} - {category.Title}");

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
    static void DeleteCategory(SqlConnection connection)
    {
        var deleteQuery = "DELETE [Category] WHERE [Id]=@id";
        var rows = connection.Execute(deleteQuery, new
        {
            id = new Guid("eb54b251-8c1c-48e7-9214-487243cf6608"),
        });

        Console.WriteLine($"{rows} registros excluídos");
    }

    static void CreateManyCategories(SqlConnection connection){
       
        var category = new Category();
        category.Id = Guid.NewGuid();
        category.Title = "Amazon AWS";
        category.Url = "amazon";
        category.Description = "Categoria destinada a serviçoes do AWS";
        category.Order = 8;
        category.Summary = "AWS Cloud";
        category.Featured = false;

         var category2 = new Category();
        category2.Id = Guid.NewGuid();
        category2.Title = "Google Cloud";
        category2.Url = "google-cloud";
        category2.Description = "Categoria destinada a serviços do Google Cloud";
        category2.Order = 9;
        category2.Summary = "Google Cloud";
        category2.Featured = true;

        var insertSql = @"INSERT INTO [Category] 
                        VALUES(
                            @Id, 
                            @Title, 
                            @Url, 
                            @Summary, 
                            @Order, 
                            @Description, 
                            @Featured)";   

        var rows = connection.Execute(insertSql, new[] {
            new{
                category.Id,
                category.Title,
                category.Url,
                category.Summary,
                category.Order,
                category.Description,
                category.Featured
            },
            new{
                category2.Id,
                category2.Title,
                category2.Url,
                category2.Summary,
                category2.Order,
                category2.Description,
                category2.Featured
            }
        });
        Console.WriteLine($"{rows} linhas inseridas!");
    }

    static void ExecuteProcedure(SqlConnection connection){
        var procedure = "spDeleteStudent";
        var pars = new { StudentId = "aa78e451-e5d2-4b07-8928-58b4d90d4286" };
        var affectedRows = connection.Execute(procedure, pars, commandType: System.Data.CommandType.StoredProcedure);

        Console.WriteLine($"{affectedRows} linhas afetadas");
    }
}
