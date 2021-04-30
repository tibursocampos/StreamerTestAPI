using SS_API.Model.Enum;

namespace SS_API.Model
{
    /// <summary>
    /// Classe Project
    /// </summary>
    public class Project
    {
        /// <summary>
        /// 
        /// </summary>
        public Project()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="image"></param>
        /// <param name="why"></param>
        /// <param name="what"></param>
        /// <param name="whatWillWeDo"></param>
        /// <param name="projectStatus"></param>
        /// <param name="course"></param>
        /// <param name="courseId"></param>
        public Project(int id, string name, string image, string why, string what, string whatWillWeDo, ProjectStatusEnum projectStatus, Course course, int courseId)
        {
            Id = id;
            Name = name;
            Image = image;
            Why = why;
            What = what;
            WhatWillWeDo = whatWillWeDo;
            ProjectStatus = projectStatus;
            Course = course;
            CourseId = courseId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="image"></param>
        /// <param name="why"></param>
        /// <param name="what"></param>
        /// <param name="whatWillWeDo"></param>
        /// <param name="projectStatus"></param>
        /// <param name="course"></param>
        /// <param name="courseId"></param>
        public Project(string name, string image, string why, string what, string whatWillWeDo, ProjectStatusEnum projectStatus, Course course, int courseId)
        {
            Name = name;
            Image = image;
            Why = why;
            What = what;
            WhatWillWeDo = whatWillWeDo;
            ProjectStatus = projectStatus;
            Course = course;
            CourseId = courseId;
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
        public string Image { get; set; } = null;
        /// <summary>
        /// Campos para descrição do projeto
        /// </summary>
        public string Why { get; set; } = null;
        /// <summary>
        /// Campos para descrição do projeto
        /// </summary>
        public string What { get; set; } = null;
        /// <summary>
        /// Campos para descrição do projeto
        /// </summary>
        public string WhatWillWeDo { get; set; } = null;
        /// <summary>
        /// Status do projeto
        /// </summary>
        public ProjectStatusEnum? ProjectStatus { get; set; }
        /// <summary>
        /// Referência para qual Curso o projeto faz parte
        /// </summary>
        public Course Course { get; set; }
        /// <summary>
        /// Foreign Key para o Curso
        /// </summary>
        public int CourseId { get; set; }
    }
}
