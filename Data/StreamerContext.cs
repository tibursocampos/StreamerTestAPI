using Microsoft.EntityFrameworkCore;
using SS_API.Data.Mappings;
using SS_API.Model;

namespace SS_API.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class StreamerContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        public StreamerContext(DbContextOptions<StreamerContext> option) : base(option) {}

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Course> Courses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Project> Projects { get; set; }

        /// <summary>
        /// Mapeamento para configuração das propriedades das tabelas
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseMapping());
            modelBuilder.ApplyConfiguration(new ProjectMapping());
        }
    }
}