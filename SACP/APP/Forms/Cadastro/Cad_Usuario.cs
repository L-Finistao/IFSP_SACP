using APP.Base.Cadastro;
using APP.Models;
using Domain.Base;
using Domain.Entities;
using Service.Validators;

namespace APP.Base.Registro
{
    public partial class Cad_Usuario : CadastroBase
    {

        private readonly IBaseService<Entity_Usuario> _usuarioService;

        private List<Entity_ModelsUsuario>? _usuarioList;

        public Cad_Usuario(IBaseService<Entity_Usuario> usuario)
        {
            _usuarioService = usuario;
            InitializeComponent();
        }


        private void PreencheObjeto(Entity_Usuario usuario)
        {
            usuario.Nome = Txt_Nome.Text;
            usuario.Endereco = Txt_End.Text;
            usuario.Dt_Nasci = Datanas.Value.Date;
            usuario.Telefone_01 = Txt_Tell01.Text;
            usuario.Telefone_02 = Txt_Tell2.Text;
            usuario.Vinculo = Txt_Vinc.Text;
        }
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(TXT_ID.Text, out var id))
                    {
                        var user = _usuarioService.GetById<Entity_Usuario>(id);
                        PreencheObjeto(user);
                        user = _usuarioService.Update<Entity_Usuario, Entity_Usuario, ValidaUsuario>(user);
                    }
                }
                else
                {
                    var user = new Entity_Usuario();
                    PreencheObjeto(user);
                    _usuarioService.Add<Entity_Usuario, Entity_Usuario, ValidaUsuario>(user);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SACP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void Deletar(int id)
        {
            try
            {
                _usuarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _usuarioList = _usuarioService.Get<Entity_ModelsUsuario>().ToList();
            dataGridViewConsulta.DataSource = _usuarioList;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            TXT_ID.Text = linha?.Cells["Id"].Value.ToString();
            Txt_Nome.Text = linha?.Cells["Nome"].Value.ToString();
            Txt_End.Text = linha?.Cells["Endereco"].Value.ToString();
            Txt_Vinc.Text = linha?.Cells["Vinculo"].Value.ToString();
            Txt_Tell01.Text = linha?.Cells["Telefone_01"].Value.ToString();
            Txt_Tell2.Text = linha?.Cells["Telefone_02"].Value.ToString();
            if (DateTime.TryParse(linha?.Cells["Dt_Nasci"].Value.ToString(), out var data))
            {
                Datanas.Value = data;
            }
        }

    }
}
