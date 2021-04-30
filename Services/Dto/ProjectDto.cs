using SS_API.Model;
using SS_API.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_API.Services.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class ProjectDto
    {
        /// <summary>
        /// 
        /// </summary>
        public ProjectDto()
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
        /// <param name="courseId"></param>
        public ProjectDto(int id, string name, string image, string why, string what, string whatWillWeDo, ProjectStatusEnum projectStatus, int courseId) 
        {
            Id = id;
            Name = name;
            Image = image;
            Why = why;
            What = what;
            WhatWillWeDo = whatWillWeDo;
            ProjectStatus = projectStatus;
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
        /// <param name="courseId"></param>
        public ProjectDto(string name, string image, string why, string what, string whatWillWeDo, ProjectStatusEnum projectStatus, int courseId)
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
        /// Status
        /// </summary>
        public ProjectStatusEnum? ProjectStatus { get; set; }
        /// <summary>
        /// Foreign Key para o Curso
        /// </summary>
        public int CourseId { get; set; }
    }
}
