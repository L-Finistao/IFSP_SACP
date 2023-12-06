using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;
using APP.Models;
using Domain.Base;
using Domain.Entities;
using APP.Base.Cadastro;
using Service.Validators;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA
{
    public partial class FormReport : MaterialForm
    {
        string cs = @"server=localhost;" +
          "uid=root;" +
          "pws=;" +
          "database=ifspsacp";
        private readonly IBaseService<Entity_Usuario> _usuarioService;
        private readonly IBaseService<Entity_Agenda> _agendaService;
        private readonly IBaseService<Entity_Consulta> _ConsultaService;
        private List<Entity_ModelsConsulta>? Consultas;


        public FormReport(IBaseService<Entity_Agenda> agenda, IBaseService<Entity_Usuario> usuario, IBaseService<Entity_Consulta> consulta)
        {
            _agendaService = agenda;
            _usuarioService = usuario;
            _ConsultaService = consulta;
            InitializeComponent();
            Carrega_Impressora();
            CarregarCombo_M();
        }

        private void CarregarCombo_M()
        {
            cboAgenda.ValueMember = "Id";
            cboAgenda.DisplayMember = "Nome";
            cboAgenda.DataSource = _agendaService.Get<Entity_Agenda>().ToList();

        }

        private void Carrega_Impressora()
        {
            foreach(string print in PrinterSettings.InstalledPrinters)
            {
                CboImpressora.Items.Add(print);
            }
            CboImpressora.SelectedIndex= 0;
        }

      

        private void Monta_Relatorio()
        {

            var con = new MySqlConnection(cs);
            con.Open();
            //
            //var sql = "SELECT agenda.Nome AS NomeAgenda, agenda.DataAgenda, usuario.Nome AS NomeUsuario, usuario.Vinculo FROM consulta LEFT JOIN agenda ON consulta.AgendaId = agenda.Id    LEFT JOIN usuario ON consulta.PacienteId = usuario.id LIMIT 0, 25";

            // Supondo que cboAgenda.SelectedValue fornece o ID da agenda selecionada
            string sql = "SELECT agenda.Nome AS NomeAgenda, agenda.DataAgenda, usuario.Nome AS NomeUsuario, usuario.Vinculo " +
                          "FROM consulta " +
                          "LEFT JOIN agenda ON consulta.AgendaId = agenda.Id " +
                          "LEFT JOIN usuario ON consulta.PacienteId = usuario.id " +
                          "WHERE consulta.Realizada = 0 and ";

            // Verifica se há uma agenda selecionada
            if (cboAgenda.SelectedValue != null && int.TryParse(cboAgenda.SelectedValue.ToString(), out var selectedAgendaId))
            {
                // Adiciona a condição WHERE para a agenda selecionada
                sql += $"consulta.AgendaId = {selectedAgendaId} ";
            }
            else
            {
                // Se não houver uma agenda selecionada, use a condição padrão
                sql += "consulta.AgendaId = agenda.Id ";
            }

            // Completa a consulta com o restante do JOIN
            sql += "LIMIT 0, 25";


            var sqlad = new MySqlDataAdapter();
            sqlad.SelectCommand = new MySqlCommand(sql, con);

        

            var dt = new DataTable();
            sqlad.Fill(dt);
            con.Close();

            //Iniico Geração PDF

            PdfDocument doc = new PdfDocument();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            float y = 20;
            PdfBrush brush = PdfBrushes.Black;
            PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("Ariel", 16f, FontStyle.Bold));
            PdfStringFormat format = new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("FAA - FICHA DE ATENDIMENTO AMBULATORIAL", font, brush, page.Canvas.ClientSize.Width / 2, y, format);

            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brush, 0.75f);
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            table.Style.ShowHeader = true;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.CadetBlue;
            table.DataSource = dt;
            foreach (PdfColumn col in table.Columns)
            {
                col.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }

            table.Draw(page, new PointF(1, y + font.Size + 10));

            // Adiciona a coluna de assinatura



            doc.SaveToFile("Relatorio_Alunos.pdf");


        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            //Monta_Relatorio();
            Monta_Relatorio();
            Process.Start(new ProcessStartInfo { FileName = @"Relatorio_Alunos.pdf", UseShellExecute = true });


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var con = new MySqlConnection(cs);
            con.Open();

            var sql = "SELECT agenda.Nome AS NomeAgenda, agenda.DataAgenda, usuario.Nome AS NomeUsuario, usuario.Vinculo FROM consulta LEFT JOIN agenda ON consulta.AgendaId = agenda.Id    LEFT JOIN usuario ON consulta.PacienteId = usuario.id LIMIT 0, 25";




            var sqlad = new MySqlDataAdapter();
            sqlad.SelectCommand = new MySqlCommand(sql, con);



            var dt = new DataTable();
            sqlad.Fill(dt);
            con.Close();


            //Iniico Geração PDF

            PdfDocument doc = new PdfDocument();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            float y = 20;
            PdfBrush brush = PdfBrushes.Black;
            PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("Ariel", 16f, FontStyle.Bold));
            PdfStringFormat format = new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("Relatorio de Cursos", font, brush, page.Canvas.ClientSize.Width / 2, y, format);

            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brush, 0.75f);
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            table.Style.ShowHeader = true;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.CadetBlue;
            table.DataSource = dt;
            foreach (PdfColumn col in table.Columns)
            {
                col.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }

            table.Draw(page, new PointF(1, y + font.Size + 10));

            // Adiciona a coluna de assinatura



            doc.SaveToFile("Relatorio_Alunos.pdf");

            doc.PrintSettings.PrinterName = CboImpressora.Text;

            doc.LoadFromFile(@"Relatorio_Alunos.pdf");
            doc.PrintSettings.PrintController = new StandardPrintController();
            doc.Print();



        }

        private void CboImpressora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        static DataTable ConvertListToDataTable<T>(List<T> list)
        {
            DataTable table = new DataTable();

            // Obtém as propriedades do tipo T
            var properties = typeof(T).GetProperties();

            // Adiciona colunas ao DataTable
            foreach (var property in properties)
            {
                Type propertyType = property.PropertyType;

                // Verifica se a propriedade é nullable
                if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    // Se for nullable, pega o tipo subjacente
                    propertyType = Nullable.GetUnderlyingType(propertyType);
                }

                table.Columns.Add(property.Name, propertyType);
            }

            // Adiciona linhas ao DataTable
            foreach (var item in list)
            {
                DataRow row = table.NewRow();
                foreach (var property in properties)
                {
                    object value = property.GetValue(item);

                    // Se o valor for nulo, atribui DBNull.Value
                    row[property.Name] = value ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }

    }
}
