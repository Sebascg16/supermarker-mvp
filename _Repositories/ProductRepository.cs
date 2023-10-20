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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection("Data Source=DESKTOP-012JM51;Initial Catalog=Supermarker;Integrated Security=True;TrustServerCertificate=True;"))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Product ORDER By Product_Id DESC";
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
