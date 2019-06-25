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
    public partial class PopUpEncomenda : Form
    {
        public PopUpEncomenda()
        {
            InitializeComponent();
        }

        public PopUpEncomenda(DataTable dt) : this()
        {
            dgvEncomenda.DataSource = dt;
        }
    }
}
