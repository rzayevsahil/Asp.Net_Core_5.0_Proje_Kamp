using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager _writerManager = new WriterManager(new EfWriterRepository());
        IWriterService _writerService;
        public RegisterController(IWriterService writerService)
        {
            _writerService = writerService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            return View();
        }
    }
}
