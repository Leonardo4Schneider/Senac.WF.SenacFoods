namespace SenacFoods
{
    partial class FrmUsuariosCad
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
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtConfirmarSenha = new TextBox();
            txtSenha = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtNome = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtConfirmarSenha);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1667, 590);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(19, 550);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 40);
            comboBox1.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 501);
            label6.Name = "label6";
            label6.Size = new Size(67, 32);
            label6.TabIndex = 29;
            label6.Text = "Perfil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 405);
            label5.Name = "label5";
            label5.Size = new Size(253, 32);
            label5.TabIndex = 28;
            label5.Text = "Confirmação de senha";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(19, 457);
            txtConfirmarSenha.Margin = new Padding(4, 5, 4, 5);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(1098, 39);
            txtConfirmarSenha.TabIndex = 27;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(19, 336);
            txtSenha.Margin = new Padding(4, 5, 4, 5);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(1098, 39);
            txtSenha.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 299);
            label4.Name = "label4";
            label4.Size = new Size(87, 32);
            label4.TabIndex = 25;
            label4.Text = "Senha ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(19, 232);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(1098, 39);
            txtEmail.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 177);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 23;
            label3.Text = "Email";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Chartreuse;
            btnSalvar.Location = new Point(1490, 517);
            btnSalvar.Margin = new Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(176, 71);
            btnSalvar.TabIndex = 22;
            btnSalvar.Text = "% Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(1295, 517);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(187, 71);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "% Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(19, 104);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(1098, 39);
            txtNome.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 67);
            label2.Name = "label2";
            label2.Size = new Size(202, 32);
            label2.TabIndex = 12;
            label2.Text = "Nome do Usuario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aquamarine;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnFechar);
            panel1.Location = new Point(-8, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1703, 125);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(108, 52);
            label1.Name = "label1";
            label1.Size = new Size(245, 41);
            label1.TabIndex = 6;
            label1.Text = "Cadastro Usuario";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(1481, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(62, 51);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // FrmUsuariosCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1691, 732);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuariosCad";
            Text = "FrmUsuariosCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txtNome;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button btnFechar;
        private TextBox txtEmail;
        private Label label3;
        private Label label5;
        private TextBox txtConfirmarSenha;
        private TextBox txtSenha;
        private Label label4;
        private Label label6;
        private ComboBox comboBox1;
    }
}