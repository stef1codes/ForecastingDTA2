using StefanSchmeltzPredictionDTA02.ForecastingCalculation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefanSchmeltzPredictionDTA02.ForecastingModel
{
    class SES { 

        private List<double> data;
  
        public double Alpha { get; set; }
        public double SSE1 { get; set; }

        public SESCalculation sesforecast = new SESCalculation();
        public SES(List<double> dataSet) {
            data = dataSet;
            setBestValueSES();
        }
        public Tuple<double, double> GetBestValues() => new Tuple<double, double>(Alpha, SSE1);

        private void setBestValueSES()
        {
            var alphaErrorSES = new List<Tuple<double, double>>();
            var SSE = 0.0;
            for (var i = 0.0; i < 1.0; i += 0.01)
            {
                var dataSetSES = SmoothingCalculation2(12, i, data, 12);
                SSE = dataSetSES.Sum(x => x.Item2);
                
                SSE = Math.Sqrt(SSE / (data.Count - 1));
                alphaErrorSES.Add(new Tuple<double, double>(i, SSE));
            }

            var bestSSE = alphaErrorSES.OrderBy(x => x.Item2).First();
            Alpha = bestSSE.Item1;
            SSE1  = bestSSE.Item2; 
        }

     
        public List<Tuple<double, double,double, double, double>> SmoothingCalculation2(int forecastAmount,double aplha,List<double>dataset,int months)
        {
            //sum of demands 
            double sum = 0;
            for (int i = 0; i < forecastAmount; i++)
            {
                sum += dataset[i];
            }
            //mean for start value for estimate
            double meandataset = sum / months;
            forecastAmount += data.Count;

            List<Tuple<double, double,double, double, double>> listSES = new List<Tuple<double, double,double, double, double>>();


            for (var i = 0; i < forecastAmount; i++)
            {
                double estimate, demand, onestepforecast,forecastError, forecastError2; 
                if (0 == i)
                {
                    estimate =  sesforecast.calculateForecast(aplha, dataset[i], meandataset);
                    demand   = data[i];
                    onestepforecast = meandataset;
                    forecastError = demand - meandataset;
                    forecastError2 = Math.Pow((demand - meandataset),2);
                    listSES.Add( new Tuple<double, double, double, double, double>(demand,estimate, onestepforecast, forecastError, forecastError2));

                }
                else if(i >= dataset.Count)
                {

                    listSES.Add(new Tuple<double, double,double, double, double>(listSES[dataset.Count-1].Item2,0, 0,0,0));
                }
                else
                {
                    estimate = sesforecast.calculateForecast(aplha, dataset[i], listSES[listSES.Count - 1].Item2);
                    demand = dataset[i];
                    onestepforecast = listSES[i - 1].Item2;
                    forecastError = demand - listSES[i - 1].Item2;
                    forecastError2 = Math.Pow((demand - listSES[i - 1].Item2),2);
                    listSES.Add(new Tuple<double, double, double, double, double>(demand, estimate, onestepforecast, forecastError, forecastError2));
                    
                }
            }
            return listSES;
        }
    }
}
