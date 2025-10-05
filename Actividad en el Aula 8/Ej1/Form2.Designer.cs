namespace Ej1
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            tbPatente = new TextBox();
            tbImporte = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(12, 269);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(267, 70);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(318, 269);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(295, 72);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 72);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 2;
            label1.Text = "Patente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 172);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 3;
            label2.Text = "Importe:";
            // 
            // tbPatente
            // 
            tbPatente.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tbPatente.Location = new Point(151, 72);
            tbPatente.Multiline = true;
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(164, 31);
            tbPatente.TabIndex = 4;
            // 
            // tbImporte
            // 
            tbImporte.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tbImporte.Location = new Point(151, 169);
            tbImporte.Multiline = true;
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(164, 31);
            tbImporte.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 374);
            Controls.Add(tbImporte);
            Controls.Add(tbPatente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        public TextBox tbPatente;
        public TextBox tbImporte;
    }
}