using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;




namespace ControleKitSala
{
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvarFun_Click(object sender, EventArgs e)
        {
            //Comunicação com o banco de dados
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pCadastrarFuncionario", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@nome", tbNomeFun.Text);
                comando.Parameters.AddWithValue("@email", tbEmailFun.Text);
                comando.Parameters.AddWithValue("@chapa", tbChapaFun.Text);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Funcionário cadastrado com sucesso. ," +
                    "Deseja cadastrar outro Funcionário ou Sair?", 
                    "Novo Registro",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
                {
                    tbNomeFun.Clear();
                    tbEmailFun.Clear();
                    tbChapaFun.Clear();
                }
                else
                {
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("Funcionário não cadastrado","Atenção");
            }
            finally
            {
                if(conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

        }
    }
}
