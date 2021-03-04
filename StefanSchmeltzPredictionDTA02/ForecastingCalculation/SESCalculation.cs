using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StefanSchmeltzPredictionDTA02.ForecastingCalculation
{
    class SESCalculation 
    {
        public double calculateForecast(double alpha, double actualValue, double prevForecast) => prevForecast + alpha * (actualValue - prevForecast);//alpha * Xt + (1 - alpha) * St_minus_1;

        public double calculateSSE(double smootPointSES, double v)=> Math.Pow((smootPointSES - v), 2);

        public Tuple<double, double> BestAlphaError(List<Tuple<double, double>> alphaErrorSES)
        {
           return  alphaErrorSES.Aggregate((left, right) =>
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

      

        public void setBestValues()
        {
            throw new NotImplementedException();
        }
    }
}
