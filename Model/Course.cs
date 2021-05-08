using System.Collections.Generic;

namespace SS_API.Model
{
    /// <summary>
    /// Classe Course
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Construtor para uso do EF Core
        /// </summary>
        protected Course()
        {

        }

        /// <summary>
        /// Construtor para instância de novo objeto
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Course(int id, string name)
        {
            Id = id;
            Name = name;
        }

     
        /// <summary>
        /// Id do curso
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Nome do curso
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Coleção de objetos Project
        /// </summary>
        public ICollection<Project> Projects { get; set; }
    }
}