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
    public partial class frmCadCliente : Form
    {
        OracleConnection ora = Conexao.GetConnection();

        public frmCadCliente()
        {            
            InitializeComponent();            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        { 
            //Após abrir a conexão, será executado o procedimento armazenado para inserir um novo cliente.
            ora.Open();
            OracleCommand comando = new OracleCommand("INSERIR_CLIENTE", ora)
            {
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.Add("VCPF", OracleDbType.Varchar2).Value = txtCPF.Text;
            comando.Parameters.Add("VNOME", OracleDbType.Varchar2).Value = txtNome.Text;
            comando.Parameters.Add("VEMAIL", OracleDbType.Varchar2).Value = txtEmail.Text;
            comando.Parameters.Add("VCEP", OracleDbType.Varchar2).Value = txtCEP.Text;
            comando.Parameters.Add("VTELEFONE", OracleDbType.Varchar2).Value = txtTelefone.Text;
            comando.Parameters.Add("VNASCIMENTO", OracleDbType.Varchar2).Value = txtDataNasc.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Cliente Cadastrado!");
            ora.Close();            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só será permitido letras, backspace e espaço na caixa de texto Nome.
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space)) {
                e.Handled = true;
            }
        }       

        private void frmCadCliente_Activated(object sender, EventArgs e)
        {
            txtCPF.Focus();
        }
    }  
}
