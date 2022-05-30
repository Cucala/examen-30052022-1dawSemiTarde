namespace ArturoHerrera24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<String> preguntas = new List<string>();
        private List<String> respuestas = new List<string>();
        String player;
        int points;

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
        public String Player
        {
            get { return player; }
            set { player = value; }
        }

        public List<String> Preguntas 
        {
            get { return preguntas; }
            set { preguntas = value; }
        }
        public List<String> Respuestas
        {
            get { return respuestas; }
            set { respuestas = value; }
        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

                this.Hide();
                form.Show();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Player = txtJugador.Text;
            Points = 0;
            Jugar juego = new Jugar();
            juego.Show();
        }
    }
}