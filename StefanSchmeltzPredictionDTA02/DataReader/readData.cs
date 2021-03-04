using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefanSchmeltzPredictionDTA02.DataReader
{
    class readData
    {

        public List<double> getData()
        {
            var dataSet = File.ReadAllLines("SwordsDemand.csv")
                .Select(line => double.Parse(line.Split(',').ElementAt(1)))
                .ToList();
            return dataSet;
        }
    }
}
