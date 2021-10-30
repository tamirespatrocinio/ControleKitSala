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
    public partial class TelaKitSala : Form
    {
        public TelaKitSala()
        {
            InitializeComponent();
        }

        private void btnSalvarKitSala_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pCadastrarKitSala", conexao);
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
                if(checkBoxConAr.Checked == true)
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
                if ( checkBoxAzul.Checked == true)
                {
                    canetaoAzul = 1;
                }
                if (checkBoxPreto.Checked == true)
                {
                    canetaoPreto = 1;
                }

                
                comando.Parameters.AddWithValue("@sala", tbKitSala.Text);
                comando.Parameters.AddWithValue("@controleAr", controleAr);
                comando.Parameters.AddWithValue("@controleDataShow", controleDataShow);
                comando.Parameters.AddWithValue("@apagador", apagador);
                comando.Parameters.AddWithValue("@chave", chave);
                comando.Parameters.AddWithValue("@canetaoAzul", canetaoAzul);
                comando.Parameters.AddWithValue("@canetaoPreto", canetaoPreto);


                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Kit Sala cadastrado com sucesso." +
                    "Deseja cadastrar outro Kit Sala?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    tbKitSala.Clear();
                    checkBoxChave.Checked = false;
                    checkBoxApagador.Checked = false;
                    checkBoxAzul.Checked = false;
                    checkBoxConAr.Checked = false;
                    checkBoxConData.Checked = false;
                    checkBoxPreto.Checked = false;              
                }
                else
                {
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("Kit Sala não cadastrado", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

        }
    }
}
