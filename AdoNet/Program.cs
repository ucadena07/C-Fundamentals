using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data;

using IHost host = Host.CreateDefaultBuilder(args).Build();
var configuration = host.Services.GetService<IConfiguration>();
var connectionString = configuration.GetConnectionString("DefaultConnection");


try
{

    using (var connection = new SqlConnection(connectionString))
	{
		connection.Open();
        var query = @"SELECT * FROM People";
        using (var command = new SqlCommand(query, connection))
        {
            using(SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dataRow in dt.Rows)
                {
                    Console.WriteLine($"{dataRow["Id"]} | {dataRow["Name"]}");
                }
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}