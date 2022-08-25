using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternBonus
{
    internal static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType)
            {
                case "sql":
                    return new SQLDataAccess();
                case "list":
                    return new ListDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                default:
                    return new SQLDataAccess();
            }
        }
    }
}
