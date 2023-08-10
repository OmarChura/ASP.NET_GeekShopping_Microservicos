using GeekSopping.Web.Models;
using GeekSopping.Web.Services.IServices;
using GeekSopping.Web.Utils;

namespace GeekSopping.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public const string Basepath = "api/v1/product";

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));   
        }

        public async Task<IEnumerable<ProductModel>> FinAllProducts()
        {
            var response = await _httpClient.GetAsync(Basepath);

            return await response.ReadContentAsync<List<ProductModel>>();
        }

        public async Task<ProductModel> FinProductById(long id)
        {
            var response = await _httpClient.GetAsync($"{Basepath}/{id}");

            return await response.ReadContentAsync<ProductModel>();
        }

        public async Task<ProductModel> CreateProduct(ProductModel model)
        {
            var response = await _httpClient.PostAsyncJson(Basepath, model);

            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAsync<ProductModel>();
            }
            else 
            {
                throw new Exception("something went wrong when calling API");
            }


        }

        public async Task<ProductModel> UpdateProduct(ProductModel model)
        {
            var response = await _httpClient.PutAsyncJson(Basepath, model);

            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAsync<ProductModel>();
            }
            else
            {
                throw new Exception("something went wrong when calling API");
            }
        }

        public async Task<bool> DeleteProductById(long id)
        {
            var response = await _httpClient.DeleteAsync($"{Basepath}/{id}");

            if (response.IsSuccessStatusCode)
            {

                return await response.ReadContentAsync<bool>();
            }
            else
            {
                throw new Exception("something went wrong when calling API");
            }
        }

    }
}
