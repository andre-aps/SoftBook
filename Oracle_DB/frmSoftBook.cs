using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Oracle_DB
{
    public partial class frmSoftBook : Form
    {
        public frmSoftBook()
        {
            InitializeComponent();
        }

        //Conforme a opção, será instanciado um novo formulário.

        private void btnConsCliente_Click(object sender, EventArgs e)
        {            
            Form Concliente = new frmConsCliente();
            Concliente.ShowDialog();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {            
            Form Cadcliente = new frmCadCliente();
            Cadcliente.ShowDialog();           
        }               

        private void btnAltCliente_Click(object sender, EventArgs e)
        {            
            Form Altcliente = new frmAltCliente();
            Altcliente.ShowDialog();
        }

        private void btnRemCliente_Click(object sender, EventArgs e)
        {            
            Form Remcliente = new frmRemCliente();
            Remcliente.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Sair da aplicação.
            Application.Exit();
        } 
    }
}
