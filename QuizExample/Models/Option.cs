using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizExample.Models
{
    public class Option
    {
        public int OptionID { set; get; }
        public string Title { set; get; }
        public int QuestionID { set; get; }
        public Question Question { set; get; }
    }
}
