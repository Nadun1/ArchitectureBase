using CliveKumara.Architeture.DataAccessLayer.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliveKumara.Architeture.DataAccessLayer.Core.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IAuthorRepository Authors { get; }
        int Complete();
    }
}
