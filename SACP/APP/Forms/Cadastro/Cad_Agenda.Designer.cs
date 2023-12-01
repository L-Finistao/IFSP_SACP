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
            Txt_vagas = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ID_TXT = new ReaLTaiizor.Controls.MaterialLabel();
            Combo_Prof = new ReaLTaiizor.Controls.MaterialComboBox();
            poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
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
            tabPageCadastro.Controls.Add(poisonDateTime1);
            tabPageCadastro.Controls.Add(Combo_Prof);
            tabPageCadastro.Controls.Add(ID_TXT);
            tabPageCadastro.Controls.Add(Txt_vagas);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(Txt_vagas, 0);
            tabPageCadastro.Controls.SetChildIndex(ID_TXT, 0);
            tabPageCadastro.Controls.SetChildIndex(Combo_Prof, 0);
            tabPageCadastro.Controls.SetChildIndex(poisonDateTime1, 0);
            // 
            // Txt_vagas
            // 
            Txt_vagas.AnimateReadOnly = false;
            Txt_vagas.AutoCompleteMode = AutoCompleteMode.None;
            Txt_vagas.AutoCompleteSource = AutoCompleteSource.None;
            Txt_vagas.BackgroundImageLayout = ImageLayout.None;
            Txt_vagas.CharacterCasing = CharacterCasing.Normal;
            Txt_vagas.Depth = 0;
            Txt_vagas.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Txt_vagas.HideSelection = true;
            Txt_vagas.Hint = "VAGAS";
            Txt_vagas.LeadingIcon = null;
            Txt_vagas.Location = new Point(72, 116);
            Txt_vagas.MaxLength = 32767;
            Txt_vagas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            Txt_vagas.Name = "Txt_vagas";
            Txt_vagas.PasswordChar = '\0';
            Txt_vagas.PrefixSuffixText = null;
            Txt_vagas.ReadOnly = false;
            Txt_vagas.RightToLeft = RightToLeft.No;
            Txt_vagas.SelectedText = "";
            Txt_vagas.SelectionLength = 0;
            Txt_vagas.SelectionStart = 0;
            Txt_vagas.ShortcutsEnabled = true;
            Txt_vagas.Size = new Size(200, 48);
            Txt_vagas.TabIndex = 11;
            Txt_vagas.TabStop = false;
            Txt_vagas.TextAlign = HorizontalAlignment.Left;
            Txt_vagas.TrailingIcon = null;
            Txt_vagas.UseSystemPasswordChar = false;
            // 
            // ID_TXT
            // 
            ID_TXT.AutoSize = true;
            ID_TXT.Depth = 0;
            ID_TXT.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ID_TXT.Location = new Point(764, 275);
            ID_TXT.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ID_TXT.Name = "ID_TXT";
            ID_TXT.Size = new Size(16, 19);
            ID_TXT.TabIndex = 12;
            ID_TXT.Text = "ID";
            // 
            // Combo_Prof
            // 
            Combo_Prof.AutoResize = false;
            Combo_Prof.BackColor = Color.FromArgb(255, 255, 255);
            Combo_Prof.Depth = 0;
            Combo_Prof.DrawMode = DrawMode.OwnerDrawVariable;
            Combo_Prof.DropDownHeight = 174;
            Combo_Prof.DropDownStyle = ComboBoxStyle.DropDownList;
            Combo_Prof.DropDownWidth = 121;
            Combo_Prof.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            Combo_Prof.ForeColor = Color.FromArgb(222, 0, 0, 0);
            Combo_Prof.FormattingEnabled = true;
            Combo_Prof.Hint = "Profissional";
            Combo_Prof.IntegralHeight = false;
            Combo_Prof.ItemHeight = 43;
            Combo_Prof.Location = new Point(72, 16);
            Combo_Prof.MaxDropDownItems = 4;
            Combo_Prof.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            Combo_Prof.Name = "Combo_Prof";
            Combo_Prof.Size = new Size(647, 49);
            Combo_Prof.StartIndex = 0;
            Combo_Prof.TabIndex = 13;
            // 
            // poisonDateTime1
            // 
            poisonDateTime1.Location = new Point(72, 71);
            poisonDateTime1.MinimumSize = new Size(0, 29);
            poisonDateTime1.Name = "poisonDateTime1";
            poisonDateTime1.Size = new Size(200, 29);
            poisonDateTime1.TabIndex = 14;
            // 
            // Cad_Agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "Cad_Agenda";
            Text = "Cad_Agenda";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel ID_TXT;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private ReaLTaiizor.Controls.MaterialComboBox Combo_Prof;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit Txt_vagas;
    }
}