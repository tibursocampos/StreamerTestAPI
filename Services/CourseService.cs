using SS_API.Data;
using SS_API.Model;
using System.Collections.Generic;
using System.Linq;

namespace SS_API.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICourseService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Course> GetAll();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool CourseExists(int id);
    }

    /// <summary>
    /// 
    /// </summary>
    public class CourseService : ICourseService
    {
        private readonly StreamerContext db;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public CourseService(StreamerContext context)
        {
            db = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CourseExists(int id)
        {
            return db.Courses.Any(p => p.Id == id);
        }
    }
}
