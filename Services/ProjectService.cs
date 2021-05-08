using Microsoft.EntityFrameworkCore;
using SS_API.Model;
using SS_API.Model.Enum;
using SS_API.Repositories;
using SS_API.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_API.Services
{
    /// <summary>
    /// Implementação dos métodos da interface IProjectService
    /// </summary>
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository repository;

        /// <summary>
        /// Construtor e injeção de dependência
        /// </summary>
        /// <param name="repository"></param>
        public ProjectService(IProjectRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Cria um novo projeto
        /// </summary>
        /// <param name="projectDto"></param>
        /// <returns></returns>
        public async Task<ResponseDto> Create(ProjectDto projectDto)
        {
            if (!Enum.IsDefined(typeof(ProjectStatusEnum), projectDto.ProjectStatus))
            {
                return new ResponseDto().BadRequest("Valor ProjectStatus inválido.");
            }
            var project = new Project(projectDto.Name, projectDto.Image, projectDto.Why, projectDto.What, projectDto.WhatWillWeDo, projectDto.ProjectStatus, projectDto.CourseId);

            await repository.Create(project);
            
            return new ResponseDto().Created(project.Id);
        }

        /// <summary>
        /// Atualiza o projeto
        /// </summary>
        /// <param name="projectDto"></param>
        /// <returns></returns>
        public ResponseDto Update(ProjectDto projectDto)
        {
            if (!Enum.IsDefined(typeof(ProjectStatusEnum), projectDto.ProjectStatus))
            {
                return new ResponseDto().BadRequest("Valor ProjectStatus inválido.");
            }
            var project = repository.Get().FirstOrDefault(x => x.Id == projectDto.Id);
            if (project == null)
            {
                return new ResponseDto().NotFound("Projeto não encontrado");
            }

            project.Update(projectDto);
            repository.Update(project);

            return new ResponseDto().Executed();
        }


        /// <summary>
        /// Exclui o projeto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ResponseDto Delete(int id)
        {
            var exist = ProjectExists(id);
            if (!exist)
            {
                return new ResponseDto().NotFound("Projeto não encontrado");
            }
            else
            {
                repository.Delete(id);

                return new ResponseDto().Executed();
            }
        }

        /// <summary>
        /// Retorna todos os projetos
        /// </summary>
        /// <returns></returns>
        public List<ProjectDto> GetAll()
        {
            List<ProjectDto> projectList = new List<ProjectDto>();
            var projects = repository.Get().Include(c => c.Course).OrderBy(p => p.Course.Name).ToList();

            foreach(var project in projects)
            {
                projectList.Add(new ProjectDto(project));
            }

            return projectList;
        }

        /// <summary>
        /// Retorna os projetos de determinado curso
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ProjectDto> GetByCourse(int id)
        {
            List<ProjectDto> projectList = new List<ProjectDto>();
            var projects = repository.Get().Include(c => c.Course).Where(p => p.CourseId == id).ToList();

            foreach (var project in projects)
            {
                projectList.Add(new ProjectDto(project));
            }

            return projectList;
        }

        /// <summary>
        /// Busca o projeto pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProjectDto GetById(int id)
        {
            var project = repository.Get().Include(c => c.Course).FirstOrDefault(x => x.Id == id);
            if(project == null)
            {
                return null;
            }
            return new ProjectDto(project);
        }

        /// <summary>
        /// Verifica se o projeto existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool ProjectExists(int id)
        {
            return repository.Get().Any(p => p.Id == id);
        }
        
    }
}
