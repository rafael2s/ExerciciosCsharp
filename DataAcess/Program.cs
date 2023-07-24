using Dapper;
using Microsoft.Data.SqlClient;
using DataAcess.Models;


namespace DataAcess;
class Program
{
    static void Main(string[] args)
    {
        const string connectionString = "Server=localhost,1433;Database=dataacessdb;User ID=SA;Password=#sa123456;TrustServerCertificate=true"; // TrustServerCertificate=true utilizado pois estava dando erro de certificado ao tentar ler dados do banco

        var category = new Category();
        category.Id = Guid.NewGuid();
        category.Title = "Amazon AWS";
        category.Url = "amazon";
        category.Description = "Categoria destinado a serviçoes do AWS";
        category.Order = 8;
        category.Summary = "AWS Cloud";
        category.Featured = false;

        var insertSql = @"INSERT INTO [Categoty] 
                        VALUES(
                            NEWID(), 
                            title, 
                            url, 
                            summary, 
                            order, 
                            description, 
                            featured)";

        using (var connection = new SqlConnection(connectionString)){

            var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
            foreach(var item in categories ){
                Console.WriteLine($"{item.Id} - {item.Title}");
            }
        } 
    }
}
