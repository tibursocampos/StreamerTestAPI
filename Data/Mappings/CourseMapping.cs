using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SS_API.Model;

namespace SS_API.Data.Mappings
{
    /// <summary>
    /// Mapeamento da entidade Course
    /// </summary>
    public class CourseMapping : IEntityTypeConfiguration<Course>
    {
        /// <summary>
        /// Nome para tabela
        /// </summary>
        protected string TableName { get; } = nameof(Course);

        /// <summary>
        /// Dados do mapeamento
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable(TableName).HasKey(x => x.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.HasMany(c => c.Projects).WithOne(p => p.Course).HasForeignKey(p => p.CourseId).IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.HasData(new Course(1, "Angular"));
            builder.HasData(new Course(2, "React"));
            builder.HasData(new Course(3, "DotNet"));
            builder.HasData(new Course(4, "Java"));
        }
    }
}
