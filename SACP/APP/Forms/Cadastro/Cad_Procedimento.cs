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
using Microsoft.EntityFrameworkCore; 
namespace APP.Forms.Cadastro
{
    public partial class Cad_Procedimento : CadastroBase
    {

        private readonly IBaseService<Entity_Usuario> _PacienteService;
        private readonly IBaseService<Entity_Usuario_Medico> _MedicoService;
        private readonly IBaseService<Entity_Procedimento> _ProcedimentoService;

        private List<Entity_ModelsProcedimento>? procedimentos;

        public Cad_Procedimento(IBaseService<Entity_Usuario> pac, IBaseService<Entity_Usuario_Medico> med, IBaseService<Entity_Procedimento> pro )
        {
            _PacienteService = pac;
            _MedicoService = med;
            _ProcedimentoService = pro;
            InitializeComponent();
            CarregarCombo_M();
            CarregarCombo_P();
        }

        private void CarregarCombo_M()
        {
            Comb_Medico.ValueMember = "Id";
            Comb_Medico.DisplayMember = "Nome";
            Comb_Medico.DataSource = _MedicoService.Get<Entity_Usuario_Medico>().ToList();

        }
        private void CarregarCombo_P()
        {
            Comb_Paciente.ValueMember = "Id";
            Comb_Paciente.DisplayMember = "Nome";
            Comb_Paciente.DataSource = _PacienteService.Get<Entity_Usuario>().ToList();
        }

        private void PreencheObjeto(Entity_Procedimento procediment)
        {
            procediment.Cid = Comb_Cid.SelectedItem.ToString();

            procediment.Descricao = Desc_TEXT.Text;

            procediment.Data_Agendado = Datenas.Value.Date;
            if (int.TryParse(Comb_Paciente.SelectedValue.ToString(), out var idpas))
            {
                var Paciente = _PacienteService.GetById<Entity_Usuario>(idpas);
                procediment.Id_Paciente = Paciente;
            }

            if (int.TryParse(Comb_Medico.SelectedValue.ToString(), out var idmedico))
            {
                var Paciente = _MedicoService.GetById<Entity_Usuario_Medico>(idmedico);
                procediment.Id_Medico = Paciente;
            }
            


        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(TXT_ID.Text, out var id))
                    {
                        var procedimentoo = _ProcedimentoService.GetById<Entity_Procedimento>(id);
                        PreencheObjeto(procedimentoo);
                        procedimentoo = _ProcedimentoService.Update<Entity_Procedimento, Entity_Procedimento, ValidaProcedimento>(procedimentoo);
                    }
                }
                else
                {
                    var procedimentoo = new Entity_Procedimento();
                    PreencheObjeto(procedimentoo);
                    _ProcedimentoService.Add<Entity_Procedimento, Entity_Procedimento, ValidaProcedimento>(procedimentoo);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SACPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void Deletar(int id)
        {
            try
            {
                _ProcedimentoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SACPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {

            procedimentos = _ProcedimentoService.Get<Entity_ModelsProcedimento>().ToList();
            dataGridViewConsulta.DataSource = procedimentos;
            dataGridViewConsulta.Columns["Cid"]!.Visible = false;

        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {

            TXT_ID.Text = linha?.Cells["Id"].Value.ToString();
            Desc_TEXT.Text = linha?.Cells["Descricao"].Value.ToString();
            Comb_Medico.SelectedValue = linha?.Cells["Id_MedicoId"].Value;
            Comb_Paciente.SelectedValue = linha?.Cells["Id_PacienteId"].Value;
            Comb_Cid.SelectedValue = linha?.Cells["Cid"].Value;
          
            if (DateTime.TryParse(linha?.Cells["Data_Agendado"].Value.ToString(), out var data))
            {
                Datenas.Value = data;
            }
        }


    }
}
