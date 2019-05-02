using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Country.DataAccess
{
    public class BaseRepository: IDisposable
    {
        public SqlConnection _connection { get; set; }

        public BaseRepository()
        {
            try
            {
                _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionCountry"].ConnectionString);
                _connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Dispose()
        {
            _connection.Close();
        }
    }
}
