﻿using APP.Base.Cadastro;
using APP.Models;
using Domain.Base;
using Domain.Entities;
using Service.Services;
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

namespace SACP.APP.Cadastros
{
    public partial class Cadastro_Procedimento : CadastroBase
    {
        private readonly IBaseService<Cid> _cidService; //_produtoService;
        private readonly IBaseService<Procedimento> _procedimentoService; //_grupoService;

        private List<ProcedimentoModels>? produtos;

        public Cadastro_Procedimento(IBaseService<Cid> cidService, IBaseService<Procedimento> procedimentoService)
        {
            _cidService = cidService;
            _procedimentoService = procedimentoService;
            InitializeComponent();
           // CarregarCombo();
        }

        private void CarregarCombo()
        {
            Comb_CID.ValueMember = "Id";
            Comb_CID.DisplayMember = "Nome";
            Comb_CID.DataSource = _cidService.Get<Cid>().ToList();
        }

        private void PreencheObjeto(Procedimento produto)
        {
            /*
            produto.Nome = txtNome.Text;
            if (float.TryParse(txtPreco.Text, out var preco))
            {
                produto.Preco = preco;
            }
            */
            /*
            if (DateTime.TryParse(txtDataCompra.Text, out var dataCompra))
            {
                produto.DataCompra = dataCompra;
            }
            */
            //produto.UnidadeVenda = txtUnidadeVenda.Text;

            if (int.TryParse(Comb_CID.SelectedValue.ToString(), out var idCid))
            {
                var cid = _cidService.GetById<Cid>(idCid);
                produto.Cid = cid;
                //_produtoService.AttachObject(grupo);
            }
        }

        protected override void Salvar()
        {
            /*
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var produto = _produtoService.GetById<Produto>(id);
                        PreencheObjeto(produto);
                        produto = _produtoService.Update<Produto, Produto, ProdutoValidator>(produto);
                    }
                }
                else
                {
                    var produto = new Produto();
                    PreencheObjeto(produto);
                    _produtoService.Add<Produto, Produto, ProdutoValidator>(produto);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
             */
        }

        protected override void Deletar(int id)
        {
            /*
            try
            {
                _produtoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            */
        }

        protected override void CarregaGrid()
        {
            /*
            produtos = _produtoService.Get<ProdutoModel>(new[] { "Grupo" }).ToList();
            dataGridViewConsulta.DataSource = produtos;
            dataGridViewConsulta.Columns["IdGrupo"]!.Visible = false;
            */
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            /*
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtUnidadeVenda.Text = linha?.Cells["UnidadeVenda"].Value.ToString();
            txtPreco.Text = linha?.Cells["Preco"].Value.ToString();
            cboGrupo.SelectedValue = linha?.Cells["IdGrupo"].Value;
            txtDataCompra.Text = DateTime.TryParse(linha?.Cells["DataCompra"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";
            */

        }
           

    }
}