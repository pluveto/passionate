using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlKata.Execution;

namespace Passionate.Database
{
    public class DatabaseManager
    {
        private QueryFactory queryFactory { get; set; }
        public DatabaseManager(QueryFactory DB)
        {
            queryFactory = DB;
            try
            {
                DB.Connection.Open();
            }
            catch (Exception e)
            {
                throw new Exception("无法连接到数据库: " + e.ToString());
            }
        }

        public QueryFactory GetQueryFactory()
        {
            if (queryFactory == null)
            {
                throw new Exception("未初始化数据库!");
            }
            return queryFactory;
        }
    }
}