using APP.infra;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using SACP.APP.Cadastros;
using System.Security.Policy;

namespace IFSPStore.App
{
    public partial class FormPrincipal : MaterialForm
    {

        public static Usuario Usuario { get; set; }
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
            Exibeformulario<Cadastro_Procedimento>();
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
    }
}