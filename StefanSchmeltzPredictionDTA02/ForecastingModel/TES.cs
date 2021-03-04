using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefanSchmeltzPredictionDTA02.ForecastingModel
{
    class TES
    {
        public TES(List<double> dataset)
        {
            this.DatasetTES = dataset;
        }

        public List<double> DatasetTES { get; private set; }
    }
}
