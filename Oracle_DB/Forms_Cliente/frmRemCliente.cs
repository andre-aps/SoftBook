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
    public partial class frmRemCliente : Form
    {
        //String de conexão
        OracleConnection ora = new OracleConnection("DATA SOURCE=localhost:1521/XE;USER ID=ANDRE;PASSWORD=123");

        public frmRemCliente()
        {
            InitializeComponent();
        }        

        private void btnRemover_Click(object sender, EventArgs e)
        {       
            //Abrir a conexão com o banco de dados.
            ora.Open();
            
            //Conferir se o registro a ser apagado existe no banco de dados. Caso exista, o procedimento armazenado é executado.
            string query = "SELECT CPF FROM CLIENTE WHERE CPF = '" + txtCPF.Text + "'";
            OracleCommand cmd = new OracleCommand(query, ora);
            cmd.ExecuteScalar();

            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                OracleCommand comando = new OracleCommand("ELIMINAR_CLIENTE", ora)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.Add("CPF", OracleDbType.Varchar2).Value = txtCPF.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente Removido!");
            } else {
                MessageBox.Show("CPF Inválido!");
            }
            reader.Close();

            //Fecha a conexão com o banco de dados.
            ora.Close();
        }
        
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();           
        }
    }
}
