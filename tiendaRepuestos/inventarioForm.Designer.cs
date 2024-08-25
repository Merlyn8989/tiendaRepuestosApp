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
            tituloInventarioLabel = new Label();
            productoLabel = new Label();
            cantidadLabel = new Label();
            label2 = new Label();
            cantidadProducto1 = new Label();
            cantidadProducto2 = new Label();
            label5 = new Label();
            cantidadProducto3 = new Label();
            label7 = new Label();
            comprarButton = new Button();
            precioProducto3 = new Label();
            precioProducto2 = new Label();
            precioProducto1 = new Label();
            precioLabel = new Label();
            SuspendLayout();
            // 
            // tituloInventarioLabel
            // 
            tituloInventarioLabel.AutoSize = true;
            tituloInventarioLabel.Location = new Point(84, 38);
            tituloInventarioLabel.Name = "tituloInventarioLabel";
            tituloInventarioLabel.Size = new Size(159, 20);
            tituloInventarioLabel.TabIndex = 0;
            tituloInventarioLabel.Text = "Repuestos Disponibles";
            // 
            // productoLabel
            // 
            productoLabel.AutoSize = true;
            productoLabel.Location = new Point(50, 86);
            productoLabel.Name = "productoLabel";
            productoLabel.Size = new Size(69, 20);
            productoLabel.TabIndex = 1;
            productoLabel.Text = "Producto";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new Point(195, 86);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new Size(69, 20);
            cantidadLabel.TabIndex = 2;
            cantidadLabel.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 131);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 3;
            label2.Text = "Pastillas de freno";
            // 
            // cantidadProducto1
            // 
            cantidadProducto1.AutoSize = true;
            cantidadProducto1.Location = new Point(195, 131);
            cantidadProducto1.Name = "cantidadProducto1";
            cantidadProducto1.Size = new Size(25, 20);
            cantidadProducto1.TabIndex = 4;
            cantidadProducto1.Text = "50";
            // 
            // cantidadProducto2
            // 
            cantidadProducto2.AutoSize = true;
            cantidadProducto2.Location = new Point(195, 188);
            cantidadProducto2.Name = "cantidadProducto2";
            cantidadProducto2.Size = new Size(25, 20);
            cantidadProducto2.TabIndex = 6;
            cantidadProducto2.Text = "50";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 188);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 5;
            label5.Text = "Filtros de aceite";
            // 
            // cantidadProducto3
            // 
            cantidadProducto3.AutoSize = true;
            cantidadProducto3.Location = new Point(195, 248);
            cantidadProducto3.Name = "cantidadProducto3";
            cantidadProducto3.Size = new Size(25, 20);
            cantidadProducto3.TabIndex = 8;
            cantidadProducto3.Text = "50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 248);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 7;
            label7.Text = "Amortiguadores";
            // 
            // comprarButton
            // 
            comprarButton.Location = new Point(143, 325);
            comprarButton.Name = "comprarButton";
            comprarButton.Size = new Size(136, 29);
            comprarButton.TabIndex = 9;
            comprarButton.Text = "Realizar Compra";
            comprarButton.UseVisualStyleBackColor = true;
            // 
            // precioProducto3
            // 
            precioProducto3.AutoSize = true;
            precioProducto3.Location = new Point(294, 248);
            precioProducto3.Name = "precioProducto3";
            precioProducto3.Size = new Size(25, 20);
            precioProducto3.TabIndex = 13;
            precioProducto3.Text = "50";
            // 
            // precioProducto2
            // 
            precioProducto2.AutoSize = true;
            precioProducto2.Location = new Point(294, 188);
            precioProducto2.Name = "precioProducto2";
            precioProducto2.Size = new Size(25, 20);
            precioProducto2.TabIndex = 12;
            precioProducto2.Text = "50";
            // 
            // precioProducto1
            // 
            precioProducto1.AutoSize = true;
            precioProducto1.Location = new Point(294, 131);
            precioProducto1.Name = "precioProducto1";
            precioProducto1.Size = new Size(25, 20);
            precioProducto1.TabIndex = 11;
            precioProducto1.Text = "50";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new Point(294, 86);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new Size(50, 20);
            precioLabel.TabIndex = 10;
            precioLabel.Text = "Precio";
            // 
            // inventarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 400);
            Controls.Add(precioProducto3);
            Controls.Add(precioProducto2);
            Controls.Add(precioProducto1);
            Controls.Add(precioLabel);
            Controls.Add(comprarButton);
            Controls.Add(cantidadProducto3);
            Controls.Add(label7);
            Controls.Add(cantidadProducto2);
            Controls.Add(label5);
            Controls.Add(cantidadProducto1);
            Controls.Add(label2);
            Controls.Add(cantidadLabel);
            Controls.Add(productoLabel);
            Controls.Add(tituloInventarioLabel);
            Name = "inventarioForm";
            Text = "inventarioForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloInventarioLabel;
        private Label productoLabel;
        private Label cantidadLabel;
        private Label label2;
        private Label cantidadProducto1;
        private Label cantidadProducto2;
        private Label label5;
        private Label cantidadProducto3;
        private Label label7;
        private Button comprarButton;
        private Label precioProducto3;
        private Label precioProducto2;
        private Label precioProducto1;
        private Label precioLabel;
    }
}