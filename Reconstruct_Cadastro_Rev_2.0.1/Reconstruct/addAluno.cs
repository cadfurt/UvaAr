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
    public partial class addAluno : Form
    {
        public addAluno()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("")){
                MessageBox.Show("Informe o nome.");
                return;
            }
         try {
                DAO.alunosDB alunoDB = new DAO.alunosDB();
                negocio.Alunos alunoreg = new negocio.Alunos(txtNome.Text, txtEndereco.Text, int.Parse(txtIdade.Text));
                alunoDB.IncluirAluno(alunoreg);
                MessageBox.Show("Registro salvo com sucesso!");
                btnLimpar.PerformClick();
         } catch (Exception c){

                MessageBox.Show(c.ToString());
            }
            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DAO.alunosDB alunodb = new DAO.alunosDB();

            txtCod.Text = "";
            txtEndereco.Text = "";
            txtIdade.Text = "";
            txtNome.Text = "";
            txtCod.Focus();
            datagridAlunos.DataSource = alunodb.getAlunos();
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            try
            {

                DAO.alunosDB alunosDB = new DAO.alunosDB();
                DataTable tbAlunos = alunosDB.getAlunos();
                
                //cria uma instância da classe Suporte - criaJson
                negocio.criaJson sp = new negocio.criaJson();

                //chama o método para converter o datatable para JSON
                string json;
                txtJson.Text = sp.converteDataTabelParaJSON(tbAlunos);
                json = txtJson.Text;

                // SAlva o arquivo json em alguma pasta
                System.IO.File.WriteAllText(@"C:\Medilab\teste.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
