using CliveKumara.Architeture.DataAccessLayer.Core.Repository;
using CliveKumara.Architeture.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CliveKumara.Architeture.DataAccessLayer.DBContext;

namespace CliveKumara.Architeture.DataAccessLayer.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {

        private readonly CourseAuthorDbContext _context;

        public CourseRepository(CourseAuthorDbContext context) : base(context)
        {
            this._context = context;
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return _context.Courses.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        {
            return _context.Courses
                .Include(c => c.Author)
                .OrderBy(c => c.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        

    }
}
