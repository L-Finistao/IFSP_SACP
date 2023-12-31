﻿using APP.Base.Cadastro;
using MySql.Data.MySqlClient;
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
    public partial class Cad_Consulta : CadastroBase
    {
        string cs = @"server=localhost;" +
          "uid=root;" +
          "pws=;" +
          "database=ifspsacp";

        private readonly IBaseService<Entity_Usuario> _usuarioService;
        private readonly IBaseService<Entity_Agenda> _agendaService;
        private readonly IBaseService<Entity_Consulta> _ConsultaService;
        private List<Entity_ModelsConsulta>? Consultas;

        public Cad_Consulta(IBaseService<Entity_Agenda> agenda, IBaseService<Entity_Usuario> usuario, IBaseService<Entity_Consulta> consulta)
        {
            _agendaService = agenda;
            _usuarioService = usuario;
            _ConsultaService = consulta;
            InitializeComponent();
            CarregarCombo_M();
            CarregarCombo_P();
        }
        private void CarregarCombo_M()
        {
            CombAgenda.ValueMember = "Id";
            CombAgenda.DisplayMember = "Nome";
            CombAgenda.DataSource = _agendaService.Get<Entity_Agenda>().ToList();

        }
        private void CarregarCombo_P()
        {
            CombPasci.ValueMember = "Id";
            CombPasci.DisplayMember = "Nome";
            CombPasci.DataSource = _usuarioService.Get<Entity_Usuario>().ToList();
        }

        private void PreencheObjeto(Entity_Consulta consult)
        {
            if (int.TryParse(CombAgenda.SelectedValue.ToString(), out var idpas))
            {
                var Agendda = _agendaService.GetById<Entity_Agenda>(idpas);
                consult.Agenda = Agendda;
            }
            try
            {
                if (IsVaga(consult.Agenda.Id))
                {

                    consult.Realizada = CheckRealizado.Checked;
                    consult.Ativa = true;

                    


                    if (int.TryParse(CombPasci.SelectedValue.ToString(), out var sidpas))
                    {
                        var Agendda = _usuarioService.GetById<Entity_Usuario>(sidpas);
                        consult.Paciente = Agendda;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Limite de Pacientes Atingido", @"SACPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        var Consultas = _ConsultaService.GetById<Entity_Consulta>(id);
                        PreencheObjeto(Consultas);
                        Consultas = _ConsultaService.Update<Entity_Consulta, Entity_Consulta, ValidaConsulta>(Consultas);
                    }
                }
                else
                {
                    var Consultas = new Entity_Consulta();
                    PreencheObjeto(Consultas);
                    if (IsVaga(Consultas.Agenda.Id))
                    {
                        _ConsultaService.Add<Entity_Consulta, Entity_Consulta, ValidaConsulta>(Consultas);

                    } else
                    {
                        MessageBox.Show("Limite de Pacientes Atingido", @"SACPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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
                _ConsultaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SACPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            var Agedaa = _ConsultaService.Get<Entity_ModelsConsulta>()
            .Where(c => c.Ativa == true).Where(x => x.Realizada == false)
            .ToList();
            dataGridViewConsulta.DataSource = Agedaa;
            dataGridViewConsulta.Columns["DataAgenda"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            dataGridViewConsulta.Columns["Ativa"]!.Visible = false;
            dataGridViewConsulta.Columns["Nome_Medico"]!.Visible = false;
            dataGridViewConsulta.Columns["Vagas"]!.Visible = false;
            dataGridViewConsulta.Columns["Especialidade_Medico"]!.Visible = false;
            dataGridViewConsulta.Columns["IdMedico"]!.Visible = false;
            dataGridViewConsulta.Columns["IdPaciente"]!.Visible = false;
        }



        protected override void CarregaRegistro(DataGridViewRow? linha)
        {

            TXT_ID.Text = linha?.Cells["Id"].Value.ToString();
            // CombAgenda.SelectedValue = linha?.Cells["IdMedico"].Value;
            CombPasci.SelectedValue = linha?.Cells["IdPaciente"].Value;
            string valorString = linha?.Cells["Realizada"].Value.ToString();

            if (bool.TryParse(valorString, out bool valorBooleano))
            {
                // A conversão foi bem-sucedida
                CheckRealizado.Checked = valorBooleano;
            }
            else
            {
                // Se a conversão falhar, você pode lidar com isso de acordo com a lógica do seu programa
                // Por exemplo, atribuir um valor padrão ou exibir uma mensagem de erro
                CheckRealizado.Checked = false; // ou true, dependendo da lógica do seu programa
            }
            //            ComboAgenda.SelectedValue = linha?.Cells["Agenda"].Value;
            //          Desc_TEXT.Text = linha?.Cells["Descricao"].Value.ToString();
            //        Comb_Cid.SelectedValue = linha?.Cells["Cid"].Value;

        }

        private void tabPageCadastro_Click(object sender, EventArgs e)
        {

        }

        private int GetVagas(int selectedAgendaId)
        {
            var agenda = _agendaService.GetById<Entity_Agenda>(selectedAgendaId);

            var consultas = _ConsultaService.Get<Entity_Consulta>().Where(x => x.Agenda.Id == selectedAgendaId).Count();
            return consultas;
        }

        private bool IsVaga(int selectAgendaID)
        {
            var agenda = _agendaService.GetById<Entity_Agenda>(selectAgendaID);

            return GetVagas(selectAgendaID) < agenda.Vagas ? true : false;
        }
 
    }
}
