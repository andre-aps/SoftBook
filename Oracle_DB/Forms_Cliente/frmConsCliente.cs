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
    public partial class frmConsCliente : Form
    {
        OracleConnection ora = Conexao.GetConnection();

        public frmConsCliente()
        {
            InitializeComponent();
        }

        private void frmConsCliente_Load(object sender, EventArgs e)
        {
            //Após abrir a conexão com o banco, será executado o procedimento armazenado para realizar a consulta.
            ora.Open();
            OracleCommand comando = new OracleCommand("CONSULTAR_CLIENTE", ora)
            {
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.Add("REGISTROS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter
            {
                SelectCommand = comando
            };
            DataTable table = new DataTable();
            adaptador.Fill(table);
            dgvCliente.DataSource = table;
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ora.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
