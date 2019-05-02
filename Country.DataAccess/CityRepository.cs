using Country.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country.DataAccess
{
    public class CityRepository:BaseRepository
    {
        public void AddCity(City city)
        {
            string query = @"INSERT INTO City VALUES(@nameCity,@countryId)";

            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddRange(new SqlParameter[]
            {
                new SqlParameter("@nameCity", System.Data.SqlDbType.NVarChar) { Value = city.Name},
                new SqlParameter("@countryId", System.Data.SqlDbType.Int) { Value = city.CountryId}
            });

            command.ExecuteNonQuery();
            command.Dispose();
        }

        public Countries GetCountryById(int id)
        {
            Countries country = null;
            string query = "SELECT * FROM Country Where Id = @id";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = id });
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    country = new Countries();
                    reader.Read();
                }
            }
            return country;
        }

        public City GetCityById(int id)
        {
            City city = null;
            string query = "SELECT * FROM City Where Id = @id";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = id });
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    city = new City();
                    reader.Read();
                }
            }
            return city;
        }

        public City ChangeCity(string name, int id)
        {
            City city = null;
            string query = " UPDATE City SET NameCity = @name where Id =@id";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.NVarChar) { Value = name});
                command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = id });
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    city = new City();
                    reader.Read();
                }
            }
            return city;
        }

        public City DeleteCity(int id)
        {
            City city = null;
            string query = " Delete from City where Id = @id";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = id });
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    city = new City();
                    reader.Read();
                }
            }
            return city;
        }
    }
}
