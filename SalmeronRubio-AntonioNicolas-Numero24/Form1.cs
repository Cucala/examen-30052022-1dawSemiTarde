using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalmeronRubio_AntonioNicolas_Numero24.models;

namespace SalmeronRubio_AntonioNicolas_Numero24
{
    public partial class Form1 : Form
    {
        private List<QuestionModel> questions;
        private string player;
        private int points;

        public List<QuestionModel> Questions { get => questions; set => questions = value; }
        public string Player { get => player; set => player = value; }
        public int Points { get => points; set => points = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevasPreguntas_Click(object sender, EventArgs e)
        {
            addQuestion();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (Questions.Count == 0)
            {
                addQuestion();
            }
            else
            {
                Random random = new Random();
                int num = random.Next(Questions.Count -1);
                QuestionModel model = Questions[num];
                play(model);
            }
        }

        public void play(QuestionModel model)
        {
            Form3 form = new Form3();
        }

        public void addQuestion()
        {
            var newForm2 = new Form2(Questions);
            newForm2.Show();
        }
    }
}
