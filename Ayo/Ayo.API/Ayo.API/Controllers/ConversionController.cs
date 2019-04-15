using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ayo.API.Domain.Models;
using UnitsNet;
using Newtonsoft.Json.Linq;

namespace Ayo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : Controller
    {
        [HttpGet]
        public async Task<Conversion> Conversion(ConversionChart conversionChart, double pvalue, EUnit SourceUnit)
        {
            double calculation = 0.0;


            switch (SourceUnit)
            {
                case EUnit.Metric:
                    {
                        calculation = UnitConverter.ConvertByName(pvalue, conversionChart.Category.Name.ToString(), conversionChart.Metric.ToString(), conversionChart.Imperial.ToString());
                        break;
                    }
                case EUnit.Imperial:
                    {
                        calculation = UnitConverter.ConvertByName(pvalue, conversionChart.Category.Name.ToString(), conversionChart.Imperial.ToString(), conversionChart.Metric.ToString());
                        break;
                    }
                default: break;
            }

            var conversion = new Conversion();//this should not be the closure
            ////This should be building the task<results> time is against me
            //{
            //    value = 11,
            //    Newvalue = 22,
            //    ConversionChartId =1
            //};

            return conversion;
        }
    }
}