using SS_API.Model;
using System.Linq;

namespace SS_API.Repositories
{
    /// <summary>
    /// Interface para CourseRepository
    /// </summary>
    public interface ICourseRepository
    {
        /// <summary>
        /// Retorna todos os cursos
        /// </summary>
        /// <returns></returns>
        IQueryable<Course> Get();
    }
}
