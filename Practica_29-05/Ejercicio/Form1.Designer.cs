namespace Ejercicio
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
            btnCargar = new Button();
            tbMonto = new TextBox();
            tbDNI = new TextBox();
            tbNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnVerExpedientes = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCargar);
            groupBox1.Controls.Add(tbMonto);
            groupBox1.Controls.Add(tbDNI);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(55, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(645, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar Datos";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(489, 77);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // tbMonto
            // 
            tbMonto.Location = new Point(169, 107);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new Size(237, 23);
            tbMonto.TabIndex = 5;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(169, 74);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(237, 23);
            tbDNI.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(169, 38);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(237, 23);
            tbNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 110);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Monto $";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 77);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 41);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // btnVerExpedientes
            // 
            btnVerExpedientes.Location = new Point(353, 488);
            btnVerExpedientes.Name = "btnVerExpedientes";
            btnVerExpedientes.Size = new Size(108, 23);
            btnVerExpedientes.TabIndex = 1;
            btnVerExpedientes.Text = "Ver Expedientes";
            btnVerExpedientes.UseVisualStyleBackColor = true;
            btnVerExpedientes.Click += btnVerExpedientes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 538);
            Controls.Add(btnVerExpedientes);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbDNI;
        private TextBox tbNombre;
        private Button btnCargar;
        private TextBox tbMonto;
        private Button btnVerExpedientes;
    }
}
