namespace APP.Forms.Cadastro
{
    partial class Cadastro_CID
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
            CID_Text = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            Desc_Text = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ID_Text = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(297, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(ID_Text);
            tabPageCadastro.Controls.Add(Desc_Text);
            tabPageCadastro.Controls.Add(CID_Text);
            tabPageCadastro.Size = new Size(289, 348);
            tabPageCadastro.Controls.SetChildIndex(CID_Text, 0);
            tabPageCadastro.Controls.SetChildIndex(Desc_Text, 0);
            tabPageCadastro.Controls.SetChildIndex(ID_Text, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(540, 416);
            // 
            // CID_Text
            // 
            CID_Text.AnimateReadOnly = false;
            CID_Text.AutoCompleteMode = AutoCompleteMode.None;
            CID_Text.AutoCompleteSource = AutoCompleteSource.None;
            CID_Text.BackgroundImageLayout = ImageLayout.None;
            CID_Text.CharacterCasing = CharacterCasing.Normal;
            CID_Text.Depth = 0;
            CID_Text.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            CID_Text.HideSelection = true;
            CID_Text.Hint = "CID";
            CID_Text.LeadingIcon = null;
            CID_Text.Location = new Point(6, 18);
            CID_Text.MaxLength = 32767;
            CID_Text.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CID_Text.Name = "CID_Text";
            CID_Text.PasswordChar = '\0';
            CID_Text.PrefixSuffixText = null;
            CID_Text.ReadOnly = false;
            CID_Text.RightToLeft = RightToLeft.No;
            CID_Text.SelectedText = "";
            CID_Text.SelectionLength = 0;
            CID_Text.SelectionStart = 0;
            CID_Text.ShortcutsEnabled = true;
            CID_Text.Size = new Size(276, 48);
            CID_Text.TabIndex = 11;
            CID_Text.TabStop = false;
            CID_Text.TextAlign = HorizontalAlignment.Left;
            CID_Text.TrailingIcon = null;
            CID_Text.UseSystemPasswordChar = false;
            // 
            // Desc_Text
            // 
            Desc_Text.AnimateReadOnly = false;
            Desc_Text.AutoCompleteMode = AutoCompleteMode.None;
            Desc_Text.AutoCompleteSource = AutoCompleteSource.None;
            Desc_Text.BackgroundImageLayout = ImageLayout.None;
            Desc_Text.CharacterCasing = CharacterCasing.Normal;
            Desc_Text.Depth = 0;
            Desc_Text.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Desc_Text.HideSelection = true;
            Desc_Text.Hint = "Descrição";
            Desc_Text.LeadingIcon = null;
            Desc_Text.Location = new Point(6, 72);
            Desc_Text.MaxLength = 32767;
            Desc_Text.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            Desc_Text.Name = "Desc_Text";
            Desc_Text.PasswordChar = '\0';
            Desc_Text.PrefixSuffixText = null;
            Desc_Text.ReadOnly = false;
            Desc_Text.RightToLeft = RightToLeft.No;
            Desc_Text.SelectedText = "";
            Desc_Text.SelectionLength = 0;
            Desc_Text.SelectionStart = 0;
            Desc_Text.ShortcutsEnabled = true;
            Desc_Text.Size = new Size(276, 48);
            Desc_Text.TabIndex = 12;
            Desc_Text.TabStop = false;
            Desc_Text.TextAlign = HorizontalAlignment.Left;
            Desc_Text.TrailingIcon = null;
            Desc_Text.UseSystemPasswordChar = false;
            // 
            // ID_Text
            // 
            ID_Text.AnimateReadOnly = false;
            ID_Text.AutoCompleteMode = AutoCompleteMode.None;
            ID_Text.AutoCompleteSource = AutoCompleteSource.None;
            ID_Text.BackgroundImageLayout = ImageLayout.None;
            ID_Text.CharacterCasing = CharacterCasing.Normal;
            ID_Text.Depth = 0;
            ID_Text.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ID_Text.HideSelection = true;
            ID_Text.Hint = "ID";
            ID_Text.LeadingIcon = null;
            ID_Text.Location = new Point(238, 126);
            ID_Text.MaxLength = 32767;
            ID_Text.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ID_Text.Name = "ID_Text";
            ID_Text.PasswordChar = '\0';
            ID_Text.PrefixSuffixText = null;
            ID_Text.ReadOnly = false;
            ID_Text.RightToLeft = RightToLeft.No;
            ID_Text.SelectedText = "";
            ID_Text.SelectionLength = 0;
            ID_Text.SelectionStart = 0;
            ID_Text.ShortcutsEnabled = true;
            ID_Text.Size = new Size(44, 48);
            ID_Text.TabIndex = 13;
            ID_Text.TabStop = false;
            ID_Text.TextAlign = HorizontalAlignment.Left;
            ID_Text.TrailingIcon = null;
            ID_Text.UseSystemPasswordChar = false;
            ID_Text.Click += materialTextBoxEdit3_Click;
            // 
            // Cadastro_CID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 450);
            Location = new Point(0, 0);
            Name = "Cadastro_CID";
            Text = "Cadastro_CID";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit CID_Text;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit Desc_Text;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit ID_Text;
    }
}