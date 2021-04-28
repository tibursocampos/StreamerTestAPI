using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SS_API.Model;
using SS_API.Services;
using System.Collections.Generic;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectService"></param>
        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Task<List<Project>> GetAll()
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
                return NotFound();
            }
            return project;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        [HttpGet("courses/{courseId}")]
        public List<Project> GetByCourse(int courseId)
        {
            return projectService.GetByCourse(courseId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="project"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public bool Update(int id, Project project)
        {
            if (id != project.Id)
            {
                return false;
            }

            try
            {
                projectService.Update(project);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!projectService.ProjectExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }

            return true;
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
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<Project> Create(Project project)
        {
            var projectCreate = projectService.Create(project);
            return CreatedAtAction("GetById",new { id = projectCreate });
        }
    }
}