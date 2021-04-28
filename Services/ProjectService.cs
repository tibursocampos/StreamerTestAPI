using SS_API.Data;
using SS_API.Model;
using System;
using System.Collections.Generic;

namespace SS_API.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProjectService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Project GetById(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Project> GetByCourse(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        bool Update(Project project);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        int Create(Project project);
    }
    /// <summary>
    /// 
    /// </summary>
    public class ProjectService : IProjectService
    {
        private readonly StreamerContext db;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ProjectService(StreamerContext context)
        {
            db = context;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public int Create(Project project)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Project> GetByCourse(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Project GetById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public bool Update(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
