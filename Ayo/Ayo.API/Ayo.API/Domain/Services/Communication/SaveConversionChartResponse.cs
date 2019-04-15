using Ayo.API.Domain.Models;

namespace Ayo.API.Domain.Services.Communication
{
    public class SaveConversionChartResponse : BaseResponse
    {
        public ConversionChart ConversionChart { get; private set; }

        private SaveConversionChartResponse(bool success, string message, ConversionChart conversionChart) : base(success, message)
        {
            ConversionChart = conversionChart;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="conversionChart">Saved category.</param>
        /// <returns>Response.</returns>
        public SaveConversionChartResponse(ConversionChart conversionChart) : this(true, string.Empty, conversionChart)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SaveConversionChartResponse(string message) : this(false, message, null)
        { }
    }
}
