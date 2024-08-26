namespace tiendaRepuestos
{
    partial class inventarioForm
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
            producto1Label = new Label();
            encabezadoLabel = new Label();
            producto2Label = new Label();
            producto3Label = new Label();
            SuspendLayout();
            // 
            // producto1Label
            // 
            producto1Label.AutoSize = true;
            producto1Label.Location = new Point(89, 105);
            producto1Label.Name = "producto1Label";
            producto1Label.Size = new Size(81, 20);
            producto1Label.TabIndex = 0;
            producto1Label.Text = "Producto 1";
            // 
            // encabezadoLabel
            // 
            encabezadoLabel.AutoSize = true;
            encabezadoLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            encabezadoLabel.Location = new Point(80, 55);
            encabezadoLabel.Name = "encabezadoLabel";
            encabezadoLabel.Size = new Size(384, 25);
            encabezadoLabel.TabIndex = 1;
            encabezadoLabel.Text = "Producto                  Cantidad               Precio";
            // 
            // producto2Label
            // 
            producto2Label.AutoSize = true;
            producto2Label.Location = new Point(89, 167);
            producto2Label.Name = "producto2Label";
            producto2Label.Size = new Size(81, 20);
            producto2Label.TabIndex = 2;
            producto2Label.Text = "Producto 2";
            // 
            // producto3Label
            // 
            producto3Label.AutoSize = true;
            producto3Label.Location = new Point(89, 227);
            producto3Label.Name = "producto3Label";
            producto3Label.Size = new Size(81, 20);
            producto3Label.TabIndex = 3;
            producto3Label.Text = "Producto 3";
            // 
            // inventarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(producto3Label);
            Controls.Add(producto2Label);
            Controls.Add(encabezadoLabel);
            Controls.Add(producto1Label);
            Name = "inventarioForm";
            Text = "inventarioForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label producto1Label;
        private Label encabezadoLabel;
        private Label producto2Label;
        private Label producto3Label;
    }
}