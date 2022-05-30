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
    public partial class Form2 : Form
    {
        private List<QuestionModel> model;
        public Form2(List<QuestionModel> model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            model.Add(save());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancel();
        }

        public QuestionModel save()
        {
            string pregunta = textBoxPregunta.Text;
            string[] respuestas = new string[3];
            respuestas[0] = textBoxRespuestaA.Text;
            respuestas[1] = textBoxRespuestaB.Text;
            respuestas[2] = textBoxRespuestaC.Text;
            int valor = Convert.ToInt32(textBoxValorPregunta.Text);
            QuestionModel newQuestion = new QuestionModel(pregunta, respuestas, valor);
            return newQuestion;
        }

        public void cancel()
        {
            this.Close();
        }
    }
}
