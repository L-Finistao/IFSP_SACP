namespace APP.Base.Registro
{
    partial class Agenda_registra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewConsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewConsulta
            // 
            dataGridViewConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsulta.Dock = DockStyle.Fill;
            dataGridViewConsulta.Location = new Point(3, 64);
            dataGridViewConsulta.Margin = new Padding(7);
            dataGridViewConsulta.Name = "dataGridViewConsulta";
            dataGridViewConsulta.RowTemplate.Height = 25;
            dataGridViewConsulta.Size = new Size(794, 383);
            dataGridViewConsulta.TabIndex = 0;
            // 
            // Agenda_registra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewConsulta);
            Name = "Agenda_registra";
            Text = "Consulta";
            Enter += Entrer_Consulta;
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewConsulta;
    }
}