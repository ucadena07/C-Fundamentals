using AdoNet;
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

                var people = dt.AsEnumerable().Select(row =>
                {
                   return  new Person()
                    {
                        Id = row.Field<int>("Id"),
                        Name = row.Field<string>("Name")
                    };
                });
                foreach (Person p in people)
                {
                    Console.WriteLine($"{p.Id} | {p.Name}");
                }
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}