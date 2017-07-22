using CliveKumara.Architeture.DataAccessLayer.Core.UnitOfWork;
using CliveKumara.Architeture.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CliveKumara.Architeture.DomainModel.Model;
using CliveKumara.Architeture.DataAccessLayer.Repository;
using CliveKumara.Architeture.DataAccessLayer.Core.Repository;
using CliveKumara.Architeture.DataAccessLayer;
using CliveKumara.Architeture.DataAccessLayer.DBContext;

namespace CliveKumara.Architeture.Service.Service
{
    public class CourseService  :ICourseService
    {
        
        private readonly IUnitOfWork _unitOfWork;

        private readonly ICourseRepository _courseRepository;


        public CourseService()
        {
            this._unitOfWork = new UnitOfWork();
            _courseRepository = _unitOfWork.Courses;
        }



        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAll();   
        }

        public Course GetCourseUsingId(int id)
        {
            return _courseRepository.Get(id);
        }
    }
}
