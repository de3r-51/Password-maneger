using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.ApplicationServices;
using Gestor_de_Palavras_passe2.Models;
using Gestor_de_Palavras_passe2.Controllers;
using Gestor_de_Palavras_passe2.Interfaces;

namespace Gestor_de_Palavras_passe
{
    public partial class Dashboard : Form
    {

        Accounts conta { get; set; }






        public Dashboard(Accounts conta)
        {
            InitializeComponent();
            this.conta = conta;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = conta.repositorio;

            Tabela.DataSource = bindingSource;


        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


            List<Dados> infos = new List<Dados>();
            foreach (DataGridViewRow row in Tabela.Rows)
            {
                infos.Add(new Dados
                {
                    Nick = row.Cells["Nick"].ToString(),
                    Password = row.Cells["Password"].ToString(),
                    Plataforma = row.Cells["Plataforma"].ToString()
                });
            }
            conta.repositorio = infos;

            Login login = new Login(conta);
            login.Show();
            this.Hide();



        }

        private void export_Click(object sender, EventArgs e)
        {
        }

        private void import_Click(object sender, EventArgs e)
        {

        }

        private void Categoria_btn_Click(object sender, EventArgs e)
        {
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void update_Click(object sender, EventArgs e)
        {
        }

        private void Adicionar_Tarefa_Click(object sender, EventArgs e)
        {



            Dados dados = new Dados
            {
                Nick = Nome_dash.Text,
                Password = Senha_dash.Text,
                Plataforma = Categoria_dash.Text
            };



            conta.repositorio.Add(dados);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = conta.repositorio;

            Tabela.DataSource = bindingSource;


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Arquivos de texto (*.txt)|*.txt";
            saveFileDialog1.Title = "Salvar arquivo de texto";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                using (StreamWriter sw = new StreamWriter(filePath))
                {


                    foreach (Dados linha in conta.repositorio)
                    {
                        sw.Write("Nome: " + linha.Nick + " |  ");
                        sw.Write("Senha: " + linha.Password + " | ");
                        sw.Write("Plataforma: " + linha.Plataforma + " | ");
                        sw.WriteLine(" ");
                    }
                }

                MessageBox.Show("Dados exportados com sucesso!");
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de texto(*.txt) | *.txt | Todos os arquivos(*.*)| *.* ";
            openFileDialog.Title = "Salvar arquivo de texto";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (StreamReader rd = new StreamReader(filePath))
                {


                    foreach (Dados linha in conta.repositorio)
                    {

                        List<string> linhas = new List<string>();
                        string Linhas;


                        while ((Linhas = rd.ReadLine()) != null)
                        {
                            linhas.Add(Linhas);
                            string[] palavras = Linhas.Split(' ');
                            linha.Nick = palavras[0];
                            linha.Password = palavras[1];
                            linha.Plataforma = palavras[2];
                        }


                    }
                }

                MessageBox.Show("Dados exportados com sucesso!");
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Nome_dash.Text = "";
            Senha_dash.Text = "";
            Categoria_dash.Text = "";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Tabela.DataSource = " ";
        }
    }
}
