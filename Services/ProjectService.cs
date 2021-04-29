using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SS_API.Data;
using SS_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        /// <returns></returns>
        List<Project> GetAll();
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool ProjectExists(int id);
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
            if(project.ProjectStatus.HasValue)
            {
                var value = Convert.ToInt32(project.ProjectStatus);
                if(value > 1 || value < 0)
                {
                    return -1;
                }
            }

            db.Projects.Add(project);
            db.SaveChanges();
            return project.Id;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            var exist = ProjectExists(id);
            if (!exist)
            {
                return exist;
            }
            else
            {
                var project = db.Projects.Find(id);
                db.Projects.Remove(project);

                return exist;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Project> GetAll()
        {
            return db.Projects.OrderBy(p => p.Name).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Project> GetByCourse(int id)
        {
            return db.Projects.Where(p => p.CourseId == id).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Project GetById(int id)
        {
            var project = db.Projects.Find(id);
            return project;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public bool Update(Project project)
        {
            //var projectId = db.Projects.Find(project.Id);
            //if (projectId is null)
            //{
            //    return false;
            //}

            try
            {
                db.Entry(project).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectExists(project.Id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool ProjectExists(int id)
        {
            return db.Projects.Any(p => p.Id == id);
        }
    }
}
