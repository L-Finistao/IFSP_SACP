namespace SACP.APP.Cadastros
{
    partial class Cadastro_Medico
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
            crownButton1 = new ReaLTaiizor.Controls.CrownButton();
            Combox_Profissional = new ReaLTaiizor.Controls.MaterialComboBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(406, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(Combox_Profissional);
            tabPageCadastro.Controls.Add(crownButton1);
            tabPageCadastro.Size = new Size(398, 348);
            tabPageCadastro.Controls.SetChildIndex(crownButton1, 0);
            tabPageCadastro.Controls.SetChildIndex(Combox_Profissional, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(540, 416);
            // 
            // crownButton1
            // 
            crownButton1.Location = new Point(23, 61);
            crownButton1.Name = "crownButton1";
            crownButton1.Padding = new Padding(5);
            crownButton1.Size = new Size(132, 38);
            crownButton1.TabIndex = 16;
            crownButton1.Text = "+ Especialidade";
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
            Combox_Profissional.Location = new Point(23, 6);
            Combox_Profissional.MaxDropDownItems = 4;
            Combox_Profissional.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            Combox_Profissional.Name = "Combox_Profissional";
            Combox_Profissional.Size = new Size(368, 49);
            Combox_Profissional.StartIndex = 0;
            Combox_Profissional.TabIndex = 18;
            // 
            // Cadastro_Medico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Location = new Point(0, 0);
            Name = "Cadastro_Medico";
            Text = "Cadastro Medicos";
            Load += Cadastro_Medico_Load;
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CrownButton crownButton1;
        private ReaLTaiizor.Controls.MaterialComboBox Combox_Profissional;
    }
}