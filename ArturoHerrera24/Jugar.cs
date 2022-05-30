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
    public partial class Jugar : Form
    {
        Form1 form = new Form1();
        int index = 1;
        public Jugar()
        {
            InitializeComponent();
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(comboPreguntas.Text == form.Respuestas[0])
            {
                form.Points = form.Points + 5;
            }
        }

        private void btnNoSe_Click(object sender, EventArgs e)
        {
            form.Points = form.Points - 2;
            this.Close();
        }
    }
}
