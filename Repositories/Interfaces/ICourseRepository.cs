using SS_API.Model;
using System.Linq;

namespace SS_API.Repositories
{
    public interface ICourseRepository
    {
        IQueryable<Course> Get();
    }
}
