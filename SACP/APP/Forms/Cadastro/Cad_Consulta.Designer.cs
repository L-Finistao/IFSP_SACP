namespace APP.Forms.Cadastro
{
    partial class Cad_Consulta
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
            CombAgenda = new ReaLTaiizor.Controls.MaterialComboBox();
            CombPasci = new ReaLTaiizor.Controls.MaterialComboBox();
            TXT_ID = new ReaLTaiizor.Controls.MaterialLabel();
            CheckRealizado = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(373, 317);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(CheckRealizado);
            tabPageCadastro.Controls.Add(TXT_ID);
            tabPageCadastro.Controls.Add(CombPasci);
            tabPageCadastro.Controls.Add(CombAgenda);
            tabPageCadastro.Size = new Size(365, 282);
            tabPageCadastro.Click += tabPageCadastro_Click;
            tabPageCadastro.Controls.SetChildIndex(CombAgenda, 0);
            tabPageCadastro.Controls.SetChildIndex(CombPasci, 0);
            tabPageCadastro.Controls.SetChildIndex(TXT_ID, 0);
            tabPageCadastro.Controls.SetChildIndex(CheckRealizado, 0);
            // 
            // CombAgenda
            // 
            CombAgenda.AutoResize = false;
            CombAgenda.BackColor = Color.FromArgb(255, 255, 255);
            CombAgenda.Depth = 0;
            CombAgenda.DrawMode = DrawMode.OwnerDrawVariable;
            CombAgenda.DropDownHeight = 174;
            CombAgenda.DropDownStyle = ComboBoxStyle.DropDownList;
            CombAgenda.DropDownWidth = 121;
            CombAgenda.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CombAgenda.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CombAgenda.FormattingEnabled = true;
            CombAgenda.Hint = "Agenda";
            CombAgenda.IntegralHeight = false;
            CombAgenda.ItemHeight = 43;
            CombAgenda.Location = new Point(20, 32);
            CombAgenda.MaxDropDownItems = 4;
            CombAgenda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CombAgenda.Name = "CombAgenda";
            CombAgenda.Size = new Size(335, 49);
            CombAgenda.StartIndex = 0;
            CombAgenda.TabIndex = 11;
            // 
            // CombPasci
            // 
            CombPasci.AutoResize = false;
            CombPasci.BackColor = Color.FromArgb(255, 255, 255);
            CombPasci.Depth = 0;
            CombPasci.DrawMode = DrawMode.OwnerDrawVariable;
            CombPasci.DropDownHeight = 174;
            CombPasci.DropDownStyle = ComboBoxStyle.DropDownList;
            CombPasci.DropDownWidth = 121;
            CombPasci.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CombPasci.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CombPasci.FormattingEnabled = true;
            CombPasci.Hint = "Paciente";
            CombPasci.IntegralHeight = false;
            CombPasci.ItemHeight = 43;
            CombPasci.Location = new Point(20, 87);
            CombPasci.MaxDropDownItems = 4;
            CombPasci.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CombPasci.Name = "CombPasci";
            CombPasci.Size = new Size(335, 49);
            CombPasci.StartIndex = 0;
            CombPasci.TabIndex = 12;
            // 
            // TXT_ID
            // 
            TXT_ID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TXT_ID.AutoSize = true;
            TXT_ID.Depth = 0;
            TXT_ID.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_ID.Location = new Point(346, 3);
            TXT_ID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TXT_ID.Name = "TXT_ID";
            TXT_ID.Size = new Size(16, 19);
            TXT_ID.TabIndex = 14;
            TXT_ID.Text = "ID";
            // 
            // CheckRealizado
            // 
            CheckRealizado.AutoSize = true;
            CheckRealizado.Depth = 0;
            CheckRealizado.Location = new Point(20, 148);
            CheckRealizado.Margin = new Padding(0);
            CheckRealizado.MouseLocation = new Point(-1, -1);
            CheckRealizado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CheckRealizado.Name = "CheckRealizado";
            CheckRealizado.ReadOnly = false;
            CheckRealizado.Ripple = true;
            CheckRealizado.Size = new Size(105, 37);
            CheckRealizado.TabIndex = 15;
            CheckRealizado.Text = "Realizado";
            CheckRealizado.UseAccentColor = false;
            CheckRealizado.UseVisualStyleBackColor = true;
            // 
            // Cad_Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 384);
            Location = new Point(0, 0);
            Name = "Cad_Consulta";
            Text = "Agendamento de Consulta";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox CombPasci;
        private ReaLTaiizor.Controls.MaterialComboBox CombAgenda;
        private ReaLTaiizor.Controls.MaterialLabel TXT_ID;
        private ReaLTaiizor.Controls.MaterialCheckBox CheckRealizado;
    }
}