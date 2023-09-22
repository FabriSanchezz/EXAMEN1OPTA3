namespace ExamenP.forms
{
    partial class FMovimientos
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boxIDMov = new System.Windows.Forms.TextBox();
            this.BoxFechadeMov = new System.Windows.Forms.TextBox();
            this.BoxTipodeMov = new System.Windows.Forms.TextBox();
            this.BoxSaldoA = new System.Windows.Forms.TextBox();
            this.BoxSaldoAct = new System.Windows.Forms.TextBox();
            this.BoxMontoMov = new System.Windows.Forms.TextBox();
            this.BoxCtaO = new System.Windows.Forms.TextBox();
            this.BoxCtaDest = new System.Windows.Forms.TextBox();
            this.BoxCanal = new System.Windows.Forms.TextBox();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gridmov = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridmov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdMovimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Movimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Movimiento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo Anterior";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saldo Actual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Monto Movimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(581, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cuenta Origen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(581, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cuenta Dest.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(586, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Canal";
            // 
            // boxIDMov
            // 
            this.boxIDMov.Location = new System.Drawing.Point(151, 28);
            this.boxIDMov.Name = "boxIDMov";
            this.boxIDMov.Size = new System.Drawing.Size(100, 20);
            this.boxIDMov.TabIndex = 10;
            // 
            // BoxFechadeMov
            // 
            this.BoxFechadeMov.Location = new System.Drawing.Point(177, 78);
            this.BoxFechadeMov.Name = "BoxFechadeMov";
            this.BoxFechadeMov.Size = new System.Drawing.Size(100, 20);
            this.BoxFechadeMov.TabIndex = 11;
            // 
            // BoxTipodeMov
            // 
            this.BoxTipodeMov.Location = new System.Drawing.Point(165, 128);
            this.BoxTipodeMov.Name = "BoxTipodeMov";
            this.BoxTipodeMov.Size = new System.Drawing.Size(100, 20);
            this.BoxTipodeMov.TabIndex = 12;
            // 
            // BoxSaldoA
            // 
            this.BoxSaldoA.Location = new System.Drawing.Point(424, 26);
            this.BoxSaldoA.Name = "BoxSaldoA";
            this.BoxSaldoA.Size = new System.Drawing.Size(100, 20);
            this.BoxSaldoA.TabIndex = 13;
            // 
            // BoxSaldoAct
            // 
            this.BoxSaldoAct.Location = new System.Drawing.Point(413, 78);
            this.BoxSaldoAct.Name = "BoxSaldoAct";
            this.BoxSaldoAct.Size = new System.Drawing.Size(100, 20);
            this.BoxSaldoAct.TabIndex = 14;
            // 
            // BoxMontoMov
            // 
            this.BoxMontoMov.Location = new System.Drawing.Point(454, 128);
            this.BoxMontoMov.Name = "BoxMontoMov";
            this.BoxMontoMov.Size = new System.Drawing.Size(100, 20);
            this.BoxMontoMov.TabIndex = 15;
            // 
            // BoxCtaO
            // 
            this.BoxCtaO.Location = new System.Drawing.Point(690, 39);
            this.BoxCtaO.Name = "BoxCtaO";
            this.BoxCtaO.Size = new System.Drawing.Size(100, 20);
            this.BoxCtaO.TabIndex = 16;
            // 
            // BoxCtaDest
            // 
            this.BoxCtaDest.Location = new System.Drawing.Point(688, 86);
            this.BoxCtaDest.Name = "BoxCtaDest";
            this.BoxCtaDest.Size = new System.Drawing.Size(100, 20);
            this.BoxCtaDest.TabIndex = 17;
            // 
            // BoxCanal
            // 
            this.BoxCanal.Location = new System.Drawing.Point(688, 128);
            this.BoxCanal.Name = "BoxCanal";
            this.BoxCanal.Size = new System.Drawing.Size(100, 20);
            this.BoxCanal.TabIndex = 18;
            // 
            // btn_añadir
            // 
            this.btn_añadir.Location = new System.Drawing.Point(24, 176);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(75, 23);
            this.btn_añadir.TabIndex = 19;
            this.btn_añadir.Text = "Añadir";
            this.btn_añadir.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(176, 176);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 20;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(349, 176);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 21;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(543, 176);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 22;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(704, 176);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 23;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // gridmov
            // 
            this.gridmov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmov.Location = new System.Drawing.Point(78, 205);
            this.gridmov.Name = "gridmov";
            this.gridmov.Size = new System.Drawing.Size(654, 121);
            this.gridmov.TabIndex = 24;
            this.gridmov.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridmov);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_añadir);
            this.Controls.Add(this.BoxCanal);
            this.Controls.Add(this.BoxCtaDest);
            this.Controls.Add(this.BoxCtaO);
            this.Controls.Add(this.BoxMontoMov);
            this.Controls.Add(this.BoxSaldoAct);
            this.Controls.Add(this.BoxSaldoA);
            this.Controls.Add(this.BoxTipodeMov);
            this.Controls.Add(this.BoxFechadeMov);
            this.Controls.Add(this.boxIDMov);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FMovimientos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridmov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boxIDMov;
        private System.Windows.Forms.TextBox BoxFechadeMov;
        private System.Windows.Forms.TextBox BoxTipodeMov;
        private System.Windows.Forms.TextBox BoxSaldoA;
        private System.Windows.Forms.TextBox BoxSaldoAct;
        private System.Windows.Forms.TextBox BoxMontoMov;
        private System.Windows.Forms.TextBox BoxCtaO;
        private System.Windows.Forms.TextBox BoxCtaDest;
        private System.Windows.Forms.TextBox BoxCanal;
        private System.Windows.Forms.Button btn_añadir;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView gridmov;
    }
}