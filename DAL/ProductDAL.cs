using Microsoft.EntityFrameworkCore;
using MiniSiparisYonetimi.Models;
using Npgsql;
using Dapper;

namespace MiniSiparisYonetimi.DAL
{
  public class ProductDAL
{
    private readonly string _connectionString;

    public ProductDAL(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

        public ProductDAL(string? connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Product> GetProducts()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            return connection.Query<Product>("SELECT * FROM Products").ToList();
        }
    }

        internal void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        // Diğer DAL metotları buraya eklenebilir.
    }
}
 
