using SS_API.Model.Enum;
using SS_API.Services.Dto;

namespace SS_API.Model
{
    /// <summary>
    /// Classe Project
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Construtor para uso do EF Core
        /// </summary>
        protected Project()
        {

        }

        /// <summary>
        /// /// Construtor para instância de novo objeto
        /// </summary>
        /// <param name="name"></param>
        /// <param name="image"></param>
        /// <param name="why"></param>
        /// <param name="what"></param>
        /// <param name="whatWillWeDo"></param>
        /// <param name="projectStatus"></param>
        /// <param name="courseId"></param>
        public Project(string name, string image, string why, string what, string whatWillWeDo, ProjectStatusEnum? projectStatus, int courseId)
        {
            Name = name;
            Image = image;
            Why = why;
            What = what;
            WhatWillWeDo = whatWillWeDo;
            ProjectStatus = projectStatus;
            CourseId = courseId;
        }

        /// <summary>
        /// Id do projeto
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Nome do projeto
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Caminho da imagem no banco
        /// </summary>
        public string Image { get; private set; }
        /// <summary>
        /// Campos para descrição do projeto
        /// </summary>
        public string Why { get; private set; }
        /// <summary>
        /// Campos para descrição do projeto
        /// </summary>
        public string What { get; private set; }
        /// <summary>
        /// Campos para descrição do projeto
        /// </summary>
        public string WhatWillWeDo { get; private set; }
        /// <summary>
        /// Status do projeto
        /// </summary>
        public ProjectStatusEnum? ProjectStatus { get; private set; }
        /// <summary>
        /// Referência para qual Curso o projeto faz parte
        /// </summary>
        public Course Course { get; private set; }
        /// <summary>
        /// Foreign Key para o Curso
        /// </summary>
        public int CourseId { get; private set; }

        internal void Update(ProjectDto projectDto)
        {
            Name = projectDto.Name;
            Image = projectDto.Image;
            Why = projectDto.Why;
            What = projectDto.What;
            WhatWillWeDo = projectDto.WhatWillWeDo;
            ProjectStatus = projectDto.ProjectStatus;
            CourseId = projectDto.CourseId;
        }
    }
}
