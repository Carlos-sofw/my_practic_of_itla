using Microsoft.Data.SqlClient;
using TheGreatLogbook.Entities;

namespace TheGreatLogbook.DAL
{
    public class BookDAL
    {
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public List<Book> GetAll()
        {
            List<Book> list = new List<Book>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                var cmd = new SqlCommand("SELECT * FROM Book", con);
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new Book
                    {
                        Id = (int)dr["Id"],
                        Title = dr["Title"].ToString(),
                        Genero = dr["Genero"].ToString(),
                        Price = (decimal)dr["Price"]
                    });
                }
            }
            return list;
        }

        //  SOBRECARGA
        public void Insert(string title, string Genero, decimal price)
        {
            Insert(new Book { Title = title, Genero = Genero, Price = price });
        }

        public void Insert(Book book)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                var cmd = new SqlCommand(
                    "INSERT INTO Book (Title, Genero, Price) VALUES (@t,@a,@p)", con);

                cmd.Parameters.AddWithValue("@t", book.Title);
                cmd.Parameters.AddWithValue("@a", book.Genero);
                cmd.Parameters.AddWithValue("@p", book.Price);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Book book)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                var cmd = new SqlCommand("UPDATE Book SET Title=@t, Genero=@g, Price=@p WHERE Id=@id", con);

                cmd.Parameters.AddWithValue("@t", book.Title);
                cmd.Parameters.AddWithValue("@g", book.Genero);
                cmd.Parameters.AddWithValue("@p", book.Price);
                cmd.Parameters.AddWithValue("@id", book.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                var cmd = new SqlCommand("DELETE FROM Book WHERE Id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}