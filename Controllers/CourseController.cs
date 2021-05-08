using Microsoft.AspNetCore.Mvc;
using SS_API.Services;
using SS_API.Services.Dto;
using System.Collections.Generic;

namespace SS_API.Controllers
{
    /// <summary>
    /// Classes para expor os recursos para os usuários finais através de requisições Http.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private ICourseService courseService;

        /// <summary>
        /// Construtor e injeção de dependência
        /// </summary>
        /// <param name="courseService"></param>
        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        /// <summary>
        /// Retorna todos os cursos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<CourseDto>> GetAll()
        {
            var courses = courseService.GetAll();
            return courses;
        }

        /// <summary>
        /// Busca o curso pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<CourseDto> GetById(int id)
        {
            var course = courseService.GetById(id);
            if (course == null)
            {
                return NotFound(new { message = "Curso não encontrado !!!" });
            }
            return course;
        }
    }
}
