namespace SenacFoods
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            BtnEntrar = new Button();
            TxtSenha = new TextBox();
            TxtLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(BtnEntrar);
            panel2.Controls.Add(TxtSenha);
            panel2.Controls.Add(TxtLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(281, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(519, 450);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(442, 12);
            button1.Name = "button1";
            button1.Size = new Size(44, 43);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnEntrar
            // 
            BtnEntrar.FlatAppearance.BorderSize = 0;
            BtnEntrar.FlatAppearance.MouseDownBackColor = Color.Lime;
            BtnEntrar.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnEntrar.FlatStyle = FlatStyle.Flat;
            BtnEntrar.Font = new Font("Algerian", 15F);
            BtnEntrar.ForeColor = Color.White;
            BtnEntrar.Location = new Point(88, 255);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(212, 67);
            BtnEntrar.TabIndex = 2;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = true;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // TxtSenha
            // 
            TxtSenha.BackColor = Color.Black;
            TxtSenha.BorderStyle = BorderStyle.None;
            TxtSenha.Font = new Font("Algerian", 18F);
            TxtSenha.ForeColor = Color.White;
            TxtSenha.Location = new Point(71, 166);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(372, 48);
            TxtSenha.TabIndex = 0;
            TxtSenha.Text = "Senha";
            // 
            // TxtLogin
            // 
            TxtLogin.BackColor = Color.Black;
            TxtLogin.BorderStyle = BorderStyle.None;
            TxtLogin.Font = new Font("Algerian", 18F);
            TxtLogin.ForeColor = Color.White;
            TxtLogin.Location = new Point(71, 86);
            TxtLogin.Name = "TxtLogin";
            TxtLogin.Size = new Size(372, 48);
            TxtLogin.TabIndex = 0;
            TxtLogin.Text = "USUÁRIO";
            TxtLogin.TextChanged += TxtLogin_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(71, 199);
            label2.Name = "label2";
            label2.Size = new Size(229, 25);
            label2.TabIndex = 1;
            label2.Text = "_______________________________";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 119);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 1;
            label1.Text = "_______________________________";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox TxtLogin;
        private TextBox TxtSenha;
        private Label label1;
        private Label label2;
        private Button BtnEntrar;
        private Button button1;
    }
}
