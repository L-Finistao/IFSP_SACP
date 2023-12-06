using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace APP.Base.Relatorios
{
    public partial class BaseConsulta : MaterialForm
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

        #region Construtor
        public BaseConsulta()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridViewConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AltEdit();
        }

        protected virtual void AltEdit()
        {
            Editar();
        }
        #endregion

        #region CRUD Methods
        protected void LimpaCampos()
        {
            IsAlteracao = false;
           
        }

        protected virtual void CarregaGrid()
        {

        }

        protected virtual void Novo()
        {
            LimpaCampos();
        }
        protected virtual void Salvar()
        {

        }

        protected virtual void Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"SACP", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        protected virtual void Deletar(int id)
        {

        }

        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }

        #endregion


    }
}