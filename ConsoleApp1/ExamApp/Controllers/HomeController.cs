using Microsoft.AspNetCore.Mvc;
using PrefinalExam.Data;
using PrefinalExam.Models;

namespace PrefinalExam.Controllers
{
    public class HomeController : Controller
    {}
        public IActionResult Index()
        {
            List<QuestionAnswer> questions = ExamData.Questions;
            return View(questions);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}