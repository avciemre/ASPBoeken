using ASPBoeken.Models;
using ASPBoeken.Database;
using Microsoft.AspNetCore.Mvc;
using ASPBoeken.Domein;

namespace ASPBoeken.Controllers
{
    public class BoekenController : Controller
    {
        private IBoekenDb boekenDb;

        public BoekenController(IBoekenDb boekenDb)
        {
            this.boekenDb = boekenDb;
        }
        public IActionResult Index()
        {
            var vm = boekenDb.GetBoeks().Select(x => new BoekenListViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Author = x.Author,
                Description = x.Description,
                Genre = x.Genre,
                PublishDate = x.PublishDate
            });
            return View(vm);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([FromForm] BoekCreateViewModel vm) //MODELS
        {
            if (TryValidateModel(vm))
            {
                var boek = new Boek()
                {
                    Title = vm.Title,
                    Author = vm.Author,
                    Description = vm.Description,
                    PublishDate = vm.PublishDate,
                    Rating = vm.Rating,
                };
                boekenDb.Insert(boek);
                return RedirectToAction(nameof(Index));

            }
            return View();
        }
    }
}
