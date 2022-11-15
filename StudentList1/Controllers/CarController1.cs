using Microsoft.AspNetCore.Mvc;
using StudentList1.Models;

namespace SecondMVCApp.Controllers
{
    public class CarController : Controller
    {

        public static List<Car> Cars=new List<Car>();

        


        public IActionResult Index()
        {
            return View(Cars);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Car car = new Car();
            return View(car);
        }

        [HttpPost]
        public IActionResult Create(Car car)
        {

            Cars.Add(car);

            return RedirectToAction("Index");

        }



        public IActionResult Delete(int SrNo)
        {

            var car = Cars.FirstOrDefault(car => car.SrNo == SrNo);


            Cars.Remove(car);


            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Car car)
        {
            return View();
        }





    }
}
