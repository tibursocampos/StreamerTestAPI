using System.Collections.Generic;

namespace SS_API.Model
{
    /// <summary>
    /// Classe Course
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Id do curso
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do curso
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<Project> Projects { get; set; }
    }
}