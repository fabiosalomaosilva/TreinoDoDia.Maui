using TreinoDoDia.Maui.Models;
using TreinoDoDia.Maui.Services.Interfaces;

namespace TreinoDoDia.Maui.Services
{
    public class MetricasCorporaisService : IMetricasCorporaisService
    {
        public async Task AddAsync(MetricasCorporais entity)
        {


        }

        public Task<MetricasCorporais?> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MetricasCorporais>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, MetricasCorporais entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
