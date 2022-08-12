using CoreLayer.DTOs;

namespace WebLayer.Services
{
    public class VehicleApiServices
    {
        private readonly HttpClient _httpClient;

        public VehicleApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CarDto>> GetCarAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<CarDto>>("vehicle");
            return response;
        }
        public async Task<CarDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CarDto>($"vehicle/GetCarById/{id}");
            return response;
        }
        public async Task<bool> UpdateAsync(CarDto newcar)
        {
            var response = await _httpClient.PutAsJsonAsync("vehicle", newcar);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"vehicle/{id}");
            return response.IsSuccessStatusCode;

        }

    }
}
