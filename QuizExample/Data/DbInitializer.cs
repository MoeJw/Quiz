using QuizExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizExample.Data
{
    public static class DbInitializer
    {
        public static void Initialize(QuizContext context)
        {
            context.Database.EnsureCreated();

            
            //// Look for any students.
            //if (context.Quiz.Any())
            //{
            //    return;   // DB has been seeded
            //}

            //var quiz = new Quiz() { name = "English" };

            // context.Quiz.Add(quiz);
            //Question question = new Question() { Quiz = quiz, Title = "what is your name" };
            //context.Question.Add(question);
            //context.SaveChanges();
            // Look for any students.
        }
    }
}
