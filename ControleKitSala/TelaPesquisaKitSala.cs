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
    public partial class TelaPesquisaKitSala : Form
    {
        public TelaPesquisaKitSala()
        {
            InitializeComponent();
        }

        private void btnPesqTodosKitSala_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaTudoKitSala", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            conexao.Open();
            comandos.ExecuteNonQuery();

            SqlDataAdapter info = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();
            info.Fill(table);

            BindingSource dados = new BindingSource();

            dados.DataSource = table;
            dataGridViewKitSala.DataSource = dados;
            dataGridViewKitSala.Columns[0].Visible = false;
            dataGridViewKitSala.Columns[1].Visible = false;
            dataGridViewKitSala.Columns[2].Visible = false;
            dataGridViewKitSala.Columns[3].Visible = false;
            dataGridViewKitSala.Columns[4].Visible = false;
            dataGridViewKitSala.Columns[5].HeaderCell.Value = "Código";
            dataGridViewKitSala.Columns[6].HeaderCell.Value = "Sala";
            dataGridViewKitSala.Columns[7].HeaderCell.Value = "Controle do Ar";
            dataGridViewKitSala.Columns[8].HeaderCell.Value = "Controle DataShow";
            dataGridViewKitSala.Columns[9].Visible = false;
            dataGridViewKitSala.Columns[10].HeaderCell.Value = "Chave";
            dataGridViewKitSala.Columns[11].Visible = false;
            dataGridViewKitSala.Columns[12].Visible = false;
        }

        private void btnBuscaKitSala_Click(object sender, EventArgs e)
        {
            if (tbCodigoKitSala.Text == "")
            {
                MessageBox.Show("Digite um código para a busca", "Atenção");
                tbCodigoKitSala.Focus();
                return;
            }

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaCodigoKitSala", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", tbCodigoKitSala.Text);
                conexao.Open();

                var tabelaDados = comandos.ExecuteReader();

                if (tabelaDados.Read())
                {
                    tbkitSala.Text = tabelaDados["nomeSala"].ToString();
                    checkBoxConAr.Checked =(bool)tabelaDados["controleAr"];
                    checkBoxConData.Checked= (bool)tabelaDados["controleDataShow"];
                    checkBoxApagador.Checked = (bool)tabelaDados["apagador"];
                    checkBoxChave.Checked = (bool)tabelaDados["chave"];
                    checkBoxAzul.Checked = (bool)tabelaDados["canetaoAzul"];
                    checkBoxPreto.Checked = (bool)tabelaDados["canetaoPreto"];

                    btnExcluir.Enabled = true;
                    btnAlterar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
              
                }

            }
            catch
            {
                MessageBox.Show("Não conseguimos localizar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pAlterarKitSala", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                byte apagador = 0;
                byte controleAr = 0;
                byte controleDataShow = 0;
                byte chave = 0;
                byte canetaoAzul = 0;
                byte canetaoPreto = 0;

                if (checkBoxApagador.Checked == true)
                {
                    apagador = 1;
                }
                if (checkBoxConAr.Checked == true)
                {
                    controleAr = 1;
                }
                if (checkBoxConData.Checked == true)
                {
                    controleDataShow = 1;
                }
                if (checkBoxChave.Checked == true)
                {
                    chave = 1;
                }
                if (checkBoxAzul.Checked == true)
                {
                    canetaoAzul = 1;
                }
                if (checkBoxPreto.Checked == true)
                {
                    canetaoPreto = 1;
                }

                comando.Parameters.AddWithValue("@sala", tbkitSala.Text);
                comando.Parameters.AddWithValue("@controleAr", controleAr);
                comando.Parameters.AddWithValue("@controleDataShow", controleDataShow);
                comando.Parameters.AddWithValue("@apagador", apagador);
                comando.Parameters.AddWithValue("@chave", chave);
                comando.Parameters.AddWithValue("@canetaoAzul", canetaoAzul);
                comando.Parameters.AddWithValue("@canetaoPreto", canetaoPreto);
                comando.Parameters.AddWithValue("@codigo", tbCodigoKitSala.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Kit Sala Alterado com sucesso!");

            }
            catch
            {
                MessageBox.Show("Kit Sala não alterado.");
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pDeletarkitSala", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", tbCodigoKitSala.Text);
                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("KitSala Excluido com sucesso!");
                tbkitSala.Clear();
                checkBoxConAr.Checked = false;
                checkBoxConData.Checked = false;
                checkBoxApagador.Checked = false;
                checkBoxChave.Checked = false;
                checkBoxAzul.Checked = false;
                checkBoxPreto.Checked = false;

            }
            catch
            {
                MessageBox.Show("KitSala não Excluido.");
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
