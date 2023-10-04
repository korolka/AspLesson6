using AspLesson6.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspLesson6.Controllers
{
    public class HomeController : Controller
    {
        public ICalcServices calcServices;
        public HomeController(ICalcServices calcServices)
        {
            this.calcServices = calcServices;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Calc(double x, double y, string operation)
        {
            double res = 0;
            switch (operation)
            {
                case "+":
                    {
                        res = calcServices.Add(x, y);
                        break;
                    }

                case "-":
                    {
                        res = calcServices.Sub(x, y);
                        break;
                    }

                case "/":
                    {
                        res = calcServices.Div(x, y);
                        break;
                    }

                case "*":
                    {
                        res = calcServices.Mul(x, y);
                        break;
                    }
                default: { break; }
            }
            return View("Index", res);

        }
    }
}
