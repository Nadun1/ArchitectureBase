using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CliveKumara.Architeture.DomainModel.Model;

                                                   
namespace CliveKumara.Architeture.DataAccessLayer.DBContext
{
    public class CourseAuthorDbContext : DbContext
    {
        public CourseAuthorDbContext()
            : base("name=CourseAuthorDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new CourseConfiguration());
        }

        //Enable-Migrations -ProjectName CliveKumara.Architeture.DAtaAccessLayer -StartupProjectName CliveKumara.Architeture.Web -ContextTypeName CourseAuthorDbContext


    }
}
