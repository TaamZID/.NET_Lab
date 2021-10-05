using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Product.Models.Entity;

namespace Product.Models.Tables
{
    public class Products
    {
        SqlConnection conn;
        public Products(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Add(Productype p)
        {
            string query = String.Format("Insert into ProductList values ('{0}','{1}','{2}','{3}')", p.Name, p.Price, p.Quantity, p.Description);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public Productype Get(int id)
        {
            return null;
        }
        public List<Productype> GetAll()
        {
            string query = "select * from ProductList";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Productype> products = new List<Productype>();
            while (reader.Read())
            {
                Productype s = new Productype()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Price = reader.GetInt32(reader.GetOrdinal("Price")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Description = reader.GetString(reader.GetOrdinal("Description"))
                };
                products.Add(s);
            }
            conn.Close();
            return products;
        }

        public Productype AddToCart (int Id)
        {
            string query = String.Format("select * from ProductList where Id = {0}",Id);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Productype product= null;
            while (reader.Read())
            {
                 product = new Productype()
                 {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Price = reader.GetInt32(reader.GetOrdinal("Price")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Description = reader.GetString(reader.GetOrdinal("Description"))
                 };
            }
            conn.Close();
            return product;
        }
        public void Update(Productype p)
        {
            string query = String.Format("UPDATE ProductList SET name='{0}', price={1}, quantity={2}, description='{3}' WHERE id={4}", p.Name, p.Price, p.Quantity, p.Description, p.Id);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(int id)
        {
            string query = String.Format("DELETE FROM ProductList WHERE id={0}", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}