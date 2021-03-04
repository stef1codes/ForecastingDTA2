using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefanSchmeltzPredictionDTA02.ForecastingModel
{
    class DES
    {
        private List<double> data;
        public DES(List<double> dataset)
        {
            this.data = dataset;
        }

        public List<double> DatasetDES { get; private set; }
        /*
        public List<double> SmoothingCalculation(int forecastAmount)
        {

            forecastAmount += data.Count;
            List<double> dataSetSES = new List<double> { data[0] };
            for (var i = 1; i < forecastAmount; i++)
            {
                double smoothedPointSES = i >= data.Count ? dataSetSES[data.Count - 1] : sesforecast.calculateForecast(Alpha, data[i], dataSetSES[i - 1]);
                dataSetSES.Add(smoothedPointSES);
            }
            return dataSetSES;
        }
        
        */


        public List<Tuple<double, double, double, double, double,double>> SmoothingCalculation2(int forecastAmount,
                                                                                                double aplha,
                                                                                                double trend,
                                                                                                List<double> dataset,
                                                                                                int months,
                                                                                                double startAlpha,
                                                                                                double startTrend)
        {
            double sum = 0;
            for (int i = 0; i < forecastAmount; i++)
            {
                sum += dataset[i];
            }

            double meandataset = sum / months;
            forecastAmount += data.Count;
            List<Tuple<double, double, double, double, double, double>> listSES = new List<Tuple< double,double, double, double, double, double>>();
            double linearRegression;

            for (var i = 0; i < forecastAmount; i++)
            {
                double estimate, demand, onestepforecast, forecastError, forecastError2, trendValue;
                if (0 == i)
                {
                    estimate        = startAlpha + startTrend + aplha * (dataset[i] - (startTrend + startAlpha));
                    trendValue      = startTrend +  trend * aplha *(dataset[i] - (startTrend + startAlpha));
                    demand          = data[i];
                    onestepforecast = (startTrend + startAlpha);
                    forecastError   = dataset[i] - (startTrend + startAlpha);
                    forecastError2  = Math.Pow(forecastError, 2);
                    listSES.Add(new Tuple<double, double, double, double, double, double>(demand, estimate, trendValue, onestepforecast, forecastError, forecastError2));

                }
                else if (i >= dataset.Count)
                {
                    linearRegression = listSES[dataset.Count-1].Item2 + (i - dataset.Count) * listSES[dataset.Count-1].Item3;
                    listSES.Add(new Tuple<double, double, double, double, double, double>(linearRegression, 0, 0, 0, 0,0));
                }
                else
                {
                    demand = dataset[i];
                    estimate = listSES[i - 1].Item2 + listSES[i - 1].Item3 + aplha * (dataset[i] - (listSES[i - 1].Item2 + listSES[i - 1].Item3));
                    trendValue = listSES[i - 1].Item3+trend*aplha*(dataset[i]-(listSES[i-1].Item2+listSES[i-1].Item3));
                    
                    onestepforecast = listSES[i - 1].Item2 + listSES[i - 1].Item3;
                    forecastError = demand - onestepforecast;
                    forecastError2 = Math.Pow(forecastError, 2);
                    listSES.Add(new Tuple<double, double, double, double, double, double>(demand, estimate, trendValue,onestepforecast, forecastError, forecastError2));

                }
            }
            return listSES;

        }
    }
   
}

