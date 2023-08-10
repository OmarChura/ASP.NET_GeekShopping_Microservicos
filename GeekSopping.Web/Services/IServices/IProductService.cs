using GeekSopping.Web.Models;

namespace GeekSopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FinAllProducts();

        Task<ProductModel> FinProductById(long id);

        Task<ProductModel> CreateProduct(ProductModel model);

        Task<ProductModel> UpdateProduct(ProductModel model);

        Task<bool> DeleteProductById(long id);
    }
}
