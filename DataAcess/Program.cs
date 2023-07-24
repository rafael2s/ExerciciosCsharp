﻿using Microsoft.Data.SqlClient;


namespace DataAcess;
class Program
{
    static void Main(string[] args)
    {
        const string connectionString = "Server=localhost,1433;Database=dataacessdb;User ID=SA;Password=#sa123456;TrustServerCertificate=true"; // TrustServerCertificate=true utilizado pois estava dando erro de certificado ao tentar ler dados do banco

        using (var connection = new SqlConnection(connectionString)){
            Console.WriteLine("Conectado no SqlServerImage");
            connection.Open();
            
            using(var command = new SqlCommand()){
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT [Id], [Title] FROM [Category]";

                var reader = command.ExecuteReader();
                while(reader.Read()){
                    Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
                }
            }
        }
         
        Console.WriteLine("Hello, World!");
    }
}
