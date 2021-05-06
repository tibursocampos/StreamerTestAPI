using SS_API.Services.Dto;
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
        List<CourseDto> GetAll();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool CourseExists(int id);
    }
}
