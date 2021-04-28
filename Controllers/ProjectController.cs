using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SS_API.Services;

namespace SS_API.Controllers
{
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
    }
}