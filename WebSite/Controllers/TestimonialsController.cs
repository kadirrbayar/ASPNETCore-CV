﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TestimonialsController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = testimonialManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult TestimonialAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TestimonialAdd(Testimonial testimonial)
        {
            testimonialManager.TAdd(testimonial);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult TestimonialEdit(int id)
        {
            var find = testimonialManager.get(id);
            return View(find);
        }

        [HttpPost]
        public IActionResult TestimonialEdit(Testimonial testimonial)
        {
            testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }

        public IActionResult TestimonialDelete(int id)
        {
            var values = testimonialManager.get(id);
            testimonialManager.TDelete(values);
            return RedirectToAction("Index");
        }

    }
}
