using SS_API.Data;
using SS_API.Model;
using System.Linq;

namespace SS_API.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly StreamerContext context;

        public CourseRepository(StreamerContext context)
        {
            this.context = context;
        }
        public IQueryable<Course> Get()
        {
            return context.Set<Course>();
        }
    }
}
