using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizExample.Models
{
    public class Question
    {
        public int QuestionID { set; get; }
        public string Title { set; get;  }
        public int QuizID { get; set; }
        public Quiz Quiz { set; get; }



    }
}
