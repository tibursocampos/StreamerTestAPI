using SS_API.Services.Dto;
using System.Collections.Generic;

namespace SS_API.Services
{
    /// <summary>
    /// Interface com o métodos da camada de serviço para Course
    /// </summary>
    public interface ICourseService
    {
        /// <summary>
        /// Retorna todos os cursos
        /// </summary>
        /// <returns></returns>        
        List<CourseDto> GetAll();

        /// <summary>
        /// Busca o curso pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CourseDto GetById(int id);

        /// <summary>
        /// Verifica se curso buscado existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool CourseExists(int id);

    }
}
