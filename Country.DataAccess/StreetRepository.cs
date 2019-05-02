using Country.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country.DataAccess
{
    public class StreetRepository: BaseRepository
    {
        public void AddStreet(Street street)
        {
            string query = @"INSERT INTO StreetTable VALUES(@nameStreet, @cityId)";

            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddRange(new SqlParameter[]
            {
                new SqlParameter("@nameStreet", System.Data.SqlDbType.NVarChar) { Value = street.Name},
                new SqlParameter("@cityId", System.Data.SqlDbType.Int) { Value = street.CityId}
            });

            command.ExecuteNonQuery();
            command.Dispose();
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

        public Street GetStreetById(int id)
        {
            Street street = null;
            string query = "SELECT * FROM StreetTable Where Id = @id";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = id });
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    street = new Street();
                    reader.Read();
                }
            }
            return street;
        }

        public Street ChangeStreet(string name, int id)
        {
            Street street = null;
            string query = " UPDATE StreetTable SET NameCity = @name where Id =@id";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.NVarChar) { Value = name });
                command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = id });
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    street = new Street();
                    reader.Read();
                }
            }
            return street;
        }

        public Street DeleteStreet(int id)
        {
            Street street = null;
            string query = " Delete from StreetTable where Id =@id";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = id });
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    street = new Street();
                    reader.Read();
                }
            }
            return street;
        }
    }
}
