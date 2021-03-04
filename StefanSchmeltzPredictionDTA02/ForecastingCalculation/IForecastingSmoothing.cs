using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefanSchmeltzPredictionDTA02.ForecastingCalculation
{
    interface IForecastingSmoothing
    {
        List<double> SmoothingCalculation(int forecastAmount);
       
    }
}
