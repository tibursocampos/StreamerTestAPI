using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SS_API.Model;
using SS_API.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectService projectService;
        private ICourseService courseService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectService"></param>
        /// <param name="courseService"></param>
        public ProjectController(IProjectService projectService, ICourseService courseService)
        {
            this.projectService = projectService;
            this.courseService = courseService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Project> GetAll()
        {
            return projectService.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<Project> GetById(int id)
        {
            var project = projectService.GetById(id);
            if (project == null)
            {
                return NotFound(new { message = "Projeto não encontrado !!!"});
            }
            return project;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        [HttpGet("course/{courseId}")]
        public ActionResult<List<Project>> GetByCourse(int courseId)
        {
            if (!courseService.CourseExists(courseId))
            {
                return NotFound(new { message = "Curso não encontrado !!!" });
            }
            else
            {
                return projectService.GetByCourse(courseId);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="project"></param>
        /// <returns></returns>
        [HttpPut]
        public bool Update(Project project)
        {
            return projectService.Update(project);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return projectService.Delete(id);
        }

        /// <summary> 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<Project> Create(Project project)
        {
            var projectCreate = projectService.Create(project);

            if(projectCreate == -1)
            {
                return BadRequest(new { message = "Valor ProjectStatus inválido."});
            }
            else
            {
                return CreatedAtAction("GetById", new { id = projectCreate });
            }            
        }
    }
}