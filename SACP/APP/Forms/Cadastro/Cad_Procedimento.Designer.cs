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
            Comb_Cid = new ReaLTaiizor.Controls.MaterialComboBox();
            Datenas = new ReaLTaiizor.Controls.PoisonDateTime();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            Comb_Paciente = new ReaLTaiizor.Controls.MaterialComboBox();
            Comb_Medico = new ReaLTaiizor.Controls.MaterialComboBox();
            TXT_ID = new ReaLTaiizor.Controls.MaterialLabel();
            Desc_TEXT = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(Desc_TEXT);
            tabPageCadastro.Controls.Add(TXT_ID);
            tabPageCadastro.Controls.Add(Comb_Medico);
            tabPageCadastro.Controls.Add(Comb_Paciente);
            tabPageCadastro.Controls.Add(materialLabel1);
            tabPageCadastro.Controls.Add(Datenas);
            tabPageCadastro.Controls.Add(Comb_Cid);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(Comb_Cid, 0);
            tabPageCadastro.Controls.SetChildIndex(Datenas, 0);
            tabPageCadastro.Controls.SetChildIndex(materialLabel1, 0);
            tabPageCadastro.Controls.SetChildIndex(Comb_Paciente, 0);
            tabPageCadastro.Controls.SetChildIndex(Comb_Medico, 0);
            tabPageCadastro.Controls.SetChildIndex(TXT_ID, 0);
            tabPageCadastro.Controls.SetChildIndex(Desc_TEXT, 0);
            // 
            // Comb_Cid
            // 
            Comb_Cid.AutoResize = false;
            Comb_Cid.BackColor = Color.FromArgb(255, 255, 255);
            Comb_Cid.Depth = 0;
            Comb_Cid.DrawMode = DrawMode.OwnerDrawVariable;
            Comb_Cid.DropDownHeight = 174;
            Comb_Cid.DropDownStyle = ComboBoxStyle.DropDownList;
            Comb_Cid.DropDownWidth = 121;
            Comb_Cid.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            Comb_Cid.ForeColor = Color.FromArgb(222, 0, 0, 0);
            Comb_Cid.FormattingEnabled = true;
            Comb_Cid.Hint = "CID";
            Comb_Cid.IntegralHeight = false;
            Comb_Cid.ItemHeight = 43;
            Comb_Cid.Items.AddRange(new object[] { "", "A09 - Diarreia e gastroenterite de origem infecciosa presumível", "B34 - Infecções virais não especificadas", "C00 - Neoplasia maligna do lábio", "C18 - Neoplasia maligna do cólon", "C50 - Neoplasia maligna da mama", "C61 - Neoplasia maligna da próstata", "E11 - Diabetes mellitus não-insulino-dependente", "E78 - Distúrbios do metabolismo lipídico", "F32 - Episódio depressivo", "F41 - Transtorno de ansiedade generalizada", "G20 - Doença de Parkinson", "G44 - Enxaqueca", "I10 - Hipertensão essencial", "I21 - Infarto agudo do miocárdio", "J00 - Resfriado comum", "J18 - Pneumonia não especificada", "J45 - Asma", "M00 - Artrite piogênica", "M25 - Outras doenças articulares especificadas", "M54 - Dor nas costas", "P07 - Transtornos do recém-nascido relacionados com a duração da gestação e com o crescimento fetal", "P22 - Asfixia do nascimento", "V01 - Pedestre lesionado em colisão com veículo de pedal", "W20 - Queda na mesma superfície", "X95 - Ataque de animais mamíferos", "Y92 - Localização do evento esportivo" });
            Comb_Cid.Location = new Point(23, 116);
            Comb_Cid.MaxDropDownItems = 4;
            Comb_Cid.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            Comb_Cid.Name = "Comb_Cid";
            Comb_Cid.Size = new Size(401, 49);
            Comb_Cid.StartIndex = 0;
            Comb_Cid.TabIndex = 11;
            // 
            // Datenas
            // 
            Datenas.Location = new Point(430, 136);
            Datenas.MinimumSize = new Size(0, 29);
            Datenas.Name = "Datenas";
            Datenas.Size = new Size(200, 29);
            Datenas.TabIndex = 13;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(430, 114);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(160, 19);
            materialLabel1.TabIndex = 14;
            materialLabel1.Text = "Data do Agendamento";
            // 
            // Comb_Paciente
            // 
            Comb_Paciente.AutoResize = false;
            Comb_Paciente.BackColor = Color.FromArgb(255, 255, 255);
            Comb_Paciente.Depth = 0;
            Comb_Paciente.DrawMode = DrawMode.OwnerDrawVariable;
            Comb_Paciente.DropDownHeight = 174;
            Comb_Paciente.DropDownStyle = ComboBoxStyle.DropDownList;
            Comb_Paciente.DropDownWidth = 121;
            Comb_Paciente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            Comb_Paciente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            Comb_Paciente.FormattingEnabled = true;
            Comb_Paciente.Hint = "Paciente";
            Comb_Paciente.IntegralHeight = false;
            Comb_Paciente.ItemHeight = 43;
            Comb_Paciente.Location = new Point(23, 61);
            Comb_Paciente.MaxDropDownItems = 4;
            Comb_Paciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            Comb_Paciente.Name = "Comb_Paciente";
            Comb_Paciente.Size = new Size(723, 49);
            Comb_Paciente.StartIndex = 0;
            Comb_Paciente.TabIndex = 15;
            // 
            // Comb_Medico
            // 
            Comb_Medico.AutoResize = false;
            Comb_Medico.BackColor = Color.FromArgb(255, 255, 255);
            Comb_Medico.Depth = 0;
            Comb_Medico.DrawMode = DrawMode.OwnerDrawVariable;
            Comb_Medico.DropDownHeight = 174;
            Comb_Medico.DropDownStyle = ComboBoxStyle.DropDownList;
            Comb_Medico.DropDownWidth = 121;
            Comb_Medico.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            Comb_Medico.ForeColor = Color.FromArgb(222, 0, 0, 0);
            Comb_Medico.FormattingEnabled = true;
            Comb_Medico.Hint = "Profissional";
            Comb_Medico.IntegralHeight = false;
            Comb_Medico.ItemHeight = 43;
            Comb_Medico.Location = new Point(23, 6);
            Comb_Medico.MaxDropDownItems = 4;
            Comb_Medico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            Comb_Medico.Name = "Comb_Medico";
            Comb_Medico.Size = new Size(723, 49);
            Comb_Medico.StartIndex = 0;
            Comb_Medico.TabIndex = 16;
            // 
            // TXT_ID
            // 
            TXT_ID.AutoSize = true;
            TXT_ID.Depth = 0;
            TXT_ID.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_ID.Location = new Point(754, 275);
            TXT_ID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TXT_ID.Name = "TXT_ID";
            TXT_ID.Size = new Size(16, 19);
            TXT_ID.TabIndex = 17;
            TXT_ID.Text = "ID";
            // 
            // Desc_TEXT
            // 
            Desc_TEXT.AnimateReadOnly = false;
            Desc_TEXT.AutoCompleteMode = AutoCompleteMode.None;
            Desc_TEXT.AutoCompleteSource = AutoCompleteSource.None;
            Desc_TEXT.BackgroundImageLayout = ImageLayout.None;
            Desc_TEXT.CharacterCasing = CharacterCasing.Normal;
            Desc_TEXT.Depth = 0;
            Desc_TEXT.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Desc_TEXT.HideSelection = true;
            Desc_TEXT.Hint = "Descrição";
            Desc_TEXT.LeadingIcon = null;
            Desc_TEXT.Location = new Point(23, 171);
            Desc_TEXT.MaxLength = 32767;
            Desc_TEXT.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            Desc_TEXT.Name = "Desc_TEXT";
            Desc_TEXT.PasswordChar = '\0';
            Desc_TEXT.PrefixSuffixText = null;
            Desc_TEXT.ReadOnly = false;
            Desc_TEXT.RightToLeft = RightToLeft.No;
            Desc_TEXT.SelectedText = "";
            Desc_TEXT.SelectionLength = 0;
            Desc_TEXT.SelectionStart = 0;
            Desc_TEXT.ShortcutsEnabled = true;
            Desc_TEXT.Size = new Size(723, 48);
            Desc_TEXT.TabIndex = 18;
            Desc_TEXT.TabStop = false;
            Desc_TEXT.TextAlign = HorizontalAlignment.Left;
            Desc_TEXT.TrailingIcon = null;
            Desc_TEXT.UseSystemPasswordChar = false;
            // 
            // Cad_Procedimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "Cad_Procedimento";
            Text = "Cad_Procedimento";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.PoisonDateTime Datenas;
        private ReaLTaiizor.Controls.MaterialComboBox Comb_Cid;
        private ReaLTaiizor.Controls.MaterialComboBox Comb_Medico;
        private ReaLTaiizor.Controls.MaterialComboBox Comb_Paciente;
        private ReaLTaiizor.Controls.MaterialLabel TXT_ID;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit Desc_TEXT;
    }
}