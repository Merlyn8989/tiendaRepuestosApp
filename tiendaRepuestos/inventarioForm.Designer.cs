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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comprarButton = new Button();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 131);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 4;
            label3.Text = "50";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 188);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 6;
            label4.Text = "50";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 248);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 8;
            label6.Text = "50";
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
            comprarButton.Location = new Point(107, 356);
            comprarButton.Name = "comprarButton";
            comprarButton.Size = new Size(136, 29);
            comprarButton.TabIndex = 9;
            comprarButton.Text = "Realizar Compra";
            comprarButton.UseVisualStyleBackColor = true;
            // 
            // inventarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 471);
            Controls.Add(comprarButton);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button comprarButton;
    }
}