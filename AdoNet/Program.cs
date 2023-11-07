using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
 
using IHost host = Host.CreateDefaultBuilder(args).Build();
var configuration = host.Services.GetService<IConfiguration>();
var connectionString = configuration.GetConnectionString("DefaultConnection");

var name = "Alondra Cadena";
try
{

    using (var connection = new SqlConnection(connectionString))
	{
		connection.Open();
        var query = @"People_Insert";
        using (var command = new SqlCommand(query, connection))
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            var paramterId = new SqlParameter
            {
                ParameterName = "@id",
                Direction= System.Data.ParameterDirection.Output,
                DbType = System.Data.DbType.Int32
            };
            command.Parameters.Add(paramterId);

            command.Parameters.Add(new SqlParameter("@name", name));
            var rowsAffected = await command.ExecuteNonQueryAsync();
            Console.WriteLine($"Affected rows {rowsAffected}");
            var id = (int)paramterId.Value;
            Console.WriteLine($"new id: {id}");
        }
    }
}
catch (Exception ex)
{

    Console.WriteLine("could not open the connection");
    Console.WriteLine(ex.Message);
}