using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconstruct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addRecontruçoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addReconstrucoes telaAdd = new addReconstrucoes();
            telaAdd.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tESTEAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAluno telateste = new addAluno();
            telateste.ShowDialog();
        }

        private void btnServidor_Click(object sender, EventArgs e)
        {
            
            FTServidor.IniciarServidor();
            txtStatus.Text = FTServidor.mensagemServidor;



        }

        private void oPÇÔESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
