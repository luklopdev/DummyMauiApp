using DummyMauiApp.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace DummyMauiApp.Services
{
    public class DummySevice
    {
        private const string BASE_URL = "https://dummyjson.com/";

        private readonly HttpClient _httpClient;

        private List<Product> _products = new();

        public DummySevice()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri(BASE_URL)};
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            if(_products.Count > 0)
            {
                return _products;
            }

            var response = await _httpClient.GetAsync("products");

            if (response.IsSuccessStatusCode)
            {
                var productsResponse = await response.Content.ReadFromJsonAsync<ProductsResponse>();
                _products = productsResponse!.products;
            }

            return _products;
        }
    }
}
