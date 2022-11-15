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



        public IActionResult Delete(int Id)
        {

            var car = Cars.FirstOrDefault(car => car.ID == Id);


            Cars.Remove(car);


            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            Car car = Cars.FirstOrDefault(car => car.ID == id);
            return View(car);
        }

        [HttpPost]
        public IActionResult Update(Car car)
        {
            Car carUpdated = Cars.FirstOrDefault(car => car.ID == car.ID);
            carUpdated.ID=car.ID;
            carUpdated.OwnerName = car.OwnerName;
            carUpdated.CarName = car.CarName;
            carUpdated.CarModelYear = car.CarModelYear;
            carUpdated.FuelType = car.FuelType;
            carUpdated.CarInsuranceYear = car.CarInsuranceYear;
            return RedirectToAction("Index");

        }


    }
}
