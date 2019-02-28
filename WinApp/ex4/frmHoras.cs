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
    public partial class frmHoras : Form
    {
        public frmHoras()
        {
            InitializeComponent();
        }

        private void QueHorasSao_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            radioAutomatico.Checked = true;
            Timer.Start();
            Atualizar();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            now = DateTime.Now;
            pbSegundos.Value = now.Second;
            lblSegundos.Text = string.Format("{0} Segundos", now.Second);
            pbMinutos.Value = now.Minute;
            lblMinutos.Text = string.Format("{0} Minutos", now.Minute);
            pbHoras.Value = now.Hour;
            lblHoras.Text = string.Format("{0} Horas", now.Hour);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void radioAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if(radioAutomatico.Checked)
            {
                radioManual.Checked = false;
                btnAtualizar.Enabled = false;
                Timer.Start();
            }
        }

        private void radioManual_CheckedChanged(object sender, EventArgs e)
        {
            if(radioManual.Checked)
            {
                radioAutomatico.Checked = false;
                Timer.Stop();
                btnAtualizar.Enabled = true;
            }
        }
    }
}
