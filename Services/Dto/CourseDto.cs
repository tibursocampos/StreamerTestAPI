using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_API.Services.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class CourseDto
    {
        /// <summary>
        /// 
        /// </summary>
        public CourseDto()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public CourseDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public CourseDto(string name)
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
    }
}
