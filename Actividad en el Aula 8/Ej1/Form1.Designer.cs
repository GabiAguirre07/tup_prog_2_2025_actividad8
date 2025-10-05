namespace Ej1
{
    partial class Modificar
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
            btnExportar = new Button();
            Listar = new Button();
            lbxVeh = new ListBox();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // btnExportar
            // 
            btnExportar.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExportar.Location = new Point(506, 340);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(237, 86);
            btnExportar.TabIndex = 1;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // Listar
            // 
            Listar.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Listar.Location = new Point(503, 77);
            Listar.Name = "Listar";
            Listar.Size = new Size(237, 86);
            Listar.TabIndex = 2;
            Listar.Text = "Listar";
            Listar.UseVisualStyleBackColor = true;
            Listar.Click += Listar_Click_1;
            // 
            // lbxVeh
            // 
            lbxVeh.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbxVeh.FormattingEnabled = true;
            lbxVeh.ItemHeight = 23;
            lbxVeh.Location = new Point(12, 9);
            lbxVeh.Name = "lbxVeh";
            lbxVeh.Size = new Size(485, 487);
            lbxVeh.TabIndex = 3;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(506, 210);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(237, 86);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Modificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 510);
            Controls.Add(btnModificar);
            Controls.Add(lbxVeh);
            Controls.Add(Listar);
            Controls.Add(btnExportar);
            Name = "Modificar";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnExportar;
        private Button Listar;
        private ListBox lbxVeh;
        private Button btnModificar;
    }
}
