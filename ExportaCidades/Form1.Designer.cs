namespace ExportaCidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGerar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rbSelecionado = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.siglaEstado = new System.Windows.Forms.ColumnHeader();
            this.regiaoNome = new System.Windows.Forms.ColumnHeader();
            this.nomeCidade = new System.Windows.Forms.ColumnHeader();
            this.nomeMesorregiao = new System.Windows.Forms.ColumnHeader();
            this.nomeFormatado = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(253, 476);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Visualizar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 441);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(654, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // rbSelecionado
            // 
            this.rbSelecionado.AutoSize = true;
            this.rbSelecionado.Location = new System.Drawing.Point(6, 33);
            this.rbSelecionado.Name = "rbSelecionado";
            this.rbSelecionado.Size = new System.Drawing.Size(246, 19);
            this.rbSelecionado.TabIndex = 1;
            this.rbSelecionado.TabStop = true;
            this.rbSelecionado.Text = "Apenas cidades dos estados selecionados:";
            this.rbSelecionado.UseVisualStyleBackColor = true;
            this.rbSelecionado.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.siglaEstado,
            this.regiaoNome,
            this.nomeCidade,
            this.nomeMesorregiao,
            this.nomeFormatado});
            this.listView1.Location = new System.Drawing.Point(12, 196);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(654, 234);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // siglaEstado
            // 
            this.siglaEstado.Text = "UF";
            this.siglaEstado.Width = 30;
            // 
            // regiaoNome
            // 
            this.regiaoNome.Text = "Nome Região";
            this.regiaoNome.Width = 200;
            // 
            // nomeCidade
            // 
            this.nomeCidade.Text = "Cidade";
            this.nomeCidade.Width = 140;
            // 
            // nomeMesorregiao
            // 
            this.nomeMesorregiao.Text = "Mesorregião";
            this.nomeMesorregiao.Width = 140;
            // 
            // nomeFormatado
            // 
            this.nomeFormatado.Text = "Cidade/UF";
            this.nomeFormatado.Width = 140;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Controls.Add(this.rbSelecionado);
            this.groupBox2.Controls.Add(this.rdTodos);
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 154);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(23, 60);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(246, 94);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.Visible = false;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // rdTodos
            // 
            this.rdTodos.AutoSize = true;
            this.rdTodos.Checked = true;
            this.rdTodos.Location = new System.Drawing.Point(6, 13);
            this.rdTodos.Name = "rdTodos";
            this.rdTodos.Size = new System.Drawing.Size(158, 19);
            this.rdTodos.TabIndex = 0;
            this.rdTodos.TabStop = true;
            this.rdTodos.Text = "Exportar todas as cidades";
            this.rdTodos.UseVisualStyleBackColor = true;
            this.rdTodos.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Exportar cidades Brasileiras";
            // 
            // btnExportar
            // 
            this.btnExportar.Enabled = false;
            this.btnExportar.Location = new System.Drawing.Point(355, 476);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(278, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar cidades Brasileiras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGerar;
        private ProgressBar progressBar1;
        private ListView listView1;
        private ColumnHeader siglaEstado;
        private ColumnHeader regiaoNome;
        private ColumnHeader nomeCidade;
        private ColumnHeader nomeMesorregiao;
        private ColumnHeader nomeFormatado;
        private GroupBox groupBox2;
        private RadioButton rbSelecionado;
        private RadioButton rdTodos;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Button btnExportar;
        private Label label2;
    }
}