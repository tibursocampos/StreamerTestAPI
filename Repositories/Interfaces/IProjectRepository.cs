using SS_API.Model;
using System.Linq;
using System.Threading.Tasks;

namespace SS_API.Repositories
{
    public interface IProjectRepository
    {
        Task Create(Project project);
        IQueryable<Project> Get();
        Task Delete(int id);
        Task Update(Project project);
    }
}