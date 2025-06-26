namespace Ej1
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
            groupBox1 = new GroupBox();
            btnRegistrar = new Button();
            label1 = new Label();
            tbNumero = new TextBox();
            groupBox2 = new GroupBox();
            btnActualizarC = new Button();
            label6 = new Label();
            lbCantidad = new Label();
            groupBox3 = new GroupBox();
            tbValorABuscar = new TextBox();
            lbValorABuscar = new Label();
            label3 = new Label();
            btnBuscar = new Button();
            groupBox4 = new GroupBox();
            lbPromedio = new Label();
            btnActualizarP = new Button();
            label5 = new Label();
            groupBox5 = new GroupBox();
            btnActualizarMyM = new Button();
            lbMinimo = new Label();
            label4 = new Label();
            lbMaximo = new Label();
            label2 = new Label();
            groupBox6 = new GroupBox();
            btnSuperior = new Button();
            btnListaOrdenada = new Button();
            tbCantidadIngresados = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbNumero);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Procesar un  número";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(85, 91);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(179, 48);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar número";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 38);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 1;
            label1.Text = "Ingrese un número";
            // 
            // tbNumero
            // 
            tbNumero.Location = new Point(215, 38);
            tbNumero.Name = "tbNumero";
            tbNumero.Size = new Size(125, 34);
            tbNumero.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnActualizarC);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lbCantidad);
            groupBox2.Location = new Point(11, 493);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(438, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mostrar cantidad de ingresados";
            // 
            // btnActualizarC
            // 
            btnActualizarC.Location = new Point(295, 68);
            btnActualizarC.Name = "btnActualizarC";
            btnActualizarC.Size = new Size(114, 46);
            btnActualizarC.TabIndex = 1;
            btnActualizarC.Text = "Actualizar";
            btnActualizarC.UseVisualStyleBackColor = true;
            btnActualizarC.Click += btnActualizarC_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 68);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 3;
            label6.Text = "Cantidad:";
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.BackColor = SystemColors.ButtonHighlight;
            lbCantidad.Location = new Point(121, 68);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(65, 28);
            lbCantidad.TabIndex = 2;
            lbCantidad.Text = "label3";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbValorABuscar);
            groupBox3.Controls.Add(lbValorABuscar);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Location = new Point(512, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(322, 174);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Valor a buscar:";
            // 
            // tbValorABuscar
            // 
            tbValorABuscar.Location = new Point(74, 70);
            tbValorABuscar.Name = "tbValorABuscar";
            tbValorABuscar.Size = new Size(84, 34);
            tbValorABuscar.TabIndex = 1;
            // 
            // lbValorABuscar
            // 
            lbValorABuscar.AutoSize = true;
            lbValorABuscar.BackColor = SystemColors.ButtonHighlight;
            lbValorABuscar.Location = new Point(19, 128);
            lbValorABuscar.Name = "lbValorABuscar";
            lbValorABuscar.Size = new Size(65, 28);
            lbValorABuscar.TabIndex = 2;
            lbValorABuscar.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 30);
            label3.Name = "label3";
            label3.Size = new Size(229, 28);
            label3.TabIndex = 3;
            label3.Text = "Ingrese su valor a buscar:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(181, 64);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 47);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbPromedio);
            groupBox4.Controls.Add(btnActualizarP);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(12, 358);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(437, 125);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Procesar promedio";
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.BackColor = SystemColors.ButtonHighlight;
            lbPromedio.Location = new Point(120, 59);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(65, 28);
            lbPromedio.TabIndex = 1;
            lbPromedio.Text = "label3";
            // 
            // btnActualizarP
            // 
            btnActualizarP.Location = new Point(295, 41);
            btnActualizarP.Name = "btnActualizarP";
            btnActualizarP.Size = new Size(114, 46);
            btnActualizarP.TabIndex = 0;
            btnActualizarP.Text = "Actualizar";
            btnActualizarP.UseVisualStyleBackColor = true;
            btnActualizarP.Click += btnActualizarP_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 59);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 2;
            label5.Text = "Promedio:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnActualizarMyM);
            groupBox5.Controls.Add(lbMinimo);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(lbMaximo);
            groupBox5.Controls.Add(label2);
            groupBox5.Location = new Point(11, 169);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(438, 174);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Procesar máximo y mínimo";
            // 
            // btnActualizarMyM
            // 
            btnActualizarMyM.Location = new Point(296, 76);
            btnActualizarMyM.Name = "btnActualizarMyM";
            btnActualizarMyM.Size = new Size(113, 45);
            btnActualizarMyM.TabIndex = 4;
            btnActualizarMyM.Text = "Actualizar";
            btnActualizarMyM.UseVisualStyleBackColor = true;
            btnActualizarMyM.Click += btnActualizarMyM_Click;
            // 
            // lbMinimo
            // 
            lbMinimo.AutoSize = true;
            lbMinimo.BackColor = SystemColors.ButtonHighlight;
            lbMinimo.Location = new Point(121, 120);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(65, 28);
            lbMinimo.TabIndex = 3;
            lbMinimo.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 120);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 2;
            label4.Text = "Mínimo:";
            // 
            // lbMaximo
            // 
            lbMaximo.AutoSize = true;
            lbMaximo.BackColor = SystemColors.ButtonHighlight;
            lbMaximo.Location = new Point(121, 50);
            lbMaximo.Name = "lbMaximo";
            lbMaximo.Size = new Size(65, 28);
            lbMaximo.TabIndex = 1;
            lbMaximo.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 50);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 0;
            label2.Text = "Máximo:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tbCantidadIngresados);
            groupBox6.Controls.Add(btnSuperior);
            groupBox6.Controls.Add(btnListaOrdenada);
            groupBox6.Location = new Point(512, 228);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(344, 390);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Mostrar cantidad de ingresados";
            // 
            // btnSuperior
            // 
            btnSuperior.Location = new Point(208, 198);
            btnSuperior.Name = "btnSuperior";
            btnSuperior.Size = new Size(114, 151);
            btnSuperior.TabIndex = 7;
            btnSuperior.Text = "Mostrar Lista Superior al Promedio";
            btnSuperior.UseVisualStyleBackColor = true;
            btnSuperior.Click += btnSuperior_Click;
            // 
            // btnListaOrdenada
            // 
            btnListaOrdenada.Location = new Point(221, 61);
            btnListaOrdenada.Name = "btnListaOrdenada";
            btnListaOrdenada.Size = new Size(90, 102);
            btnListaOrdenada.TabIndex = 6;
            btnListaOrdenada.Text = "Mostrar Lista Ordenada";
            btnListaOrdenada.UseVisualStyleBackColor = true;
            btnListaOrdenada.Click += btnListaOrdenada_Click;
            // 
            // tbCantidadIngresados
            // 
            tbCantidadIngresados.Location = new Point(6, 55);
            tbCantidadIngresados.Multiline = true;
            tbCantidadIngresados.Name = "tbCantidadIngresados";
            tbCantidadIngresados.Size = new Size(186, 324);
            tbCantidadIngresados.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 630);
            Controls.Add(groupBox3);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistrar;
        private Label label1;
        private TextBox tbNumero;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button btnActualizarMyM;
        private Label label4;
        private Label lbMaximo;
        private Label label2;
        private GroupBox groupBox6;
        private Label lbMinimo;
        private Button btnActualizarC;
        private Label label6;
        private Label lbCantidad;
        private Label label3;
        private Button btnBuscar;
        private Label lbPromedio;
        private Button btnActualizarP;
        private Label label5;
        private TextBox tbValorABuscar;
        private Label lbValorABuscar;
        private Button btnSuperior;
        private Button btnListaOrdenada;
        private TextBox tbCantidadIngresados;
    }
}
