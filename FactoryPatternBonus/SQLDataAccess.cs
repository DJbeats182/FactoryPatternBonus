using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternBonus
{
    internal class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading Data into a SQL DB");
        }

        public void SaveData()
        {
            Console.WriteLine("Loading Data into a SQL DB");
        }
    }
}
