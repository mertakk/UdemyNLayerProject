using System.Threading.Tasks;
using UdemyNLayerProject.Core.Models;

namespace UdemyNLayerProject.Core.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}