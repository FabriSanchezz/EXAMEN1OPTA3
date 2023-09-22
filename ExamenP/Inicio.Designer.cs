namespace ExamenP
{
    partial class Inicio
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
            this.btn_Ciudad = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_Cuentas = new System.Windows.Forms.Button();
            this.btn_Persona = new System.Windows.Forms.Button();
            this.btn_movimiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ciudad
            // 
            this.btn_Ciudad.Location = new System.Drawing.Point(60, 74);
            this.btn_Ciudad.Name = "btn_Ciudad";
            this.btn_Ciudad.Size = new System.Drawing.Size(75, 152);
            this.btn_Ciudad.TabIndex = 0;
            this.btn_Ciudad.Text = "Ciudad";
            this.btn_Ciudad.UseVisualStyleBackColor = true;
            this.btn_Ciudad.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.Location = new System.Drawing.Point(359, 74);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(75, 152);
            this.btn_cliente.TabIndex = 1;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Cuentas
            // 
            this.btn_Cuentas.Location = new System.Drawing.Point(518, 74);
            this.btn_Cuentas.Name = "btn_Cuentas";
            this.btn_Cuentas.Size = new System.Drawing.Size(75, 152);
            this.btn_Cuentas.TabIndex = 3;
            this.btn_Cuentas.Text = "Cuenta";
            this.btn_Cuentas.UseVisualStyleBackColor = true;
            this.btn_Cuentas.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btn_Persona
            // 
            this.btn_Persona.Location = new System.Drawing.Point(666, 74);
            this.btn_Persona.Name = "btn_Persona";
            this.btn_Persona.Size = new System.Drawing.Size(75, 152);
            this.btn_Persona.TabIndex = 4;
            this.btn_Persona.Text = "Persona";
            this.btn_Persona.UseVisualStyleBackColor = true;
            this.btn_Persona.Click += new System.EventHandler(this.btn_Persona_Click);
            // 
            // btn_movimiento
            // 
            this.btn_movimiento.Location = new System.Drawing.Point(213, 74);
            this.btn_movimiento.Name = "btn_movimiento";
            this.btn_movimiento.Size = new System.Drawing.Size(75, 152);
            this.btn_movimiento.TabIndex = 5;
            this.btn_movimiento.Text = "Movimiento";
            this.btn_movimiento.UseVisualStyleBackColor = true;
            this.btn_movimiento.Click += new System.EventHandler(this.btn_movimiento_Click_1);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_movimiento);
            this.Controls.Add(this.btn_Persona);
            this.Controls.Add(this.btn_Cuentas);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_Ciudad);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Ciudad;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_Cuentas;
        private System.Windows.Forms.Button btn_Persona;
        private System.Windows.Forms.Button btn_movimiento;
    }
}

