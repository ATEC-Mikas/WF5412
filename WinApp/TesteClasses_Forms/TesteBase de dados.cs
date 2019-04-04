using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TesteClasses_Forms
{
    public partial class TesteBase_de_dados : Form
    {
        public TesteBase_de_dados()
        {
            InitializeComponent();

            listBox1.DisplayMember = "Nome";


            DAL d = new DAL();
            List<MinhasClasses.Editora> E = d.ObterTodasEditoras();

            foreach (MinhasClasses.Editora t in E)
                listBox1.Items.Add(t);

        }
    }
}
