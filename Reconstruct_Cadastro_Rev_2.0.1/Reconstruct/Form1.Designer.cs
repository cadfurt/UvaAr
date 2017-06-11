namespace Reconstruct
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPÇÔESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecontruçoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnServidor = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPÇÔESToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPÇÔESToolStripMenuItem
            // 
            this.oPÇÔESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecontruçoesToolStripMenuItem});
            this.oPÇÔESToolStripMenuItem.Name = "oPÇÔESToolStripMenuItem";
            this.oPÇÔESToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.oPÇÔESToolStripMenuItem.Text = "OPÇÔES";
            this.oPÇÔESToolStripMenuItem.Click += new System.EventHandler(this.oPÇÔESToolStripMenuItem_Click);
            // 
            // addRecontruçoesToolStripMenuItem
            // 
            this.addRecontruçoesToolStripMenuItem.Name = "addRecontruçoesToolStripMenuItem";
            this.addRecontruçoesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addRecontruçoesToolStripMenuItem.Text = "Nova Reconstrução";
            this.addRecontruçoesToolStripMenuItem.Click += new System.EventHandler(this.addRecontruçoesToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 117);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(444, 222);
            this.txtStatus.TabIndex = 1;
            // 
            // btnServidor
            // 
            this.btnServidor.Location = new System.Drawing.Point(12, 56);
            this.btnServidor.Name = "btnServidor";
            this.btnServidor.Size = new System.Drawing.Size(444, 55);
            this.btnServidor.TabIndex = 2;
            this.btnServidor.Text = "Iniciar Servidor";
            this.btnServidor.UseVisualStyleBackColor = true;
            this.btnServidor.Click += new System.EventHandler(this.btnServidor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 351);
            this.Controls.Add(this.btnServidor);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UVA AR - SERVIDOR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPÇÔESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecontruçoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnServidor;
    }
}

