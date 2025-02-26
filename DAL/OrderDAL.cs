using Dapper;
using Npgsql;
using MiniSiparisYonetimi.Models;

namespace MiniSiparisYonetimi.DAL
{
  public class OrderDAL
{
    private readonly string _connectionString;

    public OrderDAL(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Order> GetOrders()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            return connection.Query<Order>("SELECT * FROM Orders").ToList();
        }
    }

        internal void AddOrder(Order order)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
                using (var command = new NpgsqlCommand("INSERT INTO Orders (CustomerId, OrderTime, TotalPrice) VALUES (@CustomerId, @OrderDate, @TotalAmount)", connection))
        {
            command.Parameters.AddWithValue("@CustomerId", order.CustomerId);
            command.Parameters.AddWithValue("@OrderDate", order.OrderTime);
            command.Parameters.AddWithValue("@TotalAmount", order.TotalPrice);

            command.ExecuteNonQuery(); // Ekleme işlemi için  kullanılır.
        }
    }
        } 
        

        internal int GetSon24SaatSiparisSayisi(int customerId)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT COUNT(*) FROM Orders WHERE CustomerId = @CustomerId AND OrderTime >= NOW() - INTERVAL '24 hours'", connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    return (int)command.ExecuteScalar();
                }
            }
        }
        public List<Order> EnCokSiparisVerenMusteriler()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                //Sipariş sayfasındaki en çok sipariş veren 5 musteriyi getiren SQL sorgusu
                return connection.Query<Order>("SELECT CustomerId, COUNT(*) AS SiparisSayisi FROM Orders GROUP BY CustomerId ORDER BY SiparisSayisi DESC").Take(5).ToList();
            }
        }

        
    }
}