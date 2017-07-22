using CliveKumara.Architeture.DataAccessLayer.Core.Repository;
using CliveKumara.Architeture.DataAccessLayer.Core.UnitOfWork;
using CliveKumara.Architeture.DataAccessLayer.DBContext;
using CliveKumara.Architeture.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliveKumara.Architeture.DataAccessLayer
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly CourseAuthorDbContext _context;

        public UnitOfWork()
        {
            _context = new CourseAuthorDbContext();
            Courses = new CourseRepository(_context);
            Authors = new AuthorRepository(_context);
        }

        public ICourseRepository Courses { get; private set; }
        public IAuthorRepository Authors { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            
        }
    }
}
