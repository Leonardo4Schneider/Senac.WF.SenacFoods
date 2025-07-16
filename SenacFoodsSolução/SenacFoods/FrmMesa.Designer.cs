namespace SenacFoods
{
    partial class FrmMesa
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
            button3 = new Button();
            txtPesquisa = new TextBox();
            groupBox1 = new GroupBox();
            btnAdicionar = new Button();
            btnExcluirMesa = new Button();
            btnEditar = new Button();
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
            panel1.Controls.Add(button3);
            panel1.Controls.Add(txtPesquisa);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1613, 104);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 3;
            label1.Text = "Pesquisar:";
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
            button3.Location = new Point(1538, 3);
            button3.Name = "button3";
            button3.Size = new Size(62, 51);
            button3.TabIndex = 5;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(152, 31);
            txtPesquisa.Margin = new Padding(4, 5, 4, 5);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(1098, 31);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(btnExcluirMesa);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(16, 141);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1490, 563);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesa";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Yellow;
            btnAdicionar.Location = new Point(60, 48);
            btnAdicionar.Margin = new Padding(4, 5, 4, 5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(168, 52);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "+ Item";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluirMesa
            // 
            btnExcluirMesa.BackColor = Color.OrangeRed;
            btnExcluirMesa.ForeColor = Color.Black;
            btnExcluirMesa.Location = new Point(1090, 424);
            btnExcluirMesa.Margin = new Padding(4, 5, 4, 5);
            btnExcluirMesa.Name = "btnExcluirMesa";
            btnExcluirMesa.Size = new Size(167, 59);
            btnExcluirMesa.TabIndex = 1;
            btnExcluirMesa.Text = "% Excluir";
            btnExcluirMesa.UseVisualStyleBackColor = false;
            btnExcluirMesa.Click += btnExcluirMesa_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Chartreuse;
            btnEditar.Location = new Point(1276, 424);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(175, 59);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "% Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 110);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1391, 288);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmMesa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1611, 642);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesa";
            Text = "FrmMesa";
            Load += FrmMesa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button3;
        private TextBox txtPesquisa;
        private GroupBox groupBox1;
        private Button btnExcluirMesa;
        private Button btnEditar;
        private DataGridView dataGridView1;
        private Button btnAdicionar;
    }
}