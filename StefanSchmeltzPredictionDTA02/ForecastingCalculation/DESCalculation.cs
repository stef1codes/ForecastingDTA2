using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefanSchmeltzPredictionDTA02.ForecastingCalculation
{
    class DESCalculation 
    {
        public double calculateForecast(double alpha, double actualValue, double prevForecast) => 
            prevForecast + alpha * (actualValue - prevForecast);

        public double calculateSSE(double smootPointSES, double v) => Math.Pow((smootPointSES - v), 2);

        public Tuple<double, double> BestAlphaError(List<Tuple<double, double>> alphaErrorSES)
        {
            return alphaErrorSES.Aggregate((left, right) =>
            {
                if (left.Item2 < right.Item2)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            });
        }


    }
}
