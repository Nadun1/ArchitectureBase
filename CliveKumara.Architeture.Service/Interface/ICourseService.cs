using CliveKumara.Architeture.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliveKumara.Architeture.Service.Interface
{
    public interface ICourseService
    {

        IEnumerable<Course> GetAllCourses();
        Course GetCourseUsingId(int id);


    }
}
