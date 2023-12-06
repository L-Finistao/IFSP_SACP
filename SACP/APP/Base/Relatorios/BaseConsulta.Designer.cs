namespace APP.Base.Relatorios
{
    partial class BaseConsulta
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseConsulta));
            imageList = new ImageList(components);
            dataGridViewConsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).BeginInit();
            SuspendLayout();
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "form.png");
            imageList.Images.SetKeyName(1, "search.png");
            // 
            // dataGridViewConsulta
            // 
            dataGridViewConsulta.AllowUserToAddRows = false;
            dataGridViewConsulta.AllowUserToDeleteRows = false;
            dataGridViewConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsulta.Dock = DockStyle.Fill;
            dataGridViewConsulta.Location = new Point(3, 64);
            dataGridViewConsulta.MultiSelect = false;
            dataGridViewConsulta.Name = "dataGridViewConsulta";
            dataGridViewConsulta.ReadOnly = true;
            dataGridViewConsulta.RowHeadersWidth = 51;
            dataGridViewConsulta.RowTemplate.Height = 25;
            dataGridViewConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewConsulta.Size = new Size(548, 451);
            dataGridViewConsulta.TabIndex = 5;
            // 
            // Base
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 518);
            Controls.Add(dataGridViewConsulta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Base";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultas Agendadas";
            Enter += tabPageConsulta_Enter;
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList;
        protected DataGridView dataGridViewConsulta;
    }
}