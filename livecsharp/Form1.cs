using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using livecsharp.Classes;

namespace livecsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno (0, textNome.Text, textEmail.Text, textTelefone.Text, textSenha.Text, true);
            textId.Text = aluno.Id.ToString();
            aluno.Inserir();
            MessageBox.Show("Aluno Adicionado");
            LimparCampos();
            
        }
        private void LimparCampos()
        {
            textId.Clear(); textNome.Clear(); textEmail.Clear(); textTelefone.Clear(); textEmail.Clear(); textSenha.Clear(); chkAtivo.Checked = false;

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            Aluno aluno = new Aluno();
            var lista = aluno.ListarAlunos();
            lista.ForEach(a => {
                dgvLista.Rows.Add();
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnId.Index].Value = a.Id;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnNome.Index].Value = a.Nome;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnEmail.Index].Value = a.Email;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnTelefone.Index].Value = a.Telefone;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnAtivo.Index].Value = a.Ativo;
            });
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = (decimal)Aluno.ObterQuantidadeRegistros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvLista.Rows.Clear();
            Aluno aluno = new Aluno();
            var lista = aluno.ListarAlunos(0, (int)numericUpDown1.Value);
            lista.ForEach(a => {
                dgvLista.Rows.Add();
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnId.Index].Value = a.Id;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnNome.Index].Value = a.Nome;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnEmail.Index].Value = a.Email;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnTelefone.Index].Value = a.Telefone;
                dgvLista.Rows[lista.IndexOf(a)].Cells[clnAtivo.Index].Value = a.Ativo;
            });
        }
    }
}
