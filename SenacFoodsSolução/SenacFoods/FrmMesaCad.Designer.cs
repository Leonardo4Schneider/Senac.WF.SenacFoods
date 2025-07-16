namespace SenacFoods
{
    partial class FrmMesaCad
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            btnFechar = new Button();
            groupBox1 = new GroupBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtNumeroMesa = new TextBox();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aquamarine;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnFechar);
            panel1.Location = new Point(-6, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1569, 125);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(108, 52);
            label1.Name = "label1";
            label1.Size = new Size(215, 41);
            label1.TabIndex = 6;
            label1.Text = "Cadastro Mesa";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(txtNumeroMesa);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1511, 549);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesa";
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
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(1116, 458);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(187, 71);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "% Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNumeroMesa
            // 
            txtNumeroMesa.Location = new Point(19, 104);
            txtNumeroMesa.Margin = new Padding(4, 5, 4, 5);
            txtNumeroMesa.Name = "txtNumeroMesa";
            txtNumeroMesa.Size = new Size(1098, 39);
            txtNumeroMesa.TabIndex = 17;
            txtNumeroMesa.TextChanged += txtNumeroMesa_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 67);
            label2.Name = "label2";
            label2.Size = new Size(199, 32);
            label2.TabIndex = 12;
            label2.Text = "Numero da Mesa";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FrmMesaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 692);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesaCad";
            Text = "FrmMesaCad";
            Load += FrmMesaCad_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnFechar;
        private GroupBox groupBox1;
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txtNumeroMesa;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
    }
}