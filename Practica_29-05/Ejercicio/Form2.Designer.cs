namespace Ejercicio
{
    partial class Form2
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
            lbExpedientes = new Label();
            Button = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbExpedientes
            // 
            lbExpedientes.Location = new Point(12, 40);
            lbExpedientes.Name = "lbExpedientes";
            lbExpedientes.Size = new Size(776, 347);
            lbExpedientes.TabIndex = 0;
            // 
            // Button
            // 
            Button.DialogResult = DialogResult.Cancel;
            Button.Location = new Point(367, 415);
            Button.Name = "Button";
            Button.Size = new Size(75, 23);
            Button.TabIndex = 1;
            Button.Text = "Cerrar";
            Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Expedientes:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Button);
            Controls.Add(lbExpedientes);
            Name = "Form2";
            Text = "Ver Expediente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Button;
        public Label lbExpedientes;
    }
}