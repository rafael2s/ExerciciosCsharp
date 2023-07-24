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

            var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
            foreach(var category in categories ){
                Console.WriteLine($"{category.Id} - {category.Title}");
            }
        } 
    }
}
