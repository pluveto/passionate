using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passionate.Database
{
    class QueryFactoryBuilder
    {
        public static QueryFactory BuildForSqlite(string fileName)
        {
            string connStr = $"Data Source={fileName};";
            var connection = new SQLiteConnection(connStr);
            var compiler = new SqliteCompiler();
            var DB = new QueryFactory(connection, compiler);
            return DB;
        }
    }
}
