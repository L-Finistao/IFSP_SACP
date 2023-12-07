namespace APP.Forms.Cadastro
{
    partial class Cad_Agenda
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
            this.Txt_vagas = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.ID_TXT = new ReaLTaiizor.Controls.MaterialLabel();
            this.Combo_Prof = new ReaLTaiizor.Controls.MaterialComboBox();
            this.DateSelect = new System.Windows.Forms.DateTimePicker();
            this.Periodo = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            this.Cadastro = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.Cadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(794, 383);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.Cadastro);
            this.tabPageCadastro.Controls.Add(this.ID_TXT);
            this.tabPageCadastro.Size = new System.Drawing.Size(786, 348);
            this.tabPageCadastro.Controls.SetChildIndex(this.ID_TXT, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.Cadastro, 0);
            // 
            // Txt_vagas
            // 
            this.Txt_vagas.AnimateReadOnly = false;
            this.Txt_vagas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Txt_vagas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Txt_vagas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txt_vagas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_vagas.Depth = 0;
            this.Txt_vagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_vagas.HideSelection = true;
            this.Txt_vagas.Hint = "VAGAS";
            this.Txt_vagas.LeadingIcon = null;
            this.Txt_vagas.Location = new System.Drawing.Point(536, 129);
            this.Txt_vagas.MaxLength = 32767;
            this.Txt_vagas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Txt_vagas.Name = "Txt_vagas";
            this.Txt_vagas.PasswordChar = '\0';
            this.Txt_vagas.PrefixSuffixText = null;
            this.Txt_vagas.ReadOnly = false;
            this.Txt_vagas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_vagas.SelectedText = "";
            this.Txt_vagas.SelectionLength = 0;
            this.Txt_vagas.SelectionStart = 0;
            this.Txt_vagas.ShortcutsEnabled = true;
            this.Txt_vagas.Size = new System.Drawing.Size(200, 48);
            this.Txt_vagas.TabIndex = 11;
            this.Txt_vagas.TabStop = false;
            this.Txt_vagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_vagas.TrailingIcon = null;
            this.Txt_vagas.UseSystemPasswordChar = false;
            // 
            // ID_TXT
            // 
            this.ID_TXT.AutoSize = true;
            this.ID_TXT.Depth = 0;
            this.ID_TXT.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ID_TXT.Location = new System.Drawing.Point(764, 275);
            this.ID_TXT.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.ID_TXT.Name = "ID_TXT";
            this.ID_TXT.Size = new System.Drawing.Size(16, 19);
            this.ID_TXT.TabIndex = 12;
            this.ID_TXT.Text = "ID";
            // 
            // Combo_Prof
            // 
            this.Combo_Prof.AutoResize = false;
            this.Combo_Prof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Combo_Prof.Depth = 0;
            this.Combo_Prof.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Combo_Prof.DropDownHeight = 174;
            this.Combo_Prof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Prof.DropDownWidth = 121;
            this.Combo_Prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Combo_Prof.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Combo_Prof.FormattingEnabled = true;
            this.Combo_Prof.Hint = "Profissional";
            this.Combo_Prof.IntegralHeight = false;
            this.Combo_Prof.ItemHeight = 43;
            this.Combo_Prof.Location = new System.Drawing.Point(30, 41);
            this.Combo_Prof.MaxDropDownItems = 4;
            this.Combo_Prof.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Combo_Prof.Name = "Combo_Prof";
            this.Combo_Prof.Size = new System.Drawing.Size(716, 49);
            this.Combo_Prof.StartIndex = 0;
            this.Combo_Prof.TabIndex = 13;
            // 
            // DateSelect
            // 
            this.DateSelect.CustomFormat = "dd-MM-yyyy";
            this.DateSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateSelect.Location = new System.Drawing.Point(17, 70);
            this.DateSelect.Name = "DateSelect";
            this.DateSelect.Size = new System.Drawing.Size(232, 23);
            this.DateSelect.TabIndex = 15;
            // 
            // Periodo
            // 
            this.Periodo.AutoResize = false;
            this.Periodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Periodo.Depth = 0;
            this.Periodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Periodo.DropDownHeight = 174;
            this.Periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Periodo.DropDownWidth = 121;
            this.Periodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Periodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Periodo.FormattingEnabled = true;
            this.Periodo.Hint = "Periodo";
            this.Periodo.IntegralHeight = false;
            this.Periodo.ItemHeight = 43;
            this.Periodo.Items.AddRange(new object[] {
            "MATUTINO",
            " VESPERTINO",
            " NOTURNO"});
            this.Periodo.Location = new System.Drawing.Point(255, 44);
            this.Periodo.MaxDropDownItems = 4;
            this.Periodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Periodo.Name = "Periodo";
            this.Periodo.Size = new System.Drawing.Size(188, 49);
            this.Periodo.StartIndex = 0;
            this.Periodo.TabIndex = 16;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(30, 19);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(86, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Profissional";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 22);
            this.materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(141, 19);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "Dia do Atendimento";
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.groupBox1);
            this.Cadastro.Controls.Add(this.materialLabel3);
            this.Cadastro.Controls.Add(this.Combo_Prof);
            this.Cadastro.Controls.Add(this.materialLabel1);
            this.Cadastro.Controls.Add(this.Txt_vagas);
            this.Cadastro.Location = new System.Drawing.Point(16, 6);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(763, 285);
            this.Cadastro.TabIndex = 19;
            this.Cadastro.TabStop = false;
            this.Cadastro.Text = "Cadastro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Periodo);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.DateSelect);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Location = new System.Drawing.Point(6, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 183);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horario";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(255, 22);
            this.materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(55, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Periodo";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(536, 118);
            this.materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(127, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "Numero de Vagas";
            // 
            // Cad_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Cad_Agenda";
            this.Text = "Cadastro de Agenda";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.Cadastro.ResumeLayout(false);
            this.Cadastro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel ID_TXT;
        private ReaLTaiizor.Controls.MaterialComboBox Combo_Prof;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit Txt_vagas;
        private DateTimePicker DateSelect;
        private GroupBox Cadastro;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialComboBox Periodo;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private GroupBox groupBox1;
    }
}