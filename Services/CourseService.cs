using SS_API.Data;
using SS_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_API.Services
{
    public interface ICourseService
    {
        List<Course> GetAll();
        bool CourseExists(int id);
    }
    public class CourseService : ICourseService
    {
        private readonly StreamerContext db;

        public CourseService(StreamerContext context)
        {
            db = context;
        }
        public List<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        public bool CourseExists(int id)
        {
            return db.Courses.Any(p => p.Id == id);
        }
    }
}
