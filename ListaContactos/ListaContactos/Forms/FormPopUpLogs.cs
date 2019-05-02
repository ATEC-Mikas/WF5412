using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaContactos
{
    public partial class FormPopUpLogs : Form
    {

        private FormPopUpLogs()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public FormPopUpLogs(Contacto c) : this()
        {
            foreach (string[] ls in Modificacoes.GetModFromId(c.ID))
                DataGridLogs.Rows.Add(ls[0],ls[1],ls[2]);

            labelNContacto.Text = labelNContacto.Text.Replace("%Contacto%", c.Nome);
        }
    }
}
