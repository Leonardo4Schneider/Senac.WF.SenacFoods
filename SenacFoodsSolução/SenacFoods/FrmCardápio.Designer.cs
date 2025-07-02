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
            btnExcluirCardapio = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
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
            groupBox1.Controls.Add(btnExcluirCardapio);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(43, 128);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1490, 563);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardápio";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Yellow;
            btnAdicionar.Location = new Point(60, 48);
            btnAdicionar.Margin = new Padding(4, 5, 4, 5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(168, 52);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "+ Item";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluirCardapio
            // 
            btnExcluirCardapio.BackColor = Color.OrangeRed;
            btnExcluirCardapio.ForeColor = Color.Black;
            btnExcluirCardapio.Location = new Point(1090, 424);
            btnExcluirCardapio.Margin = new Padding(4, 5, 4, 5);
            btnExcluirCardapio.Name = "btnExcluirCardapio";
            btnExcluirCardapio.Size = new Size(167, 59);
            btnExcluirCardapio.TabIndex = 1;
            btnExcluirCardapio.Text = "% Excluir";
            btnExcluirCardapio.UseVisualStyleBackColor = false;
            btnExcluirCardapio.Click += btnExcluirCardapio_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Chartreuse;
            button2.Location = new Point(1276, 424);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(175, 59);
            button2.TabIndex = 2;
            button2.Text = "% Editar";
            button2.UseVisualStyleBackColor = false;
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
            // 
            // FrmCardápio
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 934);
            Controls.Add(panel1);
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
        private Button btnExcluirCardapio;
        private Button button2;
        private Label label1;
        private TextBox txtPesquisa;
        private Button btnAdicionar;
        private Button button3;
        private Panel panel1;
    }
}