
using App.Cadastro;
using App.Outros;
using APP.Base.Registro;
using APP.Forms.Cadastro;
using APP.infra;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using SGA;
using System.Security.Policy;

namespace IFSPStore.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public static Usuario Usuario { get; set; }


        public FormPrincipal()
        {
           

            InitializeComponent();
            CarregaLogin();
        }

        private void CarregaLogin()
        {
            var login = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lblUsuario.Text = $"Usu�rio: {Usuario.Nome}";
                }
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        /*
                 private void usu�riosToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    Exibeformulario<CadastroUsuario>();
                }

         */



        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            TFormlario? cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Cadastro de Usuario / Paciente
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Exibeformulario<Cad_Usuario>();
        }

        private void usu�riosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<Cad_Medicos>();

        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Exibeformulario<Cad_Procedimento>();
        }

        private void grupoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<Cad_Agenda>();
        }

        private void usu�riosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Exibeformulario<Cad_Consulta>();
        }

        private void fAAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<FormReport>();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lan�arFaltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<FormReportCurso>();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroUsuario>();
        }
    }
}