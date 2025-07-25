namespace SenacFoods
{
    partial class FrmComandaCad
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
            txtTitulo = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            btnAdicionar = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aquamarine;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnFechar);
            panel1.Location = new Point(-16, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1602, 148);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(129, 51);
            label1.Name = "label1";
            label1.Size = new Size(146, 41);
            label1.TabIndex = 6;
            label1.Text = "Comanda";
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
            // txtTitulo
            // 
            txtTitulo.Location = new Point(19, 104);
            txtTitulo.Margin = new Padding(4, 5, 4, 5);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(1071, 39);
            txtTitulo.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 67);
            label2.Name = "label2";
            label2.Size = new Size(197, 32);
            label2.TabIndex = 12;
            label2.Text = "Nome do Cliente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(4, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1562, 540);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comanda";
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
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(121, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(969, 40);
            comboBox1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 161);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 24;
            label3.Text = "Mesa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 232);
            label4.Name = "label4";
            label4.Size = new Size(109, 32);
            label4.TabIndex = 25;
            label4.Text = "Cardápio";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(121, 229);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(969, 40);
            comboBox2.TabIndex = 26;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Yellow;
            btnAdicionar.Location = new Point(1121, 229);
            btnAdicionar.Margin = new Padding(4, 5, 4, 5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(126, 44);
            btnAdicionar.TabIndex = 27;
            btnAdicionar.Text = "+ Item";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(121, 295);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(969, 225);
            dataGridView1.TabIndex = 28;
            // 
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 704);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComandaCad";
            Text = "FrmComandaCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnFechar;
        private TextBox txtTitulo;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Button btnSalvar;
        private Button btnCancelar;
        private ComboBox comboBox2;
        private Label label4;
        private Button btnAdicionar;
        private DataGridView dataGridView1;
    }
}