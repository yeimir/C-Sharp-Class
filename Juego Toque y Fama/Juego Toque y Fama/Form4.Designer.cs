namespace Juego_Toque_y_Fama
{
    partial class Form4
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txttoques = new System.Windows.Forms.TextBox();
            this.txtfamas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntadivina = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumadivi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Escriba su numero";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(134, 85);
            this.txtnum.MaxLength = 4;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 23);
            this.txtnum.TabIndex = 18;
            this.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttoques
            // 
            this.txttoques.Location = new System.Drawing.Point(134, 119);
            this.txttoques.MaxLength = 1;
            this.txttoques.Name = "txttoques";
            this.txttoques.ReadOnly = true;
            this.txttoques.Size = new System.Drawing.Size(100, 23);
            this.txttoques.TabIndex = 17;
            this.txttoques.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtfamas
            // 
            this.txtfamas.Location = new System.Drawing.Point(134, 158);
            this.txtfamas.MaxLength = 1;
            this.txtfamas.Name = "txtfamas";
            this.txtfamas.ReadOnly = true;
            this.txtfamas.Size = new System.Drawing.Size(100, 23);
            this.txtfamas.TabIndex = 16;
            this.txtfamas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Adivina el numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Toques ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Famas ";
            // 
            // bntadivina
            // 
            this.bntadivina.Location = new System.Drawing.Point(107, 200);
            this.bntadivina.Name = "bntadivina";
            this.bntadivina.Size = new System.Drawing.Size(67, 23);
            this.bntadivina.TabIndex = 12;
            this.bntadivina.Text = "Adivinar";
            this.bntadivina.UseVisualStyleBackColor = true;
            this.bntadivina.Click += new System.EventHandler(this.bntadivina_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Experto";
            // 
            // txtnumadivi
            // 
            this.txtnumadivi.Location = new System.Drawing.Point(134, 49);
            this.txtnumadivi.MaxLength = 4;
            this.txtnumadivi.Name = "txtnumadivi";
            this.txtnumadivi.PasswordChar = '*';
            this.txtnumadivi.ReadOnly = true;
            this.txtnumadivi.Size = new System.Drawing.Size(100, 23);
            this.txtnumadivi.TabIndex = 10;
            this.txtnumadivi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 235);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txttoques);
            this.Controls.Add(this.txtfamas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntadivina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumadivi);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(262, 235);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(262, 235);
            this.Name = "Form4";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nivel Experto";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtnum;
        public System.Windows.Forms.TextBox txttoques;
        public System.Windows.Forms.TextBox txtfamas;
        public System.Windows.Forms.Button bntadivina;
        public System.Windows.Forms.TextBox txtnumadivi;
    }
}