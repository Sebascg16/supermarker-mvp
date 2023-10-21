using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket__mvp.Models;
using System.Data;

namespace Supermarket__mvp._Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString) 
        { 
            this.connectionString = connectionString;
        }
        public void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection("Data Source=DESKTOP-012JM51;Initial Catalog=Supermarker;Integrated Security=True;TrustServerCertificate=True;"))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "INSERT INTO Producto VALUES (@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = productModel.Observation;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection("Data Source=DESKTOP-012JM51;Initial Catalog=Supermarker;Integrated Security=True;TrustServerCertificate=True;"))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "DELETE FROM Producto WHERE Product_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();

            }
        }

        public void Edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection("Data Source=DESKTOP-012JM51;Initial Catalog=Supermarker;Integrated Security=True;TrustServerCertificate=True;"))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.CommandText = @"UPDATE Producto
                                      SET Product_Name = @name,
                                      Product_Observation = @observation,
                                      WHERE Product_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = productModel.Observation;
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = productModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection("Data Source=DESKTOP-012JM51;Initial Catalog=Supermarker;Integrated Security=True;TrustServerCertificate=True;"))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Producto ORDER By Product_Id DESC";
                using (var reader = command.ExecuteReader()) 
                {
                  while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Id = (int)reader["Product_Id"];
                        productModel.Name = reader["Product_Name"].ToString();
                        productModel.Observation = reader["Product_Observation"].ToString();
                        productList.Add(productModel);
                    }                
                }

            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
