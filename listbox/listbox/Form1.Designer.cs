namespace listbox
{
    partial class Form1
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
            this.txtitem = new System.Windows.Forms.TextBox();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtselecionado = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnapagaritem = new System.Windows.Forms.Button();
            this.btnselecao = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.btnordenar = new System.Windows.Forms.Button();
            this.btnmselecao = new System.Windows.Forms.Button();
            this.lstitens = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // txtitem
            // 
            this.txtitem.Location = new System.Drawing.Point(73, 30);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(150, 20);
            this.txtitem.TabIndex = 1;
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(29, 249);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(150, 20);
            this.txtindice.TabIndex = 2;
            this.txtindice.Text = "Escreva Indice";
            // 
            // txtselecionado
            // 
            this.txtselecionado.Location = new System.Drawing.Point(29, 275);
            this.txtselecionado.Name = "txtselecionado";
            this.txtselecionado.Size = new System.Drawing.Size(150, 20);
            this.txtselecionado.TabIndex = 3;
            this.txtselecionado.Text = "Item Selecionado";
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(314, 27);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(114, 23);
            this.btnadicionar.TabIndex = 4;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(314, 70);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(114, 23);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "Limpar Tudo";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnapagaritem
            // 
            this.btnapagaritem.Location = new System.Drawing.Point(314, 111);
            this.btnapagaritem.Name = "btnapagaritem";
            this.btnapagaritem.Size = new System.Drawing.Size(114, 23);
            this.btnapagaritem.TabIndex = 6;
            this.btnapagaritem.Text = "Apagar Item";
            this.btnapagaritem.UseVisualStyleBackColor = true;
            this.btnapagaritem.Click += new System.EventHandler(this.btnapagaritem_Click);
            // 
            // btnselecao
            // 
            this.btnselecao.Location = new System.Drawing.Point(314, 155);
            this.btnselecao.Name = "btnselecao";
            this.btnselecao.Size = new System.Drawing.Size(114, 23);
            this.btnselecao.TabIndex = 7;
            this.btnselecao.Text = "apagar Seleção";
            this.btnselecao.UseVisualStyleBackColor = true;
            this.btnselecao.Click += new System.EventHandler(this.btnselecao_Click);
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(314, 202);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(114, 23);
            this.btninserir.TabIndex = 8;
            this.btninserir.Text = "Inserir Item";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // btnordenar
            // 
            this.btnordenar.Location = new System.Drawing.Point(314, 246);
            this.btnordenar.Name = "btnordenar";
            this.btnordenar.Size = new System.Drawing.Size(114, 23);
            this.btnordenar.TabIndex = 9;
            this.btnordenar.Text = "Ordenar";
            this.btnordenar.UseVisualStyleBackColor = true;
            this.btnordenar.Click += new System.EventHandler(this.btnordenar_Click);
            // 
            // btnmselecao
            // 
            this.btnmselecao.Location = new System.Drawing.Point(314, 282);
            this.btnmselecao.Name = "btnmselecao";
            this.btnmselecao.Size = new System.Drawing.Size(114, 23);
            this.btnmselecao.TabIndex = 10;
            this.btnmselecao.Text = "Mostrar Seleção";
            this.btnmselecao.UseVisualStyleBackColor = true;
            this.btnmselecao.Click += new System.EventHandler(this.btnmselecao_Click);
            // 
            // lstitens
            // 
            this.lstitens.FormattingEnabled = true;
            this.lstitens.Location = new System.Drawing.Point(29, 70);
            this.lstitens.Name = "lstitens";
            this.lstitens.Size = new System.Drawing.Size(194, 160);
            this.lstitens.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(460, 317);
            this.Controls.Add(this.lstitens);
            this.Controls.Add(this.btnmselecao);
            this.Controls.Add(this.btnordenar);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.btnselecao);
            this.Controls.Add(this.btnapagaritem);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.txtselecionado);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtselecionado;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnapagaritem;
        private System.Windows.Forms.Button btnselecao;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btnordenar;
        private System.Windows.Forms.Button btnmselecao;
        private System.Windows.Forms.ListBox lstitens;
    }
}

