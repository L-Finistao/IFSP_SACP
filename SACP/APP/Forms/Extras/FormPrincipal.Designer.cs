namespace IFSPStore.App
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            toolStripSeparator1 = new ToolStripSeparator();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem1 = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            medicosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            agendaToolStripMenuItem = new ToolStripMenuItem();
            procedimentosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            agendamentoToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            historicoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            fAAToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 23);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, menuToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(815, 27);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem1, toolStripSeparator2, agendamentoToolStripMenuItem, toolStripSeparator4, fAAToolStripMenuItem1, toolStripSeparator3, sairToolStripMenuItem1 });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 23);
            menuToolStripMenuItem.Text = "&Menu";
            // 
            // cadastrosToolStripMenuItem1
            // 
            cadastrosToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, medicosToolStripMenuItem, toolStripSeparator5, agendaToolStripMenuItem, procedimentosToolStripMenuItem });
            cadastrosToolStripMenuItem1.Name = "cadastrosToolStripMenuItem1";
            cadastrosToolStripMenuItem1.Size = new Size(180, 22);
            cadastrosToolStripMenuItem1.Text = "&Cadastros";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(154, 22);
            usuarioToolStripMenuItem.Text = "&Usuario";
            usuarioToolStripMenuItem.Click += toolStripMenuItem4_Click;
            // 
            // medicosToolStripMenuItem
            // 
            medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            medicosToolStripMenuItem.Size = new Size(154, 22);
            medicosToolStripMenuItem.Text = "&Medicos";
            medicosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(151, 6);
            // 
            // agendaToolStripMenuItem
            // 
            agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            agendaToolStripMenuItem.Size = new Size(154, 22);
            agendaToolStripMenuItem.Text = "&Agenda";
            agendaToolStripMenuItem.Click += grupoDeProdutosToolStripMenuItem_Click;
            // 
            // procedimentosToolStripMenuItem
            // 
            procedimentosToolStripMenuItem.Name = "procedimentosToolStripMenuItem";
            procedimentosToolStripMenuItem.Size = new Size(154, 22);
            procedimentosToolStripMenuItem.Text = "&Procedimentos";
            procedimentosToolStripMenuItem.Click += clientesToolStripMenuItem_Click_1;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // agendamentoToolStripMenuItem
            // 
            agendamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultaToolStripMenuItem, historicoToolStripMenuItem });
            agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            agendamentoToolStripMenuItem.Size = new Size(180, 22);
            agendamentoToolStripMenuItem.Text = "&Agendamento";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(180, 22);
            consultaToolStripMenuItem.Text = "&Consulta";
            consultaToolStripMenuItem.Click += usuáriosToolStripMenuItem1_Click;
            // 
            // historicoToolStripMenuItem
            // 
            historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            historicoToolStripMenuItem.Size = new Size(180, 22);
            historicoToolStripMenuItem.Text = "&Historico";
            historicoToolStripMenuItem.Click += historicoToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // fAAToolStripMenuItem1
            // 
            fAAToolStripMenuItem1.Name = "fAAToolStripMenuItem1";
            fAAToolStripMenuItem1.Size = new Size(180, 22);
            fAAToolStripMenuItem1.Text = "&FAA";
            fAAToolStripMenuItem1.Click += fAAToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(180, 22);
            sairToolStripMenuItem1.Text = "&Sair";
            sairToolStripMenuItem1.Click += sairToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(821, 492);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "FormPrincipal";
            Text = "SACP - SISTEMA DE AGENDAMENTO DE CONSULTA E PROCEDIMENTOS";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripSeparator toolStripSeparator1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem1;
        private ToolStripMenuItem agendamentoToolStripMenuItem;
        private ToolStripMenuItem fAAToolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem medicosToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem agendaToolStripMenuItem;
        private ToolStripMenuItem procedimentosToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem lançarFaltasToolStripMenuItem;
        private ToolStripMenuItem historicoToolStripMenuItem;
    }
}