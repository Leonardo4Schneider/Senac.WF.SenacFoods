namespace SenacFoods
{
    partial class FrmCardapioCad
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
            panel1 = new Panel();
            label1 = new Label();
            btnFechar = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkPossuiPreparo = new CheckBox();
            txtTitulo = new TextBox();
            textPreco = new TextBox();
            groupBox1 = new GroupBox();
            btnSalvar = new Button();
            txtDescricao = new RichTextBox();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aquamarine;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(-2, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1551, 138);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 3;
            label1.Text = "Pesquisar:";
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
            btnFechar.Click += btnFechar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 31);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1098, 31);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 67);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 12;
            label2.Text = "Titulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 138);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 13;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 308);
            label4.Name = "label4";
            label4.Size = new Size(73, 32);
            label4.TabIndex = 14;
            label4.Text = "Preço";
            // 
            // chkPossuiPreparo
            // 
            chkPossuiPreparo.AutoSize = true;
            chkPossuiPreparo.Location = new Point(11, 387);
            chkPossuiPreparo.Name = "chkPossuiPreparo";
            chkPossuiPreparo.Size = new Size(207, 36);
            chkPossuiPreparo.TabIndex = 16;
            chkPossuiPreparo.Text = "Possui preparo?";
            chkPossuiPreparo.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(19, 104);
            txtTitulo.Margin = new Padding(4, 5, 4, 5);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(1098, 39);
            txtTitulo.TabIndex = 17;
            // 
            // textPreco
            // 
            textPreco.Location = new Point(11, 338);
            textPreco.Margin = new Padding(4, 5, 4, 5);
            textPreco.Name = "textPreco";
            textPreco.Size = new Size(273, 39);
            textPreco.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(textPreco);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(chkPossuiPreparo);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(18, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1511, 549);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardápio";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Chartreuse;
            btnSalvar.Location = new Point(1328, 458);
            btnSalvar.Margin = new Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(176, 71);
            btnSalvar.TabIndex = 22;
            btnSalvar.Text = "% Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(19, 173);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(1090, 109);
            txtDescricao.TabIndex = 19;
            txtDescricao.Text = "";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(1121, 458);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(187, 71);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "% Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1541, 691);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            Text = "FrmCardapioCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button btnFechar;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkPossuiPreparo;
        private TextBox txtTitulo;
        private TextBox textPreco;
        private GroupBox groupBox1;
        private RichTextBox txtDescricao;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}