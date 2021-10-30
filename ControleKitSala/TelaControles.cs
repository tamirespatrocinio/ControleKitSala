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
    public partial class TelaControles : Form
    {
        public TelaControles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime dataHora = DateTime.Now;
            String sala = "";
            String codigoSala = "";
            String nomeFuncionario = "";
            String registroFuncionario = "";
            SqlConnection conexao = new SqlConnection(Conexao.conectar());

            if (tbCodigoFun.Text == "")
            {
                MessageBox.Show("Digite um código para a busca", "Atenção");
                tbCodigoFun.Focus();
                return;
            }

            if (tbCodigoFun.Text != "")
            {
                SqlCommand comandoFun = new SqlCommand("pBuscaCodigoFuncionario", conexao);
                comandoFun.CommandType = CommandType.StoredProcedure;
                comandoFun.Parameters.AddWithValue("@codigo", tbCodigoFun.Text);
                conexao.Open();
                var tabelaDadosFun = comandoFun.ExecuteReader();
                tabelaDadosFun.Read();
                nomeFuncionario = tabelaDadosFun["Nome"].ToString();
                registroFuncionario = tabelaDadosFun["Chapa"].ToString();
                conexao.Close();
            }

            if (tbCodigoSala.Text != "")
            {
                SqlCommand comandoSala = new SqlCommand("pBuscaCodigoKitSala", conexao);
                comandoSala.CommandType = CommandType.StoredProcedure;
                comandoSala.Parameters.AddWithValue("@codigo", tbCodigoSala.Text);
                conexao.Open();
                var tabelaDadosSala = comandoSala.ExecuteReader();
                tabelaDadosSala.Read();
                sala = tabelaDadosSala["nomeSala"].ToString();
                codigoSala = tabelaDadosSala["idKsala"].ToString();
                conexao.Close();
            }

            try
            {

                if (sala != "" && nomeFuncionario != "" &&  registroFuncionario != "")
                {
                    var resposta = MessageBox.Show(
                     "Confirme as informações: " + "\n" +
                     "Sala: " + sala + "\n" +
                     "Funcionário: " + nomeFuncionario + "\n" +
                     "Registro: " + registroFuncionario + "\n" +
                     "Data/Hora: " + dataHora.ToString() + "\n" + "\n" +
                     "As informações estão corretas ? ",
                    "* Atenção *",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resposta == DialogResult.Yes)
                    {
                        SqlCommand comandoControle = new SqlCommand("pCadastrarControles", conexao);
                        comandoControle.CommandType = CommandType.StoredProcedure;

                        MessageBox.Show(codigoSala+" "+registroFuncionario);
                        comandoControle.Parameters.AddWithValue("@codigoSala", Convert.ToInt32(codigoSala));
                        comandoControle.Parameters.AddWithValue("@codigoFun", Convert.ToInt32(registroFuncionario));
                        comandoControle.Parameters.AddWithValue("@dataHoraEntrega", dataHora);
                        comandoControle.Parameters.AddWithValue("@dataHoraSaida", dataHora);

                        SqlParameter codigo = comandoControle.Parameters.Add("@codigo", SqlDbType.Int);
                        codigo.Direction = ParameterDirection.Output;

                        conexao.Open();
                        comandoControle.ExecuteNonQuery();

                    }
                    else
                    {
                        this.Close();
                    }

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
    }
}
