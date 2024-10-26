using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarsController : Controller
    {
        // Esta lista simula um banco de dados
        private static List<Car> cars = new List<Car>();

        // GET: Cars
        public IActionResult Index()
        {
            return View(cars);
        }

        // GET: Cars/Details/5
        public IActionResult Details(int id)
        {
            var car = cars.Find(c => c.Id == id);
            return View(car);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        [HttpPost]
        public IActionResult Create(Car car)
        {
            car.Id = cars.Count + 1; // Definir um ID simples
            cars.Add(car);
            return RedirectToAction("Index");
        }
    }
}
