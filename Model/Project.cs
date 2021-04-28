using SS_API.Model.Enum;

namespace SS_API.Model
{
    /// <summary>
    /// Classe Project
    /// </summary>
    public class Project
    {
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
        /// Referência para qual Curso o projeto faz parte
        /// </summary>
        public virtual Course Course { get; set; }
        /// <summary>
        /// Foreign Key para o Curso
        /// </summary>
        public int CourseId { get; set; }
    }
}
