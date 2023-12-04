
using APP.Base.Registro;
using APP.Forms.Cadastro;
using APP.infra;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using System.Security.Policy;

namespace IFSPStore.App
{
    public partial class FormPrincipal : MaterialForm
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }



        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        /*
                 private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Exibeformulario<Cad_Usuario>();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          //  Exibeformulario<Agenda_registra>();
        }
    }
}