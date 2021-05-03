using SS_API.Model;
using SS_API.Model.Enum;

namespace SS_API.Services.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class ProjectDto
    {
        public ProjectDto()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public ProjectDto(Project project)
        {
            if (project == null) return;
            Id = project.Id;
            Name = project.Name;
            Image = project.Image;
            Why = project.Why;
            What = project.What;
            WhatWillWeDo = project.WhatWillWeDo;
            ProjectStatus = project.ProjectStatus;
            CourseId = project.CourseId;
            Course = new CourseDto(project.Course);
        }

        /// <summary>
        /// Id do projeto
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do projeto
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Caminho da imagem no banco
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// Campos para descrição do projeto
        /// </summary>
        public string Why { get; set; }
        /// <summary>
        /// Campos para descrição do projeto
        /// </summary>
        public string What { get; set; }
        /// <summary>
        /// Campos para descrição do projeto
        /// </summary>
        public string WhatWillWeDo { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public ProjectStatusEnum? ProjectStatus { get; set; }
        /// <summary>
        /// Foreign Key para o Curso
        /// </summary>        
        public int CourseId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CourseDto Course { get; set; }
    }
}
