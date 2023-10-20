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
        public void Add(ModelCategorie ModelCategorie)
        {
            using (var connection = new SqlConnection("Data Source=DESKTOP-012JM51;Initial Catalog=Supermarker;Integrated Security=True;TrustServerCertificate=True;"))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categorie VALUES (@name, @observation";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = ModelCategorie.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = ModelCategorie.Observation;
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
                command.CommandText = "DELETE FROM Categorie WHERE Categorie_Id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ModelCategorie ModelCategorie)
        {
            using (var connection = new SqlConnection("Data Source=DESKTOP-012JM51;Initial Catalog=Supermarker;Integrated Security=True;TrustServerCertificate=True;"))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Categorie
                                       SET Categorie_Name =@name,
                                       Categorie_Observation = @observation
                                       WHERE Categorie_Id = @Id";
                
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = ModelCategorie.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = ModelCategorie.Observation;
                command.Parameters.Add("@Id", SqlDbType.NVarChar).Value = ModelCategorie.Id;
                command.ExecuteNonQuery();
            }
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
