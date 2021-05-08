using Microsoft.AspNetCore.Mvc;
using SS_API.Services;
using SS_API.Services.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SS_API.Controllers
{
    /// <summary>
    /// Classes para expor os recursos para os usuários finais através de requisições Http.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectService projectService;
        private ICourseService courseService;

        /// <summary>
        /// Construtor e injeção de dependência
        /// </summary>
        /// <param name="projectService"></param>
        /// <param name="courseService"></param>
        public ProjectController(IProjectService projectService, ICourseService courseService)
        {
            this.projectService = projectService;
            this.courseService = courseService;
        }

        /// <summary>
        /// Retorna todos os projetos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ProjectDto>> GetAll()
        {
            var project = projectService.GetAll();
            return project;

        }

        /// <summary>
        /// Busca o projeto pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<ProjectDto> GetById(int id)
        {
            var project = projectService.GetById(id);
            if (project == null)
            {
                return NotFound(new { message = "Projeto não encontrado !!!" });
            }
            return project;
        }

        /// <summary>
        /// Busca todos projetos pelo ID do curso
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        [HttpGet("course/{courseId}")]
        public ActionResult<List<ProjectDto>> GetByCourse(int courseId)
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
        /// Atualiza o projeto
        /// </summary>
        /// <param name="projectDto"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<bool> Update(ProjectDto projectDto)
        {
            var response = projectService.Update(projectDto);

            if (!response.Success)
            {
                return NotFound(new { message = response.ErrorMessage });
            }

            return response.Success;
        }

        /// <summary>
        /// Apaga o projeto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            var response = projectService.Delete(id);

            if (!response.Success)
            {
                return BadRequest(new { message = response.ErrorMessage });
            }

            return response.Success;
        }

        /// <summary>
        /// Cria um novo projeto
        /// </summary>
        /// <param name="projectDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Create(ProjectDto projectDto)
        {
            var projectCreate = await projectService.Create(projectDto);

            if(!projectCreate.Success)
            {
                return BadRequest(new { message = projectCreate.ErrorMessage});
            }
            else
            {
                return CreatedAtAction("Created", new { id = projectCreate.ProjectId });
            }            
        }
    }
}