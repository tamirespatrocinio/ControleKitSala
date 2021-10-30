using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleKitSala
{
    public partial class TelaFuncionarioPesquisaCodigo : Form
    {
        public TelaFuncionarioPesquisaCodigo()
        {
            InitializeComponent();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (tbCodigoFun.Text == "")
            {
                MessageBox.Show("Digite um código para a busca","Atenção");
                tbCodigoFun.Focus();
                return;
            }

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaCodigoFuncionario",conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", tbCodigoFun.Text);
                conexao.Open();

                var tabelaDados = comandos.ExecuteReader();

                if (tabelaDados.Read())
                {
                    tbNomeFun.Text = tabelaDados["Nome"].ToString();
                    tbEmailFun.Text = tabelaDados["Email"].ToString();
                    tbChapaFun.Text = tabelaDados["Chapa"].ToString();

                    btnExcluir.Enabled = true;
                    btnAlterar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Código não localizado","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Question);
                    tbNomeFun.Clear();
                    tbEmailFun.Clear();
                    tbChapaFun.Clear();
                }
            
            }
            catch
            {
                MessageBox.Show("Não conseguimos localizar os dados","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            finally
            {
                if(conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pAlterarFuncionario", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", tbCodigoFun.Text);
                comandos.Parameters.AddWithValue("@nome", tbNomeFun.Text);
                comandos.Parameters.AddWithValue("@email", tbEmailFun.Text);
                comandos.Parameters.AddWithValue("@chapa",tbChapaFun.Text);

                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Funcionário Alterado com sucesso!");

            }
            catch
            {
                MessageBox.Show("Funcionário não alterado.");
            }
            finally
            {
                if(conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        private void TelaFuncionarioPesquisaCodigo_Load(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnPesqTodosFun_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaTudoFuncionario", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            conexao.Open();
            comandos.ExecuteNonQuery();

            SqlDataAdapter info = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            info.Fill(table);

            BindingSource dados = new BindingSource();

            dados.DataSource = table;

            dataGridViewFuncionario.DataSource = dados;
            dataGridViewFuncionario.Columns[0].Visible = false;
            dataGridViewFuncionario.Columns[1].Visible = false;
            dataGridViewFuncionario.Columns[2].Visible = false;
            dataGridViewFuncionario.Columns[3].Visible = false;
            dataGridViewFuncionario.Columns[4].HeaderCell.Value="Código";
            dataGridViewFuncionario.Columns[5].HeaderCell.Value = "Nome";
            dataGridViewFuncionario.Columns[6].HeaderCell.Value = "E-mail";
            dataGridViewFuncionario.Columns[7].HeaderCell.Value = "Chapa";



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pDeletarFuncionario", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", tbCodigoFun.Text);
                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Funcionário Excluido com sucesso!");
                tbNomeFun.Clear();
                tbEmailFun.Clear();
                tbChapaFun.Clear();

            }
            catch
            {
                MessageBox.Show("Funcionário não Excluido.");
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }
    }
}
