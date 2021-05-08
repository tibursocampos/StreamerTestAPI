using SS_API.Data;
using SS_API.Model;
using System.Linq;

namespace SS_API.Repositories
{
    /// <summary>
    /// Classe de repositório que tem acesso ao contexto
    /// </summary>
    public class CourseRepository : ICourseRepository
    {
        private readonly StreamerContext context;

        /// <summary>
        /// Construtor com a injeção de dependência
        /// </summary>
        /// <param name="context"></param>
        public CourseRepository(StreamerContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Implementação da interface que retorna os cursos
        /// </summary>
        /// <returns></returns>
        public IQueryable<Course> Get()
        {
            return context.Set<Course>();
        }
    }
}
