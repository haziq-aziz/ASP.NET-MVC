using Microsoft.AspNetCore.Mvc;
using MVC1387.Models;

namespace MVC1387.Controllers
{
    public class LearnController : Controller
    {
        public IActionResult Index()
        {
            string country = "Malaysia";
            ViewBag.Country = country;
            ViewBag.University = "UniKL";
            return View();
        }

        [HttpGet]
        public IActionResult BodyMassIndex1 ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BodyMassIndex1 (Person user)
        {
            double bmi;
            string bmiStatus;

            ViewBag.Name = user.Name;
            ViewBag.Weight = user.Weight;
            ViewBag.Height = user.Height;

            // Calculate BMI
            bmi = ViewBag.Weight / Math.Pow(ViewBag.Height, 2);

            // Calculate BMI Status
            if (bmi < 18.5)
            {
                bmiStatus = "Underwright";
            }
            
            else if (bmi < 25)
            {
                bmiStatus = "Good";
            }

            else if (bmi < 29)
            {
                bmiStatus = "Overweight";
            }

            else
            {
                bmiStatus = "Obese";
            }

            ViewBag.Bmi = bmi;
            ViewBag.BmiStatus = bmiStatus;

            return View("BodyMassIndex1Result");
        }

        [HttpGet]
        public IActionResult BodyMassIndex2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BodyMassIndex2(Person user)
        {
            return View("BodyMassIndex2Result", user);
        }
    }
}
