namespace Orden_Pizza
{
    partial class frmPrincipal
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
            this.cmbPasta = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.npdCantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkEnsalada = new System.Windows.Forms.CheckBox();
            this.chkChile = new System.Windows.Forms.CheckBox();
            this.chkQueso = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnGrande = new System.Windows.Forms.RadioButton();
            this.rbtnMediana = new System.Windows.Forms.RadioButton();
            this.rbtnPersonal = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPasta);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.npdCantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(352, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza";
            // 
            // cmbPasta
            // 
            this.cmbPasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPasta.FormattingEnabled = true;
            this.cmbPasta.Location = new System.Drawing.Point(132, 194);
            this.cmbPasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPasta.Name = "cmbPasta";
            this.cmbPasta.Size = new System.Drawing.Size(200, 28);
            this.cmbPasta.TabIndex = 5;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(132, 126);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(200, 28);
            this.cmbTipo.TabIndex = 4;
            // 
            // npdCantidad
            // 
            this.npdCantidad.Location = new System.Drawing.Point(136, 57);
            this.npdCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.npdCantidad.Name = "npdCantidad";
            this.npdCantidad.Size = new System.Drawing.Size(116, 26);
            this.npdCantidad.TabIndex = 3;
            this.npdCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pizza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkEnsalada);
            this.groupBox2.Controls.Add(this.chkChile);
            this.groupBox2.Controls.Add(this.chkQueso);
            this.groupBox2.Location = new System.Drawing.Point(418, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(235, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras";
            // 
            // chkEnsalada
            // 
            this.chkEnsalada.AutoSize = true;
            this.chkEnsalada.Location = new System.Drawing.Point(71, 161);
            this.chkEnsalada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEnsalada.Name = "chkEnsalada";
            this.chkEnsalada.Size = new System.Drawing.Size(95, 24);
            this.chkEnsalada.TabIndex = 2;
            this.chkEnsalada.Text = "Ensalada";
            this.chkEnsalada.UseVisualStyleBackColor = true;
            // 
            // chkChile
            // 
            this.chkChile.AutoSize = true;
            this.chkChile.Location = new System.Drawing.Point(71, 99);
            this.chkChile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkChile.Name = "chkChile";
            this.chkChile.Size = new System.Drawing.Size(63, 24);
            this.chkChile.TabIndex = 1;
            this.chkChile.Text = "Chile";
            this.chkChile.UseVisualStyleBackColor = true;
            // 
            // chkQueso
            // 
            this.chkQueso.AutoSize = true;
            this.chkQueso.Location = new System.Drawing.Point(71, 38);
            this.chkQueso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkQueso.Name = "chkQueso";
            this.chkQueso.Size = new System.Drawing.Size(75, 24);
            this.chkQueso.TabIndex = 0;
            this.chkQueso.Text = "Queso";
            this.chkQueso.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnGrande);
            this.groupBox3.Controls.Add(this.rbtnMediana);
            this.groupBox3.Controls.Add(this.rbtnPersonal);
            this.groupBox3.Location = new System.Drawing.Point(18, 274);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(635, 104);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tamaño";
            // 
            // rbtnGrande
            // 
            this.rbtnGrande.AutoSize = true;
            this.rbtnGrande.Location = new System.Drawing.Point(452, 43);
            this.rbtnGrande.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnGrande.Name = "rbtnGrande";
            this.rbtnGrande.Size = new System.Drawing.Size(81, 24);
            this.rbtnGrande.TabIndex = 2;
            this.rbtnGrande.TabStop = true;
            this.rbtnGrande.Text = "Grande";
            this.rbtnGrande.UseVisualStyleBackColor = true;
            // 
            // rbtnMediana
            // 
            this.rbtnMediana.AutoSize = true;
            this.rbtnMediana.Location = new System.Drawing.Point(277, 43);
            this.rbtnMediana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnMediana.Name = "rbtnMediana";
            this.rbtnMediana.Size = new System.Drawing.Size(88, 24);
            this.rbtnMediana.TabIndex = 1;
            this.rbtnMediana.TabStop = true;
            this.rbtnMediana.Text = "Mediana";
            this.rbtnMediana.UseVisualStyleBackColor = true;
            // 
            // rbtnPersonal
            // 
            this.rbtnPersonal.AutoSize = true;
            this.rbtnPersonal.Location = new System.Drawing.Point(78, 43);
            this.rbtnPersonal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnPersonal.Name = "rbtnPersonal";
            this.rbtnPersonal.Size = new System.Drawing.Size(89, 24);
            this.rbtnPersonal.TabIndex = 0;
            this.rbtnPersonal.TabStop = true;
            this.rbtnPersonal.Text = "Personal";
            this.rbtnPersonal.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(24, 474);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(194, 46);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 394);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(150, 388);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(194, 26);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 754);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(260, 474);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(194, 46);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Location = new System.Drawing.Point(483, 474);
            this.btnCalculadora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(194, 46);
            this.btnCalculadora.TabIndex = 7;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 542);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzeria Master Chef";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPasta;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericUpDown npdCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkEnsalada;
        private System.Windows.Forms.CheckBox chkChile;
        private System.Windows.Forms.CheckBox chkQueso;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnGrande;
        private System.Windows.Forms.RadioButton rbtnMediana;
        private System.Windows.Forms.RadioButton rbtnPersonal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCalculadora;
    }
}

