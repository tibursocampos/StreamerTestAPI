using Microsoft.EntityFrameworkCore;
using SS_API.Data;
using SS_API.Model;
using System.Linq;
using System.Threading.Tasks;

namespace SS_API.Repositories
{
    /// <summary>
    /// Classe de repositório que tem acesso ao contexto
    /// </summary>
    public class ProjectRepository : IProjectRepository
    {
        private readonly StreamerContext context;

        /// <summary>
        /// Construtor com a injeção de dependência
        /// </summary>
        /// <param name="context"></param>
        public ProjectRepository(StreamerContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Implementação da interface que cria um projeto
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async Task Create(Project project)
        {
            await context.Projects.AddAsync(project);
            await context.SaveChangesAsync();

        }

        /// <summary>
        /// Implementação da interface que exclui um projeto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(int id)
        {
            var project = Get().First(x => x.Id == id);
            context.Projects.Remove(project);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Implementação da interface que retorna os projetos
        /// </summary>
        /// <returns></returns>
        public IQueryable<Project> Get()
        {
            return context.Set<Project>();            
        }

        /// <summary>
        /// Implementação da interface que atualiza um projeto
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async Task Update(Project project)
        {
            
            context.Entry(project).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
