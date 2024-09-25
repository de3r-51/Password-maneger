using Gestor_de_Palavras_passe2.Controllers;
using Gestor_de_Palavras_passe2.Interfaces;
using Gestor_de_Palavras_passe2.Models;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Palavras_passe
{
    public partial class Cadastro : Form
    {

        public Accounts conta = new Accounts();
        



        public Cadastro(Accounts conta)
        {   
            InitializeComponent();
            this.conta = conta;
        }


        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cadastrar_btn_Click(object sender, EventArgs e)
        {
            Users user = new Users
            {
                Nome = Nome_form.Text,
                Senha = Senha_form.Text,
                Dados = new()
            };


            conta.repositorio_u.Add(user);
            MessageBox.Show(" " + conta.repositorio_u.tam());
            MessageBox.Show("nome: " + user.Nome);

            Login login = new Login(conta);
            login.Show();
            this.Hide();

        }

        

    }
}
