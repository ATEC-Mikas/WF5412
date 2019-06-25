using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication.AcessoADados
{
    public partial class frmListarEncomendasClientes : Form
    {
        public frmListarEncomendasClientes()
        {
            InitializeComponent();
            cboClientes.ValueMember = "Nome";
        }
        private void frmListarEncomendasClientes_Load(object sender, EventArgs e)
        {
            cboClientes.Items.Add("--Selecionar Cliente--");
            cboClientes.SelectedIndex = 0;
            ClassLibrary.DAL dal = new ClassLibrary.DAL(Properties.Settings.Default.ConnectionString);

            foreach (ClassLibrary.Clientes cliente in dal.ListaTodosClientes())
                cboClientes.Items.Add(cliente);
        }

        private void BtnVerContacto_Click(object sender, EventArgs e)
        {
            if(cboClientes.SelectedIndex!=0)
            {
                ClassLibrary.DAL dal = new ClassLibrary.DAL(Properties.Settings.Default.ConnectionString);
                ClassLibrary.Cliente cliente = dal.ListaContactosClientes().FirstOrDefault(c => c.ID.StartsWith(((ClassLibrary.Clientes)cboClientes.SelectedItem).ID,StringComparison.InvariantCultureIgnoreCase));
                MessageBox.Show((cliente == null ? "Erro" : $"Nome do contacto: {cliente.NomeContacto}"));
            }
        }

        private void BtnVerEncomendas_Click(object sender, EventArgs e)
        {
            if(cboClientes.SelectedIndex!=0)
            {
                ClassLibrary.DAL dal = new ClassLibrary.DAL(Properties.Settings.Default.ConnectionString);
                dgvEncomendas.DataSource = dal.ListaEncomendasClientes(((ClassLibrary.Clientes)cboClientes.SelectedItem).ID);
            }
        }

        private void DgvEncomendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassLibrary.DAL dal = new ClassLibrary.DAL(Properties.Settings.Default.ConnectionString);
            using (PopUpEncomenda f = new PopUpEncomenda(dal.ListaEncomenda((int)dgvEncomendas.SelectedCells[0].OwningRow.Cells[1].Value)))
            {
                f.ShowDialog();
            }
        }
    }
}
