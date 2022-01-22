using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizExample.Data;
using QuizExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizExample.Controllers
{
    public class QuestionController : Controller
    {
        private QuizContext db;
        //localhost//Quiz
        public QuestionController(QuizContext _)
        {
            db = _;
        }
        // GET: QuestionController
        public IActionResult index(int id)
        {

            var temp = db.Option.Where((x) => x.QuestionID == id).ToList();
            var answer =   db.Answer.Where((x) => x.QuestionID == id).ToList().FirstOrDefault();
            ViewData["answer"] = answer?.OptionID ?? -1;
            ViewData["QuestionId"] = id;

            return View(temp);
        }
        public void Create(Question question)
        {
            db.Question.Add(question);
            db.SaveChanges();

        }
        public void CreateOption(Option option)
        {
            db.Option.Add(option);
            db.SaveChanges();

        }

    }
}
