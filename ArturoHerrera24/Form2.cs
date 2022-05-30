using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArturoHerrera24
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 form = new Form1();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            form.Show(); 
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            form.Preguntas.Add(txtPregunta.Text);
            form.Respuestas.Add(txtRespuestaA.Text);
            form.Respuestas.Add(txtRespuestaB.Text);
            form.Respuestas.Add(txtRespuestaC.Text);
        }
    }
}
