using Microsoft.AspNetCore.Mvc;
using QuizExample.Data;
using QuizExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizExample.Controllers
{
    public class QuizController : Controller
    {
        private QuizContext db;
        //localhost//Quiz
        public QuizController (QuizContext _)
        {
            db = _;
        }
        public IActionResult Index()
        {
           
            
            return View(db.Quiz.ToList());
        }
        [HttpPost]
        public IActionResult Create(Quiz quiz)
        {
            db.Quiz.Add(quiz);
            db.SaveChanges();
            return View("index",db.Quiz.ToList());
        }
        [HttpGet]
        public IActionResult GetAllQuizQuestions(int id)
        {
           var selectedQuiz =  db.Quiz.Where((quiz) => quiz.QuizId == id).ToList().FirstOrDefault();
            var Questions = db.Question.Where((question) => question.QuizID == selectedQuiz.QuizId).ToList();
            ViewData["QuizName"] = selectedQuiz.name;
            ViewData["QuizId"] = selectedQuiz.QuizId;
            return View("QuizData",Questions);
        }
    }
}
