using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4
{
    public partial class frmQuantoTempoPassou : Form
    {
        public frmQuantoTempoPassou()
        {
            InitializeComponent();
        }

        private void frmQuantoTempoPassou_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            CalendarioInicio.MaxDate = DateTime.Now;
            CalendarioFim.MinDate = DateTime.Now;
            CalendarioFim.MaxSelectionCount = 1;
            CalendarioInicio.MaxSelectionCount = 1;
        }

        private void CalendarioChanged(object sender, DateRangeEventArgs e)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan t = CalendarioInicio.SelectionStart - CalendarioFim.SelectionStart;
            if (t < new TimeSpan(0))
            {
                int x = t.Days * -1;
                t = new TimeSpan(x, 0, 0, 0);
            }
            zeroTime = (zeroTime + t);
            Atualizar(zeroTime.Day-1, zeroTime.Month-1, zeroTime.Year-1);
        }
        private void Atualizar(int d,int m, int a)
        {
            if (d == 1)
                lblDias.Text = "1 Dia";
            else
                lblDias.Text = String.Format("{0} Dias", d);
            if (m == 1)
                lblMes.Text = "1 Mês";
            else
                lblMes.Text = String.Format("{0} Meses", m);
            if (a == 1)
                lblAno.Text = "1 Ano";
            else
                lblAno.Text = String.Format("{0} Anos", a);
        }
    }
}
