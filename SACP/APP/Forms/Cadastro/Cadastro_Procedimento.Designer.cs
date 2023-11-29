namespace SACP.APP.Cadastros
{
    partial class Cadastro_Procedimento
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
            Txt_Cod = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            Combox_Profissional = new ReaLTaiizor.Controls.MaterialComboBox();
            Comb_CID = new ReaLTaiizor.Controls.MaterialComboBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(686, 202);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(Comb_CID);
            tabPageCadastro.Controls.Add(Txt_Cod);
            tabPageCadastro.Controls.Add(Combox_Profissional);
            tabPageCadastro.Size = new Size(678, 167);
            tabPageCadastro.Controls.SetChildIndex(Combox_Profissional, 0);
            tabPageCadastro.Controls.SetChildIndex(Txt_Cod, 0);
            tabPageCadastro.Controls.SetChildIndex(Comb_CID, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(540, 416);
            // 
            // Txt_Cod
            // 
            Txt_Cod.AnimateReadOnly = false;
            Txt_Cod.AutoCompleteMode = AutoCompleteMode.None;
            Txt_Cod.AutoCompleteSource = AutoCompleteSource.None;
            Txt_Cod.BackgroundImageLayout = ImageLayout.None;
            Txt_Cod.CharacterCasing = CharacterCasing.Normal;
            Txt_Cod.Depth = 0;
            Txt_Cod.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Txt_Cod.HideSelection = true;
            Txt_Cod.Hint = "Codigo";
            Txt_Cod.LeadingIcon = null;
            Txt_Cod.Location = new Point(6, 17);
            Txt_Cod.MaxLength = 32767;
            Txt_Cod.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            Txt_Cod.Name = "Txt_Cod";
            Txt_Cod.PasswordChar = '\0';
            Txt_Cod.PrefixSuffixText = null;
            Txt_Cod.ReadOnly = false;
            Txt_Cod.RightToLeft = RightToLeft.No;
            Txt_Cod.SelectedText = "";
            Txt_Cod.SelectionLength = 0;
            Txt_Cod.SelectionStart = 0;
            Txt_Cod.ShortcutsEnabled = true;
            Txt_Cod.Size = new Size(212, 48);
            Txt_Cod.TabIndex = 18;
            Txt_Cod.TabStop = false;
            Txt_Cod.TextAlign = HorizontalAlignment.Left;
            Txt_Cod.TrailingIcon = null;
            Txt_Cod.UseSystemPasswordChar = false;
            // 
            // Combox_Profissional
            // 
            Combox_Profissional.AutoResize = false;
            Combox_Profissional.BackColor = Color.FromArgb(255, 255, 255);
            Combox_Profissional.Depth = 0;
            Combox_Profissional.DrawMode = DrawMode.OwnerDrawVariable;
            Combox_Profissional.DropDownHeight = 174;
            Combox_Profissional.DropDownStyle = ComboBoxStyle.DropDownList;
            Combox_Profissional.DropDownWidth = 121;
            Combox_Profissional.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            Combox_Profissional.ForeColor = Color.FromArgb(222, 0, 0, 0);
            Combox_Profissional.FormattingEnabled = true;
            Combox_Profissional.Hint = "Profissional";
            Combox_Profissional.IntegralHeight = false;
            Combox_Profissional.ItemHeight = 43;
            Combox_Profissional.Location = new Point(6, 71);
            Combox_Profissional.MaxDropDownItems = 4;
            Combox_Profissional.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            Combox_Profissional.Name = "Combox_Profissional";
            Combox_Profissional.Size = new Size(660, 49);
            Combox_Profissional.StartIndex = 0;
            Combox_Profissional.TabIndex = 17;
            // 
            // Comb_CID
            // 
            Comb_CID.AutoResize = false;
            Comb_CID.BackColor = Color.FromArgb(255, 255, 255);
            Comb_CID.Depth = 0;
            Comb_CID.DrawMode = DrawMode.OwnerDrawVariable;
            Comb_CID.DropDownHeight = 174;
            Comb_CID.DropDownStyle = ComboBoxStyle.DropDownList;
            Comb_CID.DropDownWidth = 121;
            Comb_CID.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            Comb_CID.ForeColor = Color.FromArgb(222, 0, 0, 0);
            Comb_CID.FormattingEnabled = true;
            Comb_CID.Hint = "CID";
            Comb_CID.IntegralHeight = false;
            Comb_CID.ItemHeight = 43;
            Comb_CID.Location = new Point(224, 16);
            Comb_CID.MaxDropDownItems = 4;
            Comb_CID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            Comb_CID.Name = "Comb_CID";
            Comb_CID.Size = new Size(442, 49);
            Comb_CID.StartIndex = 0;
            Comb_CID.TabIndex = 19;
            // 
            // Cadastro_Procedimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 269);
            Location = new Point(0, 0);
            Name = "Cadastro_Procedimento";
            Text = "Cadastro Procedimento";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox Comb_CID;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit Txt_Cod;
        private ReaLTaiizor.Controls.MaterialComboBox Combox_Profissional;
    }
}