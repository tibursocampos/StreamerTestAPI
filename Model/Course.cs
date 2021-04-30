using System.Collections.Generic;

namespace SS_API.Model
{
    /// <summary>
    /// Classe Course
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 
        /// </summary>
        public Course()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Course(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Course(string name)
        {
            Name = name;
        }
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