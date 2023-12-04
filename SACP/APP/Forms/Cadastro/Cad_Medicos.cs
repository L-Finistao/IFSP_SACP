using APP.Base.Cadastro;
using APP.Models;
using Domain.Base;
using Domain.Entities;
using Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Forms.Cadastro
{
    public partial class Cad_Medicos : CadastroBase
    {
        private readonly IBaseService<Entity_Usuario_Medico> _usuarioService;

        private List<Entity_ModelsUsuarioMedico>? _usuarioList;

        public Cad_Medicos(IBaseService<Entity_Usuario_Medico> usuario)
        {
            _usuarioService = usuario;
            InitializeComponent();
        }

        private void PreencheObjeto(Entity_Usuario_Medico usuario)
        {
            usuario.Nome = Txt_Nome.Text;
            usuario.Endereco = Txt_End.Text;
            usuario.Dt_Nasci = Datanas.Value.Date;
            usuario.Telefone_01 = Txt_Tell01.Text;
            usuario.Telefone_02 = Txt_Tell2.Text;
            usuario.Vinculo = Txt_Vinc.Text;
            if (CombEspec.SelectedItem != null)
            {
                usuario.Especialidade = CombEspec.SelectedItem.ToString();

            }
            usuario.Codigo = Txt_Codigo.Text;
        }
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(TXT_ID.Text, out var id))
                    {
                        var user = _usuarioService.GetById<Entity_Usuario_Medico>(id);
                        PreencheObjeto(user);
                        user = _usuarioService.Update<Entity_Usuario_Medico, Entity_Usuario_Medico, ValidaMedico>(user);
                    }
                }
                else
                {
                    var user = new Entity_Usuario_Medico();
                    PreencheObjeto(user);
                    _usuarioService.Add<Entity_Usuario_Medico, Entity_Usuario_Medico, ValidaMedico>(user);

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
                MessageBox.Show(ex.Message, @"SACP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _usuarioList = _usuarioService.Get<Entity_ModelsUsuarioMedico>().ToList();
            dataGridViewConsulta.DataSource = _usuarioList;
            dataGridViewConsulta.Columns["Id"]!.Visible = true;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            TXT_ID.Text = linha?.Cells["Id"].Value.ToString();
            Txt_Nome.Text = linha?.Cells["Nome"].Value.ToString();
            Txt_End.Text = linha?.Cells["Endereco"].Value.ToString();
            Txt_Vinc.Text = linha?.Cells["Vinculo"].Value.ToString();
            Txt_Tell01.Text = linha?.Cells["Telefone_01"].Value.ToString();
            Txt_Tell2.Text = linha?.Cells["Telefone_02"].Value.ToString();
            Txt_Codigo.Text = linha?.Cells["Codigo"].Value.ToString();
            CombEspec.SelectedValue = linha?.Cells["Especialidade"].Value.ToString();
            if (DateTime.TryParse(linha?.Cells["Dt_Nasci"].Value.ToString(), out var data))
            {
                Datanas.Value = data;
            }
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
