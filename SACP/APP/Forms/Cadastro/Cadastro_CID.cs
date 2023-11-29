using APP.Base.Cadastro;
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

    public partial class Cadastro_CID : CadastroBase
    {
        private readonly IBaseService<Cid> _cid;
        private List<Cid> _cidList;
        public Cadastro_CID(IBaseService<Cid> cid)
        {
            _cid = cid;
            InitializeComponent();
        }

        private void PreencheObjeto(Cid cid)
        {
            cid.Codigo_CID = CID_Text.Text;
            cid.Descricao = Desc_Text.Text;

        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(ID_Text.Text, out var id))
                    {
                        var Cid = _cid.GetById<Cid>(id);
                        PreencheObjeto(Cid);
                        Cid = _cid.Update<Cid, Cid, CidValidator>(Cid);
                    }
                }
                else
                {
                    var Cid = new Cid();
                    PreencheObjeto(Cid);
                    _cid.Add<Cid, Cid, CidValidator>(Cid);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP SACP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _cid.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            _cidList = _cid.Get<Cid>().ToList();
            dataGridViewConsulta.DataSource = _cidList;
            dataGridViewConsulta.Columns["Codigo_CID"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            ID_Text.Text = linha?.Cells["Id"].Value.ToString();
            CID_Text.Text = linha?.Cells["Codigo_CID"].Value.ToString();
            Desc_Text.Text = linha?.Cells["Descricao"].Value.ToString();
        }

        private void materialTextBoxEdit3_Click(object sender, EventArgs e)
        {

        }
    }
}
