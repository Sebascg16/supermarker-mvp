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
    internal class RepositoryCategorie : BaseRepository, IRepositoryCategorie
    {
        public RepositoryCategorie(string ConnectionString) 
        {
            this.connectionString = ConnectionString;
        }
        public void Add(ModelCategorie payModeModelCategorie)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ModelCategorie payModeModelCategorie)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ModelCategorie> GetAll()
        {
            var categorielist = new List<ModelCategorie>();
            using (var connection = new SqlConnection("Data Source=DESKTOP-012JM51;Initial Catalog=Supermarker;Integrated Security=True;TrustServerCertificate=True;"))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categorie ORDER BY Pay_Mode_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ModeModelCategorie = new ModelCategorie();
                        ModeModelCategorie.Id = (int)reader["Categorie_Id"];
                        ModeModelCategorie.Name = reader["Categorie_Name"].ToString();
                        ModeModelCategorie.Observation = reader["Categorie_Observation"].ToString();
                        categorielist.Add(ModeModelCategorie);
                    }
                }
            }
            return categorielist;
        }

        public IEnumerable<ModelCategorie> GetByValue(string value)
        {
            var categorieList = new List <ModelCategorie>();
            using (var connection = new SqlConnection("Data Source=DESKTOP-012JM51;Initial Catalog=Supermarker;Integrated Security=True;TrustServerCertificate=True;"))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categorie ORDER BY Pay_Mode_ID DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ModelCategorie = new ModelCategorie();
                        ModelCategorie.Id = (int)reader["Categorie_Id"];
                        ModelCategorie.Name = reader["Categorie_Name"].ToString();
                        ModelCategorie.Observation = reader["Categorie_Observation"].ToString();
                        categorieList.Add(ModelCategorie);
                    }
                }
            }
            return categorieList;
        }
    }
}
