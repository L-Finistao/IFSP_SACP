using APP.Models;
using Domain.Base;
using Domain.Entities;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Base.Registro
{
    public partial class Agenda_registra : MaterialForm
    {

        private readonly IBaseService<Entity_Usuario_Medico> _usuariomedicoService;
        private readonly IBaseService<Entity_Agenda> _agendaService;
        private List<Entity_ModelsAgenda>? Agendas;

        public Agenda_registra(IBaseService<Entity_Usuario_Medico> usuariomedico, IBaseService<Entity_Agenda> agenda)
        {
            _usuariomedicoService = usuariomedico;
            _agendaService = agenda;
            InitializeComponent();
        }

        private void Entrer_Consulta(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        protected void CarregaGrid()
        {
            Agendas = _agendaService.Get<Entity_ModelsAgenda>().ToList();
            dataGridViewConsulta.DataSource = Agendas;
            dataGridViewConsulta.Columns["Nome_Medico"]!.Visible = false;
        }

      
            /*   if (dataGridView1.SelectedRows.Count > 0)
               {

                   isAlteracao = true;
                   var item = dataGridView1.SelectedRows[0];
                   TxtID.Text = item.Cells["id"].Value.ToString();
                   txtMatricula.Text = item.Cells["matricula"].Value.ToString();
                   mmtbDataNascimento.Text = item.Cells["dt_nascimento"].Value.ToString();
                   txtNome.Text = item.Cells["nome"].Value.ToString();
                   txtEndereco.Text = item.Cells["endereco"].Value.ToString();
                   txtBairro.Text = item.Cells["bairro"].Value.ToString();
                   txtCidade.Text = item.Cells["cidade"].Value.ToString();
                   cboEstados.Text = item.Cells["estado"].Value.ToString();
                   txtSenha.Text = item.Cells["senha"].Value.ToString();
                   materialTabControl1.SelectedIndex = 0;
                   txtMatricula.Focus();
               }
               else
               {
                   MessageBox.Show("Selecione Algum Aluno", "IFSP", MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
               }
            */

        private void Edit()
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"IFSP Store", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question)
               == DialogResult.Yes)
            {

            }
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente cancelar?", @"IFSP Store", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
                {

                }
            } else
            {
                MessageBox.Show("Selecione Algum Aluno", "IFSP", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            Edit();
        }
    }
}
