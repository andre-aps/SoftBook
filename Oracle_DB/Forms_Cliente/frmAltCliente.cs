using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client; //Gerenciamento de dados Oracle.

namespace Oracle_DB
{
    public partial class frmAltCliente : Form
    {
        //String de conexão
        OracleConnection ora = new OracleConnection("DATA SOURCE=localhost:1521/XE;USER ID=ANDRE;PASSWORD=123");

        public frmAltCliente()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Após abrir a conexão, será executado o procedimento armazenado para atualizar um cliente.
            ora.Open();
            OracleCommand comando = new OracleCommand("ATUALIZAR_CLIENTE", ora)
            {
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.Add("CPF", OracleDbType.Varchar2).Value = txtCPF.Text;
            comando.Parameters.Add("NOME", OracleDbType.Varchar2).Value = txtNome.Text;
            comando.Parameters.Add("EMAIL", OracleDbType.Varchar2).Value = txtEmail.Text;
            comando.Parameters.Add("CEP", OracleDbType.Varchar2).Value = txtCEP.Text;
            comando.Parameters.Add("TELEFONE", OracleDbType.Varchar2).Value = txtTelefone.Text;
            comando.Parameters.Add("NASCIMENTO", OracleDbType.Date).Value = txtDataNasc.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Cliente Atualizado!");
            ora.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void frmAltCliente_Activated(object sender, EventArgs e)
        {
            txtCPF.Focus();
        }
    }
}
