namespace Dever
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarConsultaToolStripMenuItem,
            this.consultarConsultaToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarConsultaToolStripMenuItem
            // 
            this.cadastrarConsultaToolStripMenuItem.Name = "cadastrarConsultaToolStripMenuItem";
            this.cadastrarConsultaToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.cadastrarConsultaToolStripMenuItem.Text = "Cadastrar Consulta";
            this.cadastrarConsultaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarConsultaToolStripMenuItem_Click);
            // 
            // consultarConsultaToolStripMenuItem
            // 
            this.consultarConsultaToolStripMenuItem.Name = "consultarConsultaToolStripMenuItem";
            this.consultarConsultaToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.consultarConsultaToolStripMenuItem.Text = "Consultar Consulta";
            this.consultarConsultaToolStripMenuItem.Click += new System.EventHandler(this.consultarConsultaToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
    }
}

