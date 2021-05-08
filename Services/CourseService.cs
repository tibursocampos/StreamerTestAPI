using SS_API.Model;
using SS_API.Repositories;
using SS_API.Services.Dto;
using System.Collections.Generic;
using System.Linq;

namespace SS_API.Services
{

    /// <summary>
    /// Implementação dos métodos da interface ICourseService
    /// </summary>
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository repository;

        /// <summary>
        /// Construtor e injeção de dependência
        /// </summary>
        /// <param name="repository"></param>
        public CourseService(ICourseRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Verifica se curso buscado existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CourseExists(int id)
        {
           return repository.Get().Any(x => x.Id == id);
        }

        /// <summary>
        /// Retorna todos os cursos
        /// </summary>
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

        /// <summary>
        /// Busca o curso pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CourseDto GetById(int id)
        {
            var course = repository.Get().FirstOrDefault(x => x.Id == id);
            if (course == null)
            {
                return null;
            }
            return new CourseDto(course);
        }
    }
}
