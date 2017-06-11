namespace Reconstruct
{
    partial class addReconstrucoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addReconstrucoes));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataGridReconstrucoes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOsexame = new System.Windows.Forms.TextBox();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnJson = new System.Windows.Forms.Button();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReconstrucoes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(150, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(191, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(150, 96);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(191, 20);
            this.txtDiretorio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Caminho do objeto:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(266, 302);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(352, 302);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dataGridReconstrucoes
            // 
            this.dataGridReconstrucoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReconstrucoes.Location = new System.Drawing.Point(12, 133);
            this.dataGridReconstrucoes.Name = "dataGridReconstrucoes";
            this.dataGridReconstrucoes.Size = new System.Drawing.Size(417, 163);
            this.dataGridReconstrucoes.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "OS do exame:";
            // 
            // txtOsexame
            // 
            this.txtOsexame.Location = new System.Drawing.Point(150, 62);
            this.txtOsexame.Name = "txtOsexame";
            this.txtOsexame.Size = new System.Drawing.Size(95, 20);
            this.txtOsexame.TabIndex = 14;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(347, 95);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(82, 23);
            this.btnProcurar.TabIndex = 15;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnJson
            // 
            this.btnJson.Location = new System.Drawing.Point(185, 302);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(75, 23);
            this.btnJson.TabIndex = 16;
            this.btnJson.Text = "Gerar JSON";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // txtJson
            // 
            this.txtJson.Location = new System.Drawing.Point(449, 28);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(452, 268);
            this.txtJson.TabIndex = 17;
            // 
            // addReconstrucoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 343);
            this.Controls.Add(this.txtJson);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtOsexame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridReconstrucoes);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addReconstrucoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar uma nova Reconstrução";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReconstrucoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dataGridReconstrucoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOsexame;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.TextBox txtJson;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}