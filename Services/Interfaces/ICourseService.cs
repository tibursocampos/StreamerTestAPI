using SS_API.Model;
using System.Collections.Generic;

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
}
