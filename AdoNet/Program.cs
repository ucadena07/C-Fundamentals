﻿using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args).Build();
var configuration = host.Services.GetService<IConfiguration>();
var connectionString = configuration.GetConnectionString("DefaultConnection");


try
{

    using (var connection = new SqlConnection(connectionString))
	{
		connection.Open();
        var query = @"INSERT INTO People (Name)
                        VALUES('Ulises Cadena')";
        using (var command = new SqlCommand(query, connection))
        {
            var rowsAffected = await command.ExecuteNonQueryAsync();
            Console.WriteLine($"Affected rows {rowsAffected}");
        }
    }
}
catch (Exception ex)
{

    Console.WriteLine("could not open the connection");
    Console.WriteLine(ex.Message);
}