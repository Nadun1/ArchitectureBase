using CliveKumara.Architeture.Service.Interface;
using CliveKumara.Architeture.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CliveKumara.Architeture.Web.Controllers
{
    public class CourseController : Controller
    {

        private ICourseService courseService;

        public CourseController(ICourseService courseService )
        {
            this.courseService = courseService;
        }


        // GET: Course
        public ActionResult Index()
        {

            var allCourses = courseService.GetAllCourses();

            return View(allCourses);
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            var c = courseService.GetCourseUsingId(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
