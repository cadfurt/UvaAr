using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconstruct
{
    public partial class addReconstrucoes : Form
    {
        public addReconstrucoes()
        {
            InitializeComponent();

            DAO.reconstrucaoBD reconstrucaobd = new DAO.reconstrucaoBD();
            dataGridReconstrucoes.DataSource = reconstrucaobd.getReconstrucoes();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (txtNome.Text.Equals("") || txtDiretorio.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }


            try {
                DAO.reconstrucaoBD reconstrucaoBD = new DAO.reconstrucaoBD();
                negocio.Reconstrucoes reconstrucaoreg = new negocio.Reconstrucoes(txtNome.Text, txtDiretorio.Text.ToLower(), txtOsexame.Text);
                reconstrucaoBD.IncluirReconstrucao(reconstrucaoreg);
                MessageBox.Show("Registro efetuado com sucesso.");
                btnLimpar.PerformClick();
                dataGridReconstrucoes.DataSource = reconstrucaoBD.getReconstrucoes();
               

            } catch (Exception ex){
                    MessageBox.Show(ex.Message);
                }
            finally{
            
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDiretorio.Text = "";
            txtNome.Text = "";
            txtOsexame.Text = "";
            txtNome.Focus();
         }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd1 = new FolderBrowserDialog();

            fbd1.Description = "Selecione o caminho da reconstrução.";
            fbd1.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd1.ShowNewFolderButton = true;
            
            if (fbd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDiretorio.Text = fbd1.SelectedPath;
            }
            
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            try
            {

                DAO.reconstrucaoBD reconstrucoesBD = new DAO.reconstrucaoBD();
                DataTable tbReconstrucoes = reconstrucoesBD.getReconstrucoes();

                //cria uma instância da classe Suporte - criaJson
                negocio.criaJson sp = new negocio.criaJson();

                //chama o método para converter o datatable para JSON
                string json;
                txtJson.Text = sp.converteDataTabelParaJSON(tbReconstrucoes);
                json = txtJson.Text;

                string path = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString()) + "UVA.JSON";
                System.IO.File.WriteAllText(path, json);
                MessageBox.Show("Arquivo criado em : " + path);

            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
