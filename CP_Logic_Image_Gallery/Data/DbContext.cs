using Microsoft.Data.Sqlite;
using System.Data;

namespace CP_Logic_Image_Gallery.Data
{
    public class DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection()
            => new SqliteConnection(_connectionString);
    }
}
