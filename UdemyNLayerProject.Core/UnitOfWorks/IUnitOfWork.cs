using System.Threading.Tasks;
using UdemyNLayerProject.Core.Repositories;

namespace UdemyNLayerProject.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        
        ICategoryRepository categories { get; }
        
        Task CommitAsync();

        void Commit();
    }
}