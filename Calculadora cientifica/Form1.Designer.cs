namespace Calculadora_cientifica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.gbCalculo = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPo = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtLq = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtWq = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtPn = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.EficienciaDelsistema = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbCalculo.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.EficienciaDelsistema.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btReiniciar);
            this.groupBox1.Controls.Add(this.btAceptar);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initial Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btReiniciar
            // 
            this.btReiniciar.Location = new System.Drawing.Point(62, 106);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(75, 43);
            this.btReiniciar.TabIndex = 3;
            this.btReiniciar.Text = "Restart";
            this.btReiniciar.UseVisualStyleBackColor = true;
            this.btReiniciar.Click += new System.EventHandler(this.btReiniciar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(205, 106);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 43);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Density";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.Num2);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox4.Location = new System.Drawing.Point(196, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 57);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Miu";
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(9, 19);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(100, 20);
            this.Num2.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.Num1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(28, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 57);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lamda";
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(9, 19);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(100, 20);
            this.Num1.TabIndex = 4;
            // 
            // gbCalculo
            // 
            this.gbCalculo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbCalculo.Controls.Add(this.groupBox6);
            this.gbCalculo.Controls.Add(this.groupBox7);
            this.gbCalculo.Controls.Add(this.groupBox8);
            this.gbCalculo.Controls.Add(this.groupBox9);
            this.gbCalculo.Controls.Add(this.groupBox10);
            this.gbCalculo.Controls.Add(this.groupBox11);
            this.gbCalculo.Controls.Add(this.EficienciaDelsistema);
            this.gbCalculo.Location = new System.Drawing.Point(382, 12);
            this.gbCalculo.Name = "gbCalculo";
            this.gbCalculo.Size = new System.Drawing.Size(348, 317);
            this.gbCalculo.TabIndex = 0;
            this.gbCalculo.TabStop = false;
            this.gbCalculo.Text = "Calculated Data";
            this.gbCalculo.Enter += new System.EventHandler(this.gbCalculo_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox6.Controls.Add(this.txtPo);
            this.groupBox6.Location = new System.Drawing.Point(27, 106);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(131, 57);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Po";
            // 
            // txtPo
            // 
            this.txtPo.Location = new System.Drawing.Point(21, 19);
            this.txtPo.Name = "txtPo";
            this.txtPo.Size = new System.Drawing.Size(100, 20);
            this.txtPo.TabIndex = 6;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox7.Controls.Add(this.txtLq);
            this.groupBox7.Location = new System.Drawing.Point(119, 241);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(131, 57);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lq";
            // 
            // txtLq
            // 
            this.txtLq.Location = new System.Drawing.Point(15, 19);
            this.txtLq.Name = "txtLq";
            this.txtLq.Size = new System.Drawing.Size(100, 20);
            this.txtLq.TabIndex = 11;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox8.Controls.Add(this.txtWq);
            this.groupBox8.Location = new System.Drawing.Point(201, 106);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(131, 57);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Wq";
            // 
            // txtWq
            // 
            this.txtWq.Location = new System.Drawing.Point(15, 19);
            this.txtWq.Name = "txtWq";
            this.txtWq.Size = new System.Drawing.Size(100, 20);
            this.txtWq.TabIndex = 10;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox9.Controls.Add(this.txtPn);
            this.groupBox9.Location = new System.Drawing.Point(201, 36);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(131, 57);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Pn";
            // 
            // txtPn
            // 
            this.txtPn.Location = new System.Drawing.Point(15, 19);
            this.txtPn.Name = "txtPn";
            this.txtPn.Size = new System.Drawing.Size(100, 20);
            this.txtPn.TabIndex = 9;
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox10.Controls.Add(this.txtW);
            this.groupBox10.Location = new System.Drawing.Point(201, 178);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(131, 57);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "W";
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(15, 19);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(100, 20);
            this.txtW.TabIndex = 7;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox11.Controls.Add(this.txtL);
            this.groupBox11.Location = new System.Drawing.Point(33, 178);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(131, 57);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "L";
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(15, 19);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(100, 20);
            this.txtL.TabIndex = 8;
            this.txtL.TextChanged += new System.EventHandler(this.txtL_TextChanged);
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(21, 19);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(100, 20);
            this.txtE.TabIndex = 5;
            // 
            // EficienciaDelsistema
            // 
            this.EficienciaDelsistema.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EficienciaDelsistema.Controls.Add(this.txtE);
            this.EficienciaDelsistema.Location = new System.Drawing.Point(27, 36);
            this.EficienciaDelsistema.Name = "EficienciaDelsistema";
            this.EficienciaDelsistema.Size = new System.Drawing.Size(131, 57);
            this.EficienciaDelsistema.TabIndex = 1;
            this.EficienciaDelsistema.TabStop = false;
            this.EficienciaDelsistema.Text = "Eficiencia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Developer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carlos Enrique Ulloa Martinez";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MI06B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCalculo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculadora cientifica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbCalculo.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.EficienciaDelsistema.ResumeLayout(false);
            this.EficienciaDelsistema.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btReiniciar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.GroupBox gbCalculo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtLq;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtWq;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtPn;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.GroupBox EficienciaDelsistema;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

