using Passionate.Database;
using Passionate.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Passionate
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public DatabaseManager DatabaseManager { get; private set; }

        public App()
        {
            this.Initialize();
        }

        private void Initialize()
        {
            var dataFileName = PathUtil.GetAppPath("user_data.db");
            if (!System.IO.File.Exists(dataFileName))
            {
                CreatePasswordDatabase(dataFileName);
            }
            this.DatabaseManager = new DatabaseManager(QueryFactoryBuilder.BuildForSqlite(dataFileName));
        }

        private void CreatePasswordDatabase(string dataFileName)
        {
            SQLiteConnection.CreateFile(dataFileName);
            var db = QueryFactoryBuilder.BuildForSqlite(dataFileName);
            db.Connection.Open();

            var statement =
            "CREATE TABLE \"crendentials\"("+
                "\"id\"    INTEGER NOT NULL UNIQUE,"+
                "\"title\" TEXT NOT NULL,"+
                "\"location\"  TEXT,"+
                "\"username\"  TEXT NOT NULL,"+
                "\"password\"  TEXT NOT NULL,"+
                "PRIMARY KEY(\"id\" AUTOINCREMENT)"+
            ");" ;
            var cmd = new SQLiteCommand(statement, (SQLiteConnection)db.Connection);
            cmd.ExecuteNonQuery();
            db.Connection.Close();
        }
    }
}
