using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternBonus
{
    internal class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading Data into a Mongo DB");
        }

        public void SaveData()
        {
            Console.WriteLine("Loading Data into a Mongo DB");
        }
    }
}
