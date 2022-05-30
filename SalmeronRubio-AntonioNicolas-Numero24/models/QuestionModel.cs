using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmeronRubio_AntonioNicolas_Numero24.models
{
    public class QuestionModel
    {
        private string question;
        private string[] answers;
        private int value;

        public QuestionModel(string question, string[] answers, int value)
        {
            this.Question = question;
            this.Answers = answers;
            this.Value = value;
        }

        public string Question { get => question; set => question = value; }
        public string[] Answers { get => answers; set => answers = value; }
        public int Value { get => value; set => this.value = value; }
    }
}
