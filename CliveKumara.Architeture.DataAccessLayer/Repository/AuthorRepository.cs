using CliveKumara.Architeture.DataAccessLayer.Core.Repository;
using CliveKumara.Architeture.DataAccessLayer.DBContext;
using CliveKumara.Architeture.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliveKumara.Architeture.DataAccessLayer.Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly CourseAuthorDbContext _context;
        public AuthorRepository(CourseAuthorDbContext context) : base(context)
        {
            this._context = context;
        }

        public Author GetAuthorWithCourses(int id)
        {
            return _context.Authors. SingleOrDefault(a => a.Id == id);
        }

      
    }
}
