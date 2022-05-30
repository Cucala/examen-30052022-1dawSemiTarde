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
    public partial class Form3 : Form
    {
        private QuestionModel model;
        public Form3(QuestionModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblPregunta.Text = model.Question.ToString();
            string[] resps = model.Answers.ToArray();
            comboBoxRespuestas.Items.Add(resps[0]);
            comboBoxRespuestas.Items.Add(resps[1]);
            comboBoxRespuestas.Items.Add(resps[2]);
        }

        private void btnNiIdea_Click(object sender, EventArgs e)
        {

        }

        private void btnSeguro_Click(object sender, EventArgs e)
        {

        }

        public int save()
        {
            int point = 0;

            return point;
        }

        public void cancel()
        {

        }
    }
}
