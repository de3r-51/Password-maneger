using Gestor_de_Palavras_passe2.Controllers;
using Gestor_de_Palavras_passe2.Interfaces;
using Gestor_de_Palavras_passe2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Palavras_passe
{
    public partial class Login : Form
    {

        public Accounts conta {  get; set; }

        public Login( Accounts conta)
        {
            InitializeComponent();
            this.conta = conta;


        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Criar_conta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cd = new Cadastro(conta);
            cd.Show();
            this.Hide();
        }

        private void Entar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(" " + conta.repositorio_u.tam());

            string nome = Nome_login.Text;
            string senha = Senha_login.Text;
            VerificarUsuario(nome, senha);

        }

        private bool VerificarUsuario(string nome, string senha)
        {
            foreach(var usuario in conta.repositorio_u.GetAll())
            {
                if(usuario.Nome == nome && usuario.Senha == senha)
                {


                    conta.repositorio = usuario.Dados;

                    MessageBox.Show("true");
                    Dashboard log = new Dashboard(conta);
                    log.Show();
                    this.Hide();
                    return true;
                    
                }
            }

            MessageBox.Show("false");
            return false;
            
        }

      
    }
}
