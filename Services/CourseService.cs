using SS_API.Model;
using SS_API.Repositories;
using SS_API.Services.Dto;
using System.Collections.Generic;
using System.Linq;

namespace SS_API.Services
{

    /// <summary>
    /// 
    /// </summary>
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository repository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public CourseService(ICourseRepository repository)
        {
            this.repository = repository;
        }

        public bool CourseExists(int id)
        {
           return repository.Get().Any(x => x.Id == id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CourseDto> GetAll()
        {
            List<CourseDto> courseList = new List<CourseDto>();
            var courses = repository.Get().OrderBy(x => x.Name).ToList();

            foreach (var course in courses)
            {
                courseList.Add(new CourseDto(course));
            }

            return courseList;
        }
    }
}
