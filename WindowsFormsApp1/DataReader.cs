using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DataReader
    {
        public static Dictionary<int, int> getData()
        {
            Dictionary<int, List<int>> data = new Dictionary<int, int>();
            using (var fs = File.OpenRead(@"../userItem.data"))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                     = new DemandPoint();
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    demandPoint.time = Convert.ToInt32(values[0]);
                    demandPoint.demand = Convert.ToSingle(values[1]);

                    demandPointsList.Add(demandPoint);
                }
            }
            return demandPointsList;
        }
    }
}
