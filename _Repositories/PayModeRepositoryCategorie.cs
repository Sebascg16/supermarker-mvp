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
    internal class PayModeRepositoryCategorie : BaseRepository, IPayModeRepositoryCategorie
    {
        public PayModeRepositoryCategorie(string ConnectionString) 
        {
            this.connectionString = ConnectionString;
        }
        public void Add(PayModeModelCategorie payModeModelCategorie)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(PayModeModelCategorie payModeModelCategorie)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayModeModelCategorie> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayModeModelCategorie> GetByValue(string value)
        {
            var payModeList = new List <PayModeModelCategorie>();
            using (var connection = new SqlConnection("Data Source=DESKTOP-012JM51;Initial Catalog=Supermarker;Integrated Security=True;TrustServerCertificate=True;"))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM PayMode ORDER BY Pay_Mode_ID DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var PayModeModelCategorie = new PayModeModelCategorie();
                        PayModeModelCategorie.Id = (int)reader["Pay_Mode_Categorie_Id"];
                        PayModeModelCategorie.Name = reader["Pay_Mode_Categorie_Name"].ToString();
                        PayModeModelCategorie.Observation = reader["Pay_Mode_Categorie_Observation"].ToString();
                        payModeList.Add(PayModeModelCategorie);
                    }
                }
            }
            return payModeList;
        }
    }
}
