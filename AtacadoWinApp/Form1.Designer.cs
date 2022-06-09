namespace AtacadoWinApp
{
    partial class PrincipalFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OiMundoBtn = new System.Windows.Forms.Button();
            this.FecharBtn = new System.Windows.Forms.Button();
            this.PrincipalMnu = new System.Windows.Forms.MenuStrip();
            this.ArquivoMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FuncionariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdicionarFuncionarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrincipalMnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // OiMundoBtn
            // 
            this.OiMundoBtn.Location = new System.Drawing.Point(12, 415);
            this.OiMundoBtn.Name = "OiMundoBtn";
            this.OiMundoBtn.Size = new System.Drawing.Size(120, 23);
            this.OiMundoBtn.TabIndex = 0;
            this.OiMundoBtn.Text = "Clique Aqui!!!";
            this.OiMundoBtn.UseVisualStyleBackColor = true;
            this.OiMundoBtn.Click += new System.EventHandler(this.OiMundoBtn_Click);
            // 
            // FecharBtn
            // 
            this.FecharBtn.Location = new System.Drawing.Point(713, 415);
            this.FecharBtn.Name = "FecharBtn";
            this.FecharBtn.Size = new System.Drawing.Size(75, 23);
            this.FecharBtn.TabIndex = 1;
            this.FecharBtn.Text = "Fechar";
            this.FecharBtn.UseVisualStyleBackColor = true;
            this.FecharBtn.Click += new System.EventHandler(this.FecharBtn_Click);
            // 
            // PrincipalMnu
            // 
            this.PrincipalMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArquivoMenuItem1});
            this.PrincipalMnu.Location = new System.Drawing.Point(0, 0);
            this.PrincipalMnu.Name = "PrincipalMnu";
            this.PrincipalMnu.Size = new System.Drawing.Size(800, 24);
            this.PrincipalMnu.TabIndex = 2;
            this.PrincipalMnu.Text = "menuStrip1";
            // 
            // ArquivoMenuItem1
            // 
            this.ArquivoMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FuncionariosMenuItem});
            this.ArquivoMenuItem1.Name = "ArquivoMenuItem1";
            this.ArquivoMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.ArquivoMenuItem1.Text = "Arquivo";
            // 
            // FuncionariosMenuItem
            // 
            this.FuncionariosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdicionarFuncionarioMenuItem});
            this.FuncionariosMenuItem.Name = "FuncionariosMenuItem";
            this.FuncionariosMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FuncionariosMenuItem.Text = "Funcionários";
            // 
            // AdicionarFuncionarioMenuItem
            // 
            this.AdicionarFuncionarioMenuItem.Name = "AdicionarFuncionarioMenuItem";
            this.AdicionarFuncionarioMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AdicionarFuncionarioMenuItem.Text = "Adicionar";
            this.AdicionarFuncionarioMenuItem.Click += new System.EventHandler(this.AdicionarFuncionarioMenuItem_Click);
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FecharBtn);
            this.Controls.Add(this.OiMundoBtn);
            this.Controls.Add(this.PrincipalMnu);
            this.MainMenuStrip = this.PrincipalMnu;
            this.Name = "PrincipalFrm";
            this.Text = "Form1";
            this.PrincipalMnu.ResumeLayout(false);
            this.PrincipalMnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OiMundoBtn;
        private Button FecharBtn;
        private MenuStrip PrincipalMnu;
        private ToolStripMenuItem ArquivoMenuItem1;
        private ToolStripMenuItem FuncionariosMenuItem;
        private ToolStripMenuItem AdicionarFuncionarioMenuItem;
    }
}