
namespace ControleKitSala
{
    partial class TelaPesquisaKitSala
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewKitSala = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleDataShow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesqTodosKitSala = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodigoKitSala = new System.Windows.Forms.TextBox();
            this.btnBuscaKitSala = new System.Windows.Forms.Button();
            this.checkBoxPreto = new System.Windows.Forms.CheckBox();
            this.checkBoxAzul = new System.Windows.Forms.CheckBox();
            this.checkBoxChave = new System.Windows.Forms.CheckBox();
            this.checkBoxApagador = new System.Windows.Forms.CheckBox();
            this.checkBoxConData = new System.Windows.Forms.CheckBox();
            this.checkBoxConAr = new System.Windows.Forms.CheckBox();
            this.tbkitSala = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitSala)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 57);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 329);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewKitSala);
            this.tabPage1.Controls.Add(this.btnPesqTodosKitSala);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(555, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisa Tudo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKitSala
            // 
            this.dataGridViewKitSala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitSala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.sala,
            this.controleAr,
            this.controleDataShow,
            this.chave});
            this.dataGridViewKitSala.Location = new System.Drawing.Point(2, 79);
            this.dataGridViewKitSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewKitSala.Name = "dataGridViewKitSala";
            this.dataGridViewKitSala.RowHeadersWidth = 62;
            this.dataGridViewKitSala.RowTemplate.Height = 33;
            this.dataGridViewKitSala.Size = new System.Drawing.Size(553, 212);
            this.dataGridViewKitSala.TabIndex = 1;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 8;
            this.codigo.Name = "codigo";
            // 
            // sala
            // 
            this.sala.HeaderText = "Sala";
            this.sala.MinimumWidth = 8;
            this.sala.Name = "sala";
            // 
            // controleAr
            // 
            this.controleAr.HeaderText = "Controle Ar";
            this.controleAr.MinimumWidth = 8;
            this.controleAr.Name = "controleAr";
            // 
            // controleDataShow
            // 
            this.controleDataShow.HeaderText = "Controle DataShow";
            this.controleDataShow.MinimumWidth = 8;
            this.controleDataShow.Name = "controleDataShow";
            // 
            // chave
            // 
            this.chave.HeaderText = "Chave";
            this.chave.MinimumWidth = 8;
            this.chave.Name = "chave";
            // 
            // btnPesqTodosKitSala
            // 
            this.btnPesqTodosKitSala.Location = new System.Drawing.Point(163, 21);
            this.btnPesqTodosKitSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesqTodosKitSala.Name = "btnPesqTodosKitSala";
            this.btnPesqTodosKitSala.Size = new System.Drawing.Size(212, 35);
            this.btnPesqTodosKitSala.TabIndex = 0;
            this.btnPesqTodosKitSala.Text = "Pesquisar Todos os Kit Salas";
            this.btnPesqTodosKitSala.UseVisualStyleBackColor = true;
            this.btnPesqTodosKitSala.Click += new System.EventHandler(this.btnPesqTodosKitSala_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbCodigoKitSala);
            this.tabPage2.Controls.Add(this.btnBuscaKitSala);
            this.tabPage2.Controls.Add(this.checkBoxPreto);
            this.tabPage2.Controls.Add(this.checkBoxAzul);
            this.tabPage2.Controls.Add(this.checkBoxChave);
            this.tabPage2.Controls.Add(this.checkBoxApagador);
            this.tabPage2.Controls.Add(this.checkBoxConData);
            this.tabPage2.Controls.Add(this.checkBoxConAr);
            this.tabPage2.Controls.Add(this.tbkitSala);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(555, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa por Código";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(304, 261);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(107, 27);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(416, 261);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(107, 26);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Apagar";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(34, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Digite o Código do Kit Sala";
            // 
            // tbCodigoKitSala
            // 
            this.tbCodigoKitSala.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbCodigoKitSala.Location = new System.Drawing.Point(280, 46);
            this.tbCodigoKitSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodigoKitSala.Name = "tbCodigoKitSala";
            this.tbCodigoKitSala.Size = new System.Drawing.Size(105, 27);
            this.tbCodigoKitSala.TabIndex = 20;
            this.tbCodigoKitSala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscaKitSala
            // 
            this.btnBuscaKitSala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaKitSala.Location = new System.Drawing.Point(408, 46);
            this.btnBuscaKitSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscaKitSala.Name = "btnBuscaKitSala";
            this.btnBuscaKitSala.Size = new System.Drawing.Size(119, 27);
            this.btnBuscaKitSala.TabIndex = 21;
            this.btnBuscaKitSala.Text = "Pesquisar";
            this.btnBuscaKitSala.UseVisualStyleBackColor = true;
            this.btnBuscaKitSala.Click += new System.EventHandler(this.btnBuscaKitSala_Click);
            // 
            // checkBoxPreto
            // 
            this.checkBoxPreto.AutoSize = true;
            this.checkBoxPreto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPreto.Location = new System.Drawing.Point(316, 220);
            this.checkBoxPreto.Name = "checkBoxPreto";
            this.checkBoxPreto.Size = new System.Drawing.Size(211, 29);
            this.checkBoxPreto.TabIndex = 18;
            this.checkBoxPreto.Text = "Canetão Digital Preto";
            this.checkBoxPreto.UseVisualStyleBackColor = true;
            // 
            // checkBoxAzul
            // 
            this.checkBoxAzul.AutoSize = true;
            this.checkBoxAzul.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAzul.Location = new System.Drawing.Point(316, 181);
            this.checkBoxAzul.Name = "checkBoxAzul";
            this.checkBoxAzul.Size = new System.Drawing.Size(203, 29);
            this.checkBoxAzul.TabIndex = 17;
            this.checkBoxAzul.Text = "Canetão Digital Azul";
            this.checkBoxAzul.UseVisualStyleBackColor = true;
            // 
            // checkBoxChave
            // 
            this.checkBoxChave.AutoSize = true;
            this.checkBoxChave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxChave.Location = new System.Drawing.Point(316, 146);
            this.checkBoxChave.Name = "checkBoxChave";
            this.checkBoxChave.Size = new System.Drawing.Size(149, 29);
            this.checkBoxChave.TabIndex = 16;
            this.checkBoxChave.Text = "Chave da Sala";
            this.checkBoxChave.UseVisualStyleBackColor = true;
            // 
            // checkBoxApagador
            // 
            this.checkBoxApagador.AutoSize = true;
            this.checkBoxApagador.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxApagador.Location = new System.Drawing.Point(15, 220);
            this.checkBoxApagador.Name = "checkBoxApagador";
            this.checkBoxApagador.Size = new System.Drawing.Size(248, 29);
            this.checkBoxApagador.TabIndex = 15;
            this.checkBoxApagador.Text = "Apagador da lousa digital";
            this.checkBoxApagador.UseVisualStyleBackColor = true;
            // 
            // checkBoxConData
            // 
            this.checkBoxConData.AutoSize = true;
            this.checkBoxConData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxConData.Location = new System.Drawing.Point(15, 181);
            this.checkBoxConData.Name = "checkBoxConData";
            this.checkBoxConData.Size = new System.Drawing.Size(221, 29);
            this.checkBoxConData.TabIndex = 14;
            this.checkBoxConData.Text = "Controle do DataShow";
            this.checkBoxConData.UseVisualStyleBackColor = true;
            // 
            // checkBoxConAr
            // 
            this.checkBoxConAr.AutoSize = true;
            this.checkBoxConAr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxConAr.Location = new System.Drawing.Point(15, 146);
            this.checkBoxConAr.Name = "checkBoxConAr";
            this.checkBoxConAr.Size = new System.Drawing.Size(278, 29);
            this.checkBoxConAr.TabIndex = 13;
            this.checkBoxConAr.Text = "Controle do Ar Condicionado";
            this.checkBoxConAr.UseVisualStyleBackColor = true;
            // 
            // tbkitSala
            // 
            this.tbkitSala.Location = new System.Drawing.Point(191, 92);
            this.tbkitSala.Name = "tbkitSala";
            this.tbkitSala.Size = new System.Drawing.Size(100, 23);
            this.tbkitSala.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Itens:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kit Sala:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa de Kit Sala";
            // 
            // TelaPesquisaKitSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TelaPesquisaKitSala";
            this.Text = "TelaPesquisaKitSala";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitSala)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxPreto;
        private System.Windows.Forms.CheckBox checkBoxAzul;
        private System.Windows.Forms.CheckBox checkBoxChave;
        private System.Windows.Forms.CheckBox checkBoxApagador;
        private System.Windows.Forms.CheckBox checkBoxConData;
        private System.Windows.Forms.CheckBox checkBoxConAr;
        private System.Windows.Forms.TextBox tbkitSala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodigoKitSala;
        private System.Windows.Forms.Button btnBuscaKitSala;
        private System.Windows.Forms.DataGridView dataGridViewKitSala;
        private System.Windows.Forms.Button btnPesqTodosKitSala;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn controleAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn controleDataShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn chave;
    }
}