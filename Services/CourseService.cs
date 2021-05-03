using SS_API.Model;
using SS_API.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SS_API.Services
{

    /// <summary>
    /// 
    /// </summary>
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public CourseService(ICourseRepository context)
        {
            this.context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Course> GetAll()
        {
            return context.Get().ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CourseExists(int id)
        {
            return context.Get().Any(p => p.Id == id);
        }
    }
}
