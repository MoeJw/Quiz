using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizExample.Models
{
    public class Answer
    {
        public int AnswerID { set; get; }

        public int OptionID { get; set; }
        public Option option { get; set; }
        public int QuestionID { get; set; }

    }
}
