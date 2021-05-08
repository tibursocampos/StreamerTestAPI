using Microsoft.AspNetCore.Mvc;
using SS_API.Services;
using SS_API.Services.Dto;
using System.Collections.Generic;

namespace SS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [HttpGet]
        public ActionResult<List<CourseDto>> GetAll()
        {
            var courses = courseService.GetAll();
            return courses;
        }

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
