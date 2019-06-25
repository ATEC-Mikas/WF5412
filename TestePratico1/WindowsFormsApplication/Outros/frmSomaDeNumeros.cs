using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace WindowsFormsApplication.Outros
{
    public partial class frmSomaDeNumeros : Form
    {
        public frmSomaDeNumeros()
        {
            InitializeComponent();
        }
        private void btnSomaNumeros_Click(object sender, EventArgs e)
        {
            if(!rdbPar.Checked && !rdbImpar.Checked)
            {
                MessageBox.Show("Tem de ter um radiobutton escolhido!");
            } else
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Ficheiros txt (*.txt)|*.txt";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        List<int> numeros = new List<int>();
                        StreamReader reader = new StreamReader(openFileDialog.FileName);
                        while(!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            int result = 0;
                            if(int.TryParse(line,out result))
                            {
                                numeros.Add(result);
                            }
                        }
                        lblSoma.Text = ClassLibrary.Class.SomaValores(numeros.ToArray(), rdbPar.Checked).ToString();
                    }
                }
            }
        }
    }
}
