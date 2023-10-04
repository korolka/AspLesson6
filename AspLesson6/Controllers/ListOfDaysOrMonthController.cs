using AspLesson6.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspLesson6.Controllers
{
    public class ListOfDaysOrMonthController : Controller
    {
        IDayOrMonth dayOrMonth;
        public ListOfDaysOrMonthController(IDayOrMonth dayOrMonth)
        {
            this.dayOrMonth = dayOrMonth;
        }
        public IActionResult Index()
        {
            List<string> words= dayOrMonth.GetWords().ToList();
            return View(words);
        }
    }
}
