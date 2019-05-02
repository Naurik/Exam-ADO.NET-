using Country.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country.DataAccess
{
    public class CountryRepository:BaseRepository
    {

        public void AddCountry(Countries country)
        {
            string query = @"INSERT INTO Country VALUES(@nameCountry)";

            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddRange(new SqlParameter[]
            {
                new SqlParameter("@nameCountry", System.Data.SqlDbType.NVarChar) { Value = country.Name}
            });

            command.ExecuteNonQuery();
            command.Dispose();
        }

        public Countries GetCountryById(int id)
        {
            Countries country = null;
            string query = "SELECT * FROM City Where Id = @id";
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

        public Countries ChangeCountry(string name, int id)
        {
            Countries country = null;
            string query = " UPDATE Country SET NameCountry = @name where Id =@id";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.NVarChar) { Value = name });
                command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = id });
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    country = new Countries();
                    reader.Read();
                }
            }
            return country;
        }

        public Countries DeleteCountry(int id)
        {
            Countries country = null;
            string query = " Delete from Country where Id =@id";
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

    }
}
