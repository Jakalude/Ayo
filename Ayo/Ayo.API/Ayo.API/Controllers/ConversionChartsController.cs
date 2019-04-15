using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ayo.API.Domain.Models;
using Ayo.API.Domain.Services;
using Ayo.API.Extensions;
using AutoMapper;
using Ayo.API.Resources;
using System;

namespace Ayo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionChartsController : Controller
    {
        private readonly IConversionChartService _conversionChartsService;
        private readonly IMapper _mapper;

        public ConversionChartsController(IConversionChartService conversionChartsService, IMapper mapper)
        {
            _conversionChartsService = conversionChartsService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ConversionChartResource>> GetAllAsync()
        {
            var conversionCharts = await _conversionChartsService.ListAsync();
            var resources = _mapper.Map<IEnumerable<ConversionChart>, IEnumerable<ConversionChartResource>>(conversionCharts);
            return resources;
        }

        public async Task<ConversionChartResource> FindByIdAsync(int id)
        {

            var conversionChart = await _conversionChartsService.FindByIdAsync(id);
            var resources = _mapper.Map<ConversionChart, ConversionChartResource>(conversionChart);
            return resources;

        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCategoryResource resource)
        {
            throw new System.NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveCategoryResource resource)
        {
            throw new System.NotImplementedException();
        }
    }
}