using Gestor_de_Palavras_passe2.Models;

namespace Gestor_de_Palavras_passe
{
    public partial class Form1 : Form
    {
       public Accounts conta = new Accounts();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (materialProgressBar1.Value < 100)
            {
                materialProgressBar1.Value += 1;
            }
            else
            {
                this.Hide();
                timer1.Stop();
                Cadastro login = new Cadastro(conta);
                login.Show();

            }

        }

        private void materialProgressBar1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
