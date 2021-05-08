using SS_API.Model;

namespace SS_API.Services.Dto
{
    /// <summary>
    /// DTO para mapear informações da camada model
    /// </summary>
    public class CourseDto
    {
        /// <summary>
        /// 
        /// </summary>
        public CourseDto(Course course)
        {
            Id = course.Id;
            Name = course.Name;

        }

        /// <summary>
        /// Id do curso
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do curso
        /// </summary>
        public string Name { get; set; }
    }
}
