using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrientacaoAObjetos.Dia2;

namespace OrientacaoAObjeto.WindowsForms
{
    public partial class AulaConstrutores : Form
    {
        public AulaConstrutores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado();
            MessageBox.Show(segurado.Teste());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado("Gabriel");
            
            string mensagem = $"Nome: {segurado.Nome}";

            MessageBox.Show(mensagem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = 123;
            Segurado segurado = new Segurado(id);
            
            string mensagem = $"ID: {segurado.Id}";

            MessageBox.Show(mensagem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado("Gabriel");
            segurado.Cpf = "123.456.789-00";
            
            string mensagem = $"Nome: {segurado.Nome} \nCPF: {segurado.Cpf}";

            MessageBox.Show(mensagem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new RevisaoConstrutores().Show();
        }
    }
}
