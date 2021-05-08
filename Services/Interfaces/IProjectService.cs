using SS_API.Services.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SS_API.Services
{
    /// <summary>
    /// Interface com o métodos da camada de serviço para Project
    /// </summary>
    public interface IProjectService
    {
        /// <summary>
        /// Retorna todos os projetos
        /// </summary>
        /// <returns></returns>
        List<ProjectDto> GetAll();

        /// <summary>
        /// Busca o projeto pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ProjectDto GetById(int id);

        /// <summary>
        /// Retorna os projetos de determinado curso
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<ProjectDto> GetByCourse(int id);

        /// <summary>
        /// Atualiza o projeto
        /// </summary>
        /// <param name="projectDto"></param>
        /// <returns></returns>
        ResponseDto Update(ProjectDto projectDto);

        /// <summary>
        /// Exclui o projeto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ResponseDto Delete(int id);

        /// <summary>
        /// Cria um novo projeto
        /// </summary>
        /// <param name="projectDto"></param>
        /// <returns></returns>
        Task<ResponseDto> Create(ProjectDto projectDto);

        /// <summary>
        /// Verifica se o projeto existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool ProjectExists(int id);
    }
}
