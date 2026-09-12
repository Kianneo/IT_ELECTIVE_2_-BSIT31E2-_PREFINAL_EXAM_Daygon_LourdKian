using Microsoft.AspNetCore.Mvc;
using ExamApp.Data;
using ExamApp.Models;

namespace PrefinalExam.Controllers
{
    public class HomeController : Controller
    {
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