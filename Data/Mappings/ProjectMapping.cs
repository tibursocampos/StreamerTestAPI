using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SS_API.Model;

namespace SS_API.Data.Mappings
{
    /// <summary>
    /// Mapeamento da entidade Project
    /// </summary>
    public class ProjectMapping : IEntityTypeConfiguration<Project>
    {
        /// <summary>
        /// Nome para tabela
        /// </summary>
        protected string TableName { get; } = nameof(Project);
        
        /// <summary>
        /// Dados do mapeamento
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable(TableName).HasKey(x => x.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
            builder.Property(c => c.CourseId).IsRequired();
        }
    }
}
