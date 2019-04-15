using System.Threading.Tasks;

namespace Ayo.API.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
