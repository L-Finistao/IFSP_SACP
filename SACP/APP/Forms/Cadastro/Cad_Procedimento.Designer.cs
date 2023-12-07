namespace APP.Forms.Cadastro
{
    partial class Cad_Procedimento
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
            this.Comb_Cid = new ReaLTaiizor.Controls.MaterialComboBox();
            this.Datenas = new ReaLTaiizor.Controls.PoisonDateTime();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.Comb_Paciente = new ReaLTaiizor.Controls.MaterialComboBox();
            this.Comb_Medico = new ReaLTaiizor.Controls.MaterialComboBox();
            this.TXT_ID = new ReaLTaiizor.Controls.MaterialLabel();
            this.Desc_TEXT = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(859, 479);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.groupBox2);
            this.tabPageCadastro.Controls.Add(this.groupBox1);
            this.tabPageCadastro.Controls.Add(this.TXT_ID);
            this.tabPageCadastro.Size = new System.Drawing.Size(851, 444);
            this.tabPageCadastro.Controls.SetChildIndex(this.TXT_ID, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.groupBox1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // Comb_Cid
            // 
            this.Comb_Cid.AutoResize = false;
            this.Comb_Cid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Comb_Cid.Depth = 0;
            this.Comb_Cid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Comb_Cid.DropDownHeight = 174;
            this.Comb_Cid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comb_Cid.DropDownWidth = 121;
            this.Comb_Cid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Comb_Cid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Comb_Cid.FormattingEnabled = true;
            this.Comb_Cid.Hint = "CID";
            this.Comb_Cid.IntegralHeight = false;
            this.Comb_Cid.ItemHeight = 43;
            this.Comb_Cid.Items.AddRange(new object[] {
            "",
            "A09 - Diarreia e gastroenterite de origem infecciosa presumível",
            "B34 - Infecções virais não especificadas",
            "C00 - Neoplasia maligna do lábio",
            "C18 - Neoplasia maligna do cólon",
            "C50 - Neoplasia maligna da mama",
            "C61 - Neoplasia maligna da próstata",
            "E11 - Diabetes mellitus não-insulino-dependente",
            "E78 - Distúrbios do metabolismo lipídico",
            "F32 - Episódio depressivo",
            "F41 - Transtorno de ansiedade generalizada",
            "G20 - Doença de Parkinson",
            "G44 - Enxaqueca",
            "I10 - Hipertensão essencial",
            "I21 - Infarto agudo do miocárdio",
            "J00 - Resfriado comum",
            "J18 - Pneumonia não especificada",
            "J45 - Asma",
            "M00 - Artrite piogênica",
            "M25 - Outras doenças articulares especificadas",
            "M54 - Dor nas costas",
            "P07 - Transtornos do recém-nascido relacionados com a duração da gestação e com o" +
                " crescimento fetal",
            "P22 - Asfixia do nascimento",
            "V01 - Pedestre lesionado em colisão com veículo de pedal",
            "W20 - Queda na mesma superfície",
            "X95 - Ataque de animais mamíferos",
            "Y92 - Localização do evento esportivo"});
            this.Comb_Cid.Location = new System.Drawing.Point(6, 53);
            this.Comb_Cid.MaxDropDownItems = 4;
            this.Comb_Cid.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Comb_Cid.Name = "Comb_Cid";
            this.Comb_Cid.Size = new System.Drawing.Size(401, 49);
            this.Comb_Cid.StartIndex = 0;
            this.Comb_Cid.TabIndex = 11;
            // 
            // Datenas
            // 
            this.Datenas.CustomFormat = "dd-MM-yyyy";
            this.Datenas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Datenas.Location = new System.Drawing.Point(413, 64);
            this.Datenas.MinimumSize = new System.Drawing.Size(0, 29);
            this.Datenas.Name = "Datenas";
            this.Datenas.Size = new System.Drawing.Size(200, 29);
            this.Datenas.TabIndex = 13;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(413, 29);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(160, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Data do Agendamento";
            // 
            // Comb_Paciente
            // 
            this.Comb_Paciente.AutoResize = false;
            this.Comb_Paciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Comb_Paciente.Depth = 0;
            this.Comb_Paciente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Comb_Paciente.DropDownHeight = 174;
            this.Comb_Paciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comb_Paciente.DropDownWidth = 121;
            this.Comb_Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Comb_Paciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Comb_Paciente.FormattingEnabled = true;
            this.Comb_Paciente.Hint = "Paciente";
            this.Comb_Paciente.IntegralHeight = false;
            this.Comb_Paciente.ItemHeight = 43;
            this.Comb_Paciente.Location = new System.Drawing.Point(23, 82);
            this.Comb_Paciente.MaxDropDownItems = 4;
            this.Comb_Paciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Comb_Paciente.Name = "Comb_Paciente";
            this.Comb_Paciente.Size = new System.Drawing.Size(724, 49);
            this.Comb_Paciente.StartIndex = 0;
            this.Comb_Paciente.TabIndex = 15;
            // 
            // Comb_Medico
            // 
            this.Comb_Medico.AutoResize = false;
            this.Comb_Medico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Comb_Medico.Depth = 0;
            this.Comb_Medico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Comb_Medico.DropDownHeight = 174;
            this.Comb_Medico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comb_Medico.DropDownWidth = 121;
            this.Comb_Medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Comb_Medico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Comb_Medico.FormattingEnabled = true;
            this.Comb_Medico.Hint = "Profissional";
            this.Comb_Medico.IntegralHeight = false;
            this.Comb_Medico.ItemHeight = 43;
            this.Comb_Medico.Location = new System.Drawing.Point(23, 22);
            this.Comb_Medico.MaxDropDownItems = 4;
            this.Comb_Medico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Comb_Medico.Name = "Comb_Medico";
            this.Comb_Medico.Size = new System.Drawing.Size(723, 49);
            this.Comb_Medico.StartIndex = 0;
            this.Comb_Medico.TabIndex = 16;
            // 
            // TXT_ID
            // 
            this.TXT_ID.AutoSize = true;
            this.TXT_ID.Depth = 0;
            this.TXT_ID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TXT_ID.Location = new System.Drawing.Point(754, 275);
            this.TXT_ID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Size = new System.Drawing.Size(16, 19);
            this.TXT_ID.TabIndex = 17;
            this.TXT_ID.Text = "ID";
            // 
            // Desc_TEXT
            // 
            this.Desc_TEXT.AnimateReadOnly = false;
            this.Desc_TEXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Desc_TEXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Desc_TEXT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Desc_TEXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Desc_TEXT.Depth = 0;
            this.Desc_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Desc_TEXT.HideSelection = true;
            this.Desc_TEXT.Hint = "Descrição";
            this.Desc_TEXT.LeadingIcon = null;
            this.Desc_TEXT.Location = new System.Drawing.Point(6, 108);
            this.Desc_TEXT.MaxLength = 32767;
            this.Desc_TEXT.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Desc_TEXT.Name = "Desc_TEXT";
            this.Desc_TEXT.PasswordChar = '\0';
            this.Desc_TEXT.PrefixSuffixText = null;
            this.Desc_TEXT.ReadOnly = false;
            this.Desc_TEXT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Desc_TEXT.SelectedText = "";
            this.Desc_TEXT.SelectionLength = 0;
            this.Desc_TEXT.SelectionStart = 0;
            this.Desc_TEXT.ShortcutsEnabled = true;
            this.Desc_TEXT.Size = new System.Drawing.Size(723, 48);
            this.Desc_TEXT.TabIndex = 18;
            this.Desc_TEXT.TabStop = false;
            this.Desc_TEXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Desc_TEXT.TrailingIcon = null;
            this.Desc_TEXT.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.Desc_TEXT);
            this.groupBox1.Controls.Add(this.Comb_Cid);
            this.groupBox1.Controls.Add(this.Datenas);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 211);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 29);
            this.materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(26, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "CID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Comb_Paciente);
            this.groupBox2.Controls.Add(this.Comb_Medico);
            this.groupBox2.Location = new System.Drawing.Point(23, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 141);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // Cad_Procedimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 546);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Cad_Procedimento";
            this.Text = "Cad_Procedimento";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.PoisonDateTime Datenas;
        private ReaLTaiizor.Controls.MaterialComboBox Comb_Cid;
        private ReaLTaiizor.Controls.MaterialComboBox Comb_Medico;
        private ReaLTaiizor.Controls.MaterialComboBox Comb_Paciente;
        private ReaLTaiizor.Controls.MaterialLabel TXT_ID;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit Desc_TEXT;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
    }
}