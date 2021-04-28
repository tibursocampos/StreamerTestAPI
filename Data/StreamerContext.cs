using Microsoft.EntityFrameworkCore;
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
        /// Gerar a tabela Courses no banco de dados
        /// </summary>
        public DbSet<Course> Courses { get; set; }
        /// <summary>
        /// Gerar a tabela Projects no banco de dados
        /// </summary>
        public DbSet<Project> Projects { get; set; }

        /// <summary>
        /// Utilização de FluentAPI para configuração das propriedades das tabelas
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasKey(k => k.Id);
            modelBuilder.Entity<Course>().Property(a => a.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Course>().HasMany(c => c.Projects).WithOne(p => p.Course).HasForeignKey(p => p.CourseId).IsRequired().OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Project>().HasKey(k => k.Id);
            modelBuilder.Entity<Project>().Property(a => a.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Project>().Property(n => n.Name).IsRequired();

        }
    }
}