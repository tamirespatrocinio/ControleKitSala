
namespace ControleKitSala
{
    partial class TelaFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomeFun = new System.Windows.Forms.TextBox();
            this.tbEmailFun = new System.Windows.Forms.TextBox();
            this.tbChapaFun = new System.Windows.Forms.TextBox();
            this.btnSalvarFun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(219, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(134, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(134, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(133, 407);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chapa: ";
            // 
            // tbNomeFun
            // 
            this.tbNomeFun.Location = new System.Drawing.Point(130, 247);
            this.tbNomeFun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNomeFun.Name = "tbNomeFun";
            this.tbNomeFun.Size = new System.Drawing.Size(440, 31);
            this.tbNomeFun.TabIndex = 4;
            // 
            // tbEmailFun
            // 
            this.tbEmailFun.Location = new System.Drawing.Point(130, 345);
            this.tbEmailFun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmailFun.Name = "tbEmailFun";
            this.tbEmailFun.Size = new System.Drawing.Size(440, 31);
            this.tbEmailFun.TabIndex = 5;
            // 
            // tbChapaFun
            // 
            this.tbChapaFun.Location = new System.Drawing.Point(130, 445);
            this.tbChapaFun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbChapaFun.Name = "tbChapaFun";
            this.tbChapaFun.Size = new System.Drawing.Size(137, 31);
            this.tbChapaFun.TabIndex = 6;
            // 
            // btnSalvarFun
            // 
            this.btnSalvarFun.Location = new System.Drawing.Point(454, 508);
            this.btnSalvarFun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvarFun.Name = "btnSalvarFun";
            this.btnSalvarFun.Size = new System.Drawing.Size(117, 55);
            this.btnSalvarFun.TabIndex = 7;
            this.btnSalvarFun.Text = "Salvar";
            this.btnSalvarFun.UseVisualStyleBackColor = true;
            this.btnSalvarFun.Click += new System.EventHandler(this.btnSalvarFun_Click);
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 690);
            this.Controls.Add(this.btnSalvarFun);
            this.Controls.Add(this.tbChapaFun);
            this.Controls.Add(this.tbEmailFun);
            this.Controls.Add(this.tbNomeFun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TelaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNomeFun;
        private System.Windows.Forms.TextBox tbEmailFun;
        private System.Windows.Forms.TextBox tbChapaFun;
        private System.Windows.Forms.Button btnSalvarFun;
    }
}