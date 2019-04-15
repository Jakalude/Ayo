using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ayo.API.Domain.Models;
using Ayo.API.Domain.Services;
using Ayo.API.Domain.Repositories;
using Ayo.API.Domain.Services.Communication;

namespace Ayo.API.Services
{
    public class ConversionChartService : IConversionChartService
    {
        private readonly IConversionChartRepository _conversionChartRepository;
        //private readonly IUnitOfWork _unitOfWork;

        public ConversionChartService(IConversionChartRepository conversionChartRepository)
        {
            _conversionChartRepository = conversionChartRepository;
            //_unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ConversionChart>> ListAsync()
        {
            return await _conversionChartRepository.ListAsync();
        }

        public async Task<ConversionChart> FindByIdAsync(int id)
        {
            return await _conversionChartRepository.FindByIdAsync(id);
        }

        public async Task<SaveConversionChartResponse> SaveAsync(ConversionChart conversionChart)
        {
            try
            {
                await _conversionChartRepository.AddAsync(conversionChart);
                //await _unitOfWork.CompleteAsync();

                return new SaveConversionChartResponse(conversionChart);
            }
            catch (Exception ex)
            {
                return new SaveConversionChartResponse($"An error occurred when saving the category: {ex.Message}");
            }
        }
    }
}
