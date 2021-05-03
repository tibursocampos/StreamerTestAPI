using Microsoft.EntityFrameworkCore;
using SS_API.Data;
using SS_API.Model;
using System.Linq;
using System.Threading.Tasks;

namespace SS_API.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly StreamerContext context;

        public ProjectRepository(StreamerContext context)
        {
            this.context = context;
        }

        public async Task Create(Project project)
        {
            await context.Projects.AddAsync(project);
            await context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            var project = Get().First(x => x.Id == id);
            context.Projects.Remove(project);
            await context.SaveChangesAsync();
        }

        public IQueryable<Project> Get()
        {
            return context.Set<Project>();            
        }

        public async Task Update(Project project)
        {
            
            context.Entry(project).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
