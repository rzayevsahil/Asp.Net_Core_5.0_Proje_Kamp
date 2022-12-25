using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UILayer.Controllers
{
    public class RegisterController : Controller
    {
        IWriterService _writerService;
        ICityService _cityService;
        public RegisterController(IWriterService writerService, ICityService cityService)
        {
            _writerService = writerService;
            _cityService = cityService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<SelectListItem> cities = (from x in _cityService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CityName,
                                               Value = x.CityID.ToString()
                                           }).ToList();
            ViewBag.cities = cities;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult results = writerValidator.Validate(writer);
            List<SelectListItem> cities = (from x in _cityService.TGetList()
                select new SelectListItem
                {
                    Text = x.CityName,
                    Value = x.CityID.ToString()
                }).ToList();
            ViewBag.cities = cities;
            if (results.IsValid)
            {
                writer.WriterStatus = true;
                _writerService.TInsert(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item
                        .PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
