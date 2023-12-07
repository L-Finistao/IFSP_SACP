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
            this.CombAgenda = new ReaLTaiizor.Controls.MaterialComboBox();
            this.CombPasci = new ReaLTaiizor.Controls.MaterialComboBox();
            this.TXT_ID = new ReaLTaiizor.Controls.MaterialLabel();
            this.CheckRealizado = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(473, 416);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.groupBox2);
            this.tabPageCadastro.Controls.Add(this.groupBox1);
            this.tabPageCadastro.Controls.Add(this.CheckRealizado);
            this.tabPageCadastro.Controls.Add(this.TXT_ID);
            this.tabPageCadastro.Size = new System.Drawing.Size(465, 381);
            this.tabPageCadastro.Controls.SetChildIndex(this.TXT_ID, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.CheckRealizado, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.groupBox1, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // CombAgenda
            // 
            this.CombAgenda.AutoResize = false;
            this.CombAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CombAgenda.Depth = 0;
            this.CombAgenda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CombAgenda.DropDownHeight = 174;
            this.CombAgenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombAgenda.DropDownWidth = 121;
            this.CombAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CombAgenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CombAgenda.FormattingEnabled = true;
            this.CombAgenda.Hint = "Agenda";
            this.CombAgenda.IntegralHeight = false;
            this.CombAgenda.ItemHeight = 43;
            this.CombAgenda.Location = new System.Drawing.Point(39, 22);
            this.CombAgenda.MaxDropDownItems = 4;
            this.CombAgenda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CombAgenda.Name = "CombAgenda";
            this.CombAgenda.Size = new System.Drawing.Size(335, 49);
            this.CombAgenda.StartIndex = 0;
            this.CombAgenda.TabIndex = 11;
            // 
            // CombPasci
            // 
            this.CombPasci.AutoResize = false;
            this.CombPasci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CombPasci.Depth = 0;
            this.CombPasci.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CombPasci.DropDownHeight = 174;
            this.CombPasci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombPasci.DropDownWidth = 121;
            this.CombPasci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CombPasci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CombPasci.FormattingEnabled = true;
            this.CombPasci.Hint = "Paciente";
            this.CombPasci.IntegralHeight = false;
            this.CombPasci.ItemHeight = 43;
            this.CombPasci.Location = new System.Drawing.Point(39, 22);
            this.CombPasci.MaxDropDownItems = 4;
            this.CombPasci.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CombPasci.Name = "CombPasci";
            this.CombPasci.Size = new System.Drawing.Size(335, 49);
            this.CombPasci.StartIndex = 0;
            this.CombPasci.TabIndex = 12;
            // 
            // TXT_ID
            // 
            this.TXT_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_ID.AutoSize = true;
            this.TXT_ID.Depth = 0;
            this.TXT_ID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TXT_ID.Location = new System.Drawing.Point(442, 3);
            this.TXT_ID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Size = new System.Drawing.Size(16, 19);
            this.TXT_ID.TabIndex = 14;
            this.TXT_ID.Text = "ID";
            // 
            // CheckRealizado
            // 
            this.CheckRealizado.AutoSize = true;
            this.CheckRealizado.Depth = 0;
            this.CheckRealizado.Location = new System.Drawing.Point(6, 215);
            this.CheckRealizado.Margin = new System.Windows.Forms.Padding(0);
            this.CheckRealizado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckRealizado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CheckRealizado.Name = "CheckRealizado";
            this.CheckRealizado.ReadOnly = false;
            this.CheckRealizado.Ripple = true;
            this.CheckRealizado.Size = new System.Drawing.Size(105, 37);
            this.CheckRealizado.TabIndex = 15;
            this.CheckRealizado.Text = "Realizado";
            this.CheckRealizado.UseAccentColor = false;
            this.CheckRealizado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CombAgenda);
            this.groupBox1.Location = new System.Drawing.Point(6, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 81);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agenda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CombPasci);
            this.groupBox2.Location = new System.Drawing.Point(6, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 98);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paciente";
            // 
            // Cad_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 483);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Cad_Consulta";
            this.Text = "Agendamento de Consulta";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox CombPasci;
        private ReaLTaiizor.Controls.MaterialComboBox CombAgenda;
        private ReaLTaiizor.Controls.MaterialLabel TXT_ID;
        private ReaLTaiizor.Controls.MaterialCheckBox CheckRealizado;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}