namespace SenacFoods
{
    partial class FrmCardápio
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
            btnAdicionar = new Button();
            dataGridView1 = new DataGridView();
            btnExcluir = new Button();
            btnEditar = new Button();
            label1 = new Label();
            txtPesquisa = new TextBox();
            button3 = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(43, 128);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1490, 563);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardápio";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Yellow;
            btnAdicionar.Location = new Point(153, -14);
            btnAdicionar.Margin = new Padding(4, 5, 4, 5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(147, 47);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "+ Item";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(4, 43);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1482, 515);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.OrangeRed;
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Location = new Point(1136, 696);
            btnExcluir.Margin = new Padding(4, 5, 4, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(167, 59);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "% Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Chartreuse;
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(1324, 696);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(175, 59);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "% Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 38);
            label1.TabIndex = 3;
            label1.Text = "Pesquisar:";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(152, 31);
            txtPesquisa.Margin = new Padding(4, 5, 4, 5);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(1098, 45);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
            button3.Location = new Point(1481, 3);
            button3.Name = "button3";
            button3.Size = new Size(62, 51);
            button3.TabIndex = 5;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnFecharCardapiocs;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aquamarine;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(txtPesquisa);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1546, 121);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // FrmCardápio
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 934);
            Controls.Add(panel1);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmCardápio";
            Text = "FrmCardápio";
            Load += FrmCardápio_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnExcluir;
        private Button btnEditar;
        private Label label1;
        private TextBox txtPesquisa;
        private Button btnAdicionar;
        private Button button3;
        private Panel panel1;
    }
}