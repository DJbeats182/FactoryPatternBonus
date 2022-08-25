using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternBonus
{
    internal class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading Data into a List");
        }

        public void SaveData()
        {
            Console.WriteLine("Saving Data into a List");
        }
    }
}
