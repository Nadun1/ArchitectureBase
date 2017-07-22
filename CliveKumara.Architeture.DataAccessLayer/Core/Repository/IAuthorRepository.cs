using CliveKumara.Architeture.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliveKumara.Architeture.DataAccessLayer.Core.Repository
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}
