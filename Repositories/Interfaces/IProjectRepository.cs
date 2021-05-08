using SS_API.Model;
using System.Linq;
using System.Threading.Tasks;

namespace SS_API.Repositories
{
    /// <summary>
    /// Interface para ProjectRepository
    /// </summary>
    public interface IProjectRepository
    {
        /// <summary>
        /// Cria um novo projeto
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        Task Create(Project project);

        /// <summary>
        /// Retorna todos os projetos
        /// </summary>
        /// <returns></returns>
        IQueryable<Project> Get();

        /// <summary>
        /// Excluir um projeto informado o ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Delete(int id);

        /// <summary>
        /// Atualizar um projeto informando uma objeto
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        Task Update(Project project);
    }
}