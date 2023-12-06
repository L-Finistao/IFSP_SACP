namespace SGA
{
    partial class FormReportProfessor
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
            groupBox1 = new GroupBox();
            TxtFormacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            CboxTitulacao = new ReaLTaiizor.Controls.MaterialComboBox();
            mmtbDataNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            groupBox2 = new GroupBox();
            CboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            cboEstados = new ReaLTaiizor.Controls.MaterialComboBox();
            TxtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtFormacao);
            groupBox1.Controls.Add(CboxTitulacao);
            groupBox1.Controls.Add(mmtbDataNascimento);
            groupBox1.Controls.Add(btnVisualizar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cboEstados);
            groupBox1.Controls.Add(TxtCidade);
            groupBox1.Location = new Point(19, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 498);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // TxtFormacao
            // 
            TxtFormacao.AnimateReadOnly = false;
            TxtFormacao.AutoCompleteMode = AutoCompleteMode.None;
            TxtFormacao.AutoCompleteSource = AutoCompleteSource.None;
            TxtFormacao.BackgroundImageLayout = ImageLayout.None;
            TxtFormacao.CharacterCasing = CharacterCasing.Normal;
            TxtFormacao.Depth = 0;
            TxtFormacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtFormacao.HideSelection = true;
            TxtFormacao.Hint = "Área de Formação";
            TxtFormacao.LeadingIcon = null;
            TxtFormacao.Location = new Point(25, 131);
            TxtFormacao.MaxLength = 32767;
            TxtFormacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TxtFormacao.Name = "TxtFormacao";
            TxtFormacao.PasswordChar = '\0';
            TxtFormacao.PrefixSuffixText = null;
            TxtFormacao.ReadOnly = false;
            TxtFormacao.RightToLeft = RightToLeft.No;
            TxtFormacao.SelectedText = "";
            TxtFormacao.SelectionLength = 0;
            TxtFormacao.SelectionStart = 0;
            TxtFormacao.ShortcutsEnabled = true;
            TxtFormacao.Size = new Size(700, 48);
            TxtFormacao.TabIndex = 21;
            TxtFormacao.TabStop = false;
            TxtFormacao.TextAlign = HorizontalAlignment.Left;
            TxtFormacao.TrailingIcon = null;
            TxtFormacao.UseSystemPasswordChar = false;
            // 
            // CboxTitulacao
            // 
            CboxTitulacao.AutoResize = false;
            CboxTitulacao.BackColor = Color.FromArgb(255, 255, 255);
            CboxTitulacao.Depth = 0;
            CboxTitulacao.DrawMode = DrawMode.OwnerDrawVariable;
            CboxTitulacao.DropDownHeight = 174;
            CboxTitulacao.DropDownStyle = ComboBoxStyle.DropDownList;
            CboxTitulacao.DropDownWidth = 121;
            CboxTitulacao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CboxTitulacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CboxTitulacao.FormattingEnabled = true;
            CboxTitulacao.Hint = "Titulação";
            CboxTitulacao.IntegralHeight = false;
            CboxTitulacao.ItemHeight = 43;
            CboxTitulacao.Items.AddRange(new object[] { "", "Graduação", "Especialização", "Mestrado", "Doutorado" });
            CboxTitulacao.Location = new Point(186, 75);
            CboxTitulacao.MaxDropDownItems = 4;
            CboxTitulacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CboxTitulacao.Name = "CboxTitulacao";
            CboxTitulacao.Size = new Size(539, 49);
            CboxTitulacao.StartIndex = 0;
            CboxTitulacao.TabIndex = 20;
            // 
            // mmtbDataNascimento
            // 
            mmtbDataNascimento.AllowPromptAsInput = true;
            mmtbDataNascimento.AnimateReadOnly = false;
            mmtbDataNascimento.AsciiOnly = false;
            mmtbDataNascimento.BackgroundImageLayout = ImageLayout.None;
            mmtbDataNascimento.BeepOnError = false;
            mmtbDataNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mmtbDataNascimento.Depth = 0;
            mmtbDataNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mmtbDataNascimento.HidePromptOnLeave = false;
            mmtbDataNascimento.HideSelection = true;
            mmtbDataNascimento.Hint = "Data de Nascimento";
            mmtbDataNascimento.InsertKeyMode = InsertKeyMode.Default;
            mmtbDataNascimento.LeadingIcon = null;
            mmtbDataNascimento.Location = new Point(25, 75);
            mmtbDataNascimento.Mask = "99/99/9999";
            mmtbDataNascimento.MaxLength = 32767;
            mmtbDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mmtbDataNascimento.Name = "mmtbDataNascimento";
            mmtbDataNascimento.PasswordChar = '\0';
            mmtbDataNascimento.PrefixSuffixText = null;
            mmtbDataNascimento.PromptChar = '_';
            mmtbDataNascimento.ReadOnly = false;
            mmtbDataNascimento.RejectInputOnFirstFailure = false;
            mmtbDataNascimento.ResetOnPrompt = true;
            mmtbDataNascimento.ResetOnSpace = true;
            mmtbDataNascimento.RightToLeft = RightToLeft.No;
            mmtbDataNascimento.SelectedText = "";
            mmtbDataNascimento.SelectionLength = 0;
            mmtbDataNascimento.SelectionStart = 0;
            mmtbDataNascimento.ShortcutsEnabled = true;
            mmtbDataNascimento.Size = new Size(155, 48);
            mmtbDataNascimento.SkipLiterals = true;
            mmtbDataNascimento.TabIndex = 16;
            mmtbDataNascimento.TabStop = false;
            mmtbDataNascimento.Text = "  /  /";
            mmtbDataNascimento.TextAlign = HorizontalAlignment.Left;
            mmtbDataNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            mmtbDataNascimento.TrailingIcon = null;
            mmtbDataNascimento.UseSystemPasswordChar = false;
            mmtbDataNascimento.ValidatingType = null;
            // 
            // btnVisualizar
            // 
            btnVisualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVisualizar.Depth = 0;
            btnVisualizar.HighEmphasis = true;
            btnVisualizar.Icon = null;
            btnVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnVisualizar.Location = new Point(551, 453);
            btnVisualizar.Margin = new Padding(4, 6, 4, 6);
            btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.NoAccentTextColor = Color.Empty;
            btnVisualizar.Size = new Size(112, 36);
            btnVisualizar.TabIndex = 15;
            btnVisualizar.Text = "&VISUALIZAR";
            btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVisualizar.UseAccentColor = false;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(671, 453);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(97, 36);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "&IMPRIMIR";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CboImpressora);
            groupBox2.Location = new Point(18, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(721, 193);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Impressora";
            // 
            // CboImpressora
            // 
            CboImpressora.AutoResize = false;
            CboImpressora.BackColor = Color.FromArgb(255, 255, 255);
            CboImpressora.Depth = 0;
            CboImpressora.DrawMode = DrawMode.OwnerDrawVariable;
            CboImpressora.DropDownHeight = 174;
            CboImpressora.DropDownStyle = ComboBoxStyle.DropDownList;
            CboImpressora.DropDownWidth = 121;
            CboImpressora.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CboImpressora.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CboImpressora.FormattingEnabled = true;
            CboImpressora.Hint = "Impressora";
            CboImpressora.IntegralHeight = false;
            CboImpressora.ItemHeight = 43;
            CboImpressora.Location = new Point(6, 33);
            CboImpressora.MaxDropDownItems = 4;
            CboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CboImpressora.Name = "CboImpressora";
            CboImpressora.Size = new Size(701, 49);
            CboImpressora.StartIndex = 0;
            CboImpressora.TabIndex = 9;
            CboImpressora.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            // 
            // cboEstados
            // 
            cboEstados.AutoResize = false;
            cboEstados.BackColor = Color.FromArgb(255, 255, 255);
            cboEstados.Depth = 0;
            cboEstados.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstados.DropDownHeight = 174;
            cboEstados.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstados.DropDownWidth = 121;
            cboEstados.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstados.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstados.FormattingEnabled = true;
            cboEstados.Hint = "Estado";
            cboEstados.IntegralHeight = false;
            cboEstados.ItemHeight = 43;
            cboEstados.Items.AddRange(new object[] { "", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboEstados.Location = new Point(523, 21);
            cboEstados.MaxDropDownItems = 4;
            cboEstados.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstados.Name = "cboEstados";
            cboEstados.Size = new Size(202, 49);
            cboEstados.StartIndex = 0;
            cboEstados.TabIndex = 8;
            // 
            // TxtCidade
            // 
            TxtCidade.AnimateReadOnly = false;
            TxtCidade.AutoCompleteMode = AutoCompleteMode.None;
            TxtCidade.AutoCompleteSource = AutoCompleteSource.None;
            TxtCidade.BackgroundImageLayout = ImageLayout.None;
            TxtCidade.CharacterCasing = CharacterCasing.Normal;
            TxtCidade.Depth = 0;
            TxtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtCidade.HideSelection = true;
            TxtCidade.Hint = "Cidade";
            TxtCidade.LeadingIcon = null;
            TxtCidade.Location = new Point(24, 22);
            TxtCidade.MaxLength = 32767;
            TxtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TxtCidade.Name = "TxtCidade";
            TxtCidade.PasswordChar = '\0';
            TxtCidade.PrefixSuffixText = null;
            TxtCidade.ReadOnly = false;
            TxtCidade.RightToLeft = RightToLeft.No;
            TxtCidade.SelectedText = "";
            TxtCidade.SelectionLength = 0;
            TxtCidade.SelectionStart = 0;
            TxtCidade.ShortcutsEnabled = true;
            TxtCidade.Size = new Size(493, 48);
            TxtCidade.TabIndex = 7;
            TxtCidade.TabStop = false;
            TxtCidade.TextAlign = HorizontalAlignment.Left;
            TxtCidade.TrailingIcon = null;
            TxtCidade.UseSystemPasswordChar = false;
            // 
            // FormReportProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 591);
            Controls.Add(groupBox1);
            Name = "FormReportProfessor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Professores";
            Load += FormReport_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialComboBox CboImpressora;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstados;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtCidade;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TxtFormacao;
        private ReaLTaiizor.Controls.MaterialComboBox CboxTitulacao;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mmtbDataNascimento;
    }
}