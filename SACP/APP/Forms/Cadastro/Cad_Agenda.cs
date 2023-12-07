using APP.Base.Cadastro;
using APP.infra;
using APP.Models;
using Domain.Base;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Extension;
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
    public partial class Cad_Agenda : CadastroBase
    {

        private readonly IBaseService<Entity_Usuario_Medico> _usuariomedicoService;
        private readonly IBaseService<Entity_Agenda> _agendaService;

        private List<Entity_ModelsAgenda>? Agendas;


        public Cad_Agenda(IBaseService<Entity_Usuario_Medico> usuariomedico, IBaseService<Entity_Agenda> agenda)
        {
            _usuariomedicoService = usuariomedico;
            _agendaService = agenda;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            Combo_Prof.ValueMember = "Id";
            Combo_Prof.DisplayMember = "Nome";
            Combo_Prof.DataSource = _usuariomedicoService.Get<Entity_Usuario_Medico>().ToList();
        }

        private void PreencheObjeto(Entity_Agenda agenda)
        {
            agenda.Vagas = int.Parse(Txt_vagas.Text);
            agenda.DataAgenda = DateSelect.Value;
            

                agenda.Periodo = Periodo.SelectedItem.ToString();
         
            if (int.TryParse(Combo_Prof.SelectedValue.ToString(), out var idGrupo))
            {
                var grupo = _usuariomedicoService.GetById<Entity_Usuario_Medico>(idGrupo);
                agenda.IdMedico = grupo;
                agenda.Nome = grupo.Nome + " | " + grupo.Especialidade + " | " + agenda.Periodo +" | " + agenda.DataAgenda.Value.ToString("dd-MM-yyyy");
                _usuariomedicoService.AttachObject(grupo);
            }
        }
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(ID_TXT.Text, out var id))
                    {
                        var produto = _agendaService.GetById<Entity_Agenda>(id);
                        PreencheObjeto(produto);
                        produto = _agendaService.Update<Entity_Agenda, Entity_Agenda, ValidaAgenda>(produto);
                    }
                }
                else
                {
                    var produto = new Entity_Agenda();
                    PreencheObjeto(produto);
                    if (IsValido(produto.DataAgenda, produto.IdMedico.Id, produto.Periodo))
                    {
                        _agendaService.Add<Entity_Agenda, Entity_Agenda, ValidaAgenda>(produto);
                    } else
                    {
                        MessageBox.Show("Já Existe Uma Agenda Aberta Para esse Horario / Dia / Periodo", @"SACPS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

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
                _agendaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SACP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            var Agedaa = _agendaService.Get<Entity_ModelsAgenda>().ToList();
            dataGridViewConsulta.DataSource = Agedaa;
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
        }

        protected override void AltEdit()
        {
            Editar();
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            //Periodo.SelectedValue = linha?.Cells["Periodo"].Value.ToString();
//
            ID_TXT.Text = linha?.Cells["Id"].Value.ToString();
            Txt_vagas.Text = linha?.Cells["Vagas"].Value.ToString();
          //  Combo_Prof.SelectedValue = linha?.Cells["IdMedicoId"].Value;
            

        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            TFormlario? cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.Show();
            }
        }


        private bool IsValido(DateTime? dia, int IdMedico, String? Periodo)
        {

            var valid = true;
            var agenda = _agendaService.Get<Entity_Agenda>().Where(a => a.Periodo == Periodo && a.DataAgenda == dia && a.IdMedico.Id == IdMedico).Count();
            return agenda > 0 ? false : true;
        }

  



    }
}
