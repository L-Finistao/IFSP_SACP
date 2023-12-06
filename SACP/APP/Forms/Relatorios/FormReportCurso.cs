using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf.Graphics;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Pdf.Tables;
using System.Diagnostics;
using System.Drawing.Printing;
using Domain.Entities;
using Domain.Base;

namespace SGA
{
    public partial class FormReportCurso : MaterialForm
    {
        private readonly IBaseService<Entity_Usuario> _usuarioService;


        string cs = @"server=localhost;" +
                 "uid=root;" +
                 "pws=;" +
                 "database=ifspsacp";
        public FormReportCurso(IBaseService<Entity_Usuario> usuario)
        {
            _usuarioService = usuario;
            InitializeComponent();
            Carrega_Impressora();
            CarregarCombo_M();
        }

        private void CarregarCombo_M()
        {
            cboTipo.ValueMember = "Id";
            cboTipo.DisplayMember = "Nome";
            cboTipo.DataSource = _usuarioService.Get<Entity_Usuario>().ToList();

        }

        private void Carrega_Impressora()
        {
            foreach (string print in PrinterSettings.InstalledPrinters)
            {
                CboImpressora.Items.Add(print);
            }
            CboImpressora.SelectedIndex = 0;
        }


        private void Monta_Relatorio()
        {

            var con = new MySqlConnection(cs);
            con.Open();

            string sql = "SELECT agenda.Nome AS NomeAgenda, agenda.DataAgenda, usuario.Nome AS NomeUsuario, usuario.Vinculo " +
               "FROM consulta " +
               "LEFT JOIN agenda ON consulta.AgendaId = agenda.Id " +
               "LEFT JOIN usuario ON consulta.PacienteId = usuario.id " +
               "WHERE usuario.Nome = @userID";


            var sqlad = new MySqlDataAdapter();
            sqlad.SelectCommand = new MySqlCommand(sql, con);
            sqlad.SelectCommand.Parameters.AddWithValue("@userID", cboTipo.Text);
            

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

            page.Canvas.DrawString("Historico de Paciente", font, brush, page.Canvas.ClientSize.Width / 2, y, format);

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

            doc.SaveToFile("HistoricoPaciente.pdf");


        }



        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Monta_Relatorio();
            Process.Start(new ProcessStartInfo { FileName = @"HistoricoPaciente.pdf", UseShellExecute = true });

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var con = new MySqlConnection(cs);
            con.Open();

            string sql = "SELECT agenda.Nome AS NomeAgenda, agenda.DataAgenda, usuario.Nome AS NomeUsuario, usuario.Vinculo " +
               "FROM consulta " +
               "LEFT JOIN agenda ON consulta.AgendaId = agenda.Id " +
               "LEFT JOIN usuario ON consulta.PacienteId = usuario.id " +
               "WHERE usuario.id = @userID";


            var sqlad = new MySqlDataAdapter();
            sqlad.SelectCommand = new MySqlCommand(sql, con);
            sqlad.SelectCommand.Parameters.AddWithValue("@userID", cboTipo.Text);


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

            page.Canvas.DrawString("Historico de Paciente", font, brush, page.Canvas.ClientSize.Width / 2, y, format);

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

            doc.LoadFromFile("HistoricoPaciente.pdf");
            doc.PrintSettings.PrinterName = CboImpressora.Text;
            doc.Print();
        }
    }
}

