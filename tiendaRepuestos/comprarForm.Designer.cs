namespace tiendaRepuestos
{
    partial class comprarForm
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
            eleccionProductoComboBox = new ComboBox();
            cantidadCompraTextBox = new TextBox();
            pagarButton = new Button();
            cancelarButton = new Button();
            productoCompraLabel = new Label();
            cantidadCompraLabel = new Label();
            SuspendLayout();
            // 
            // eleccionProductoComboBox
            // 
            eleccionProductoComboBox.FormattingEnabled = true;
            eleccionProductoComboBox.Location = new Point(180, 63);
            eleccionProductoComboBox.Name = "eleccionProductoComboBox";
            eleccionProductoComboBox.Size = new Size(151, 28);
            eleccionProductoComboBox.TabIndex = 0;
            // 
            // cantidadCompraTextBox
            // 
            cantidadCompraTextBox.Location = new Point(180, 132);
            cantidadCompraTextBox.Name = "cantidadCompraTextBox";
            cantidadCompraTextBox.Size = new Size(125, 27);
            cantidadCompraTextBox.TabIndex = 1;
            // 
            // pagarButton
            // 
            pagarButton.Location = new Point(62, 212);
            pagarButton.Name = "pagarButton";
            pagarButton.Size = new Size(94, 29);
            pagarButton.TabIndex = 2;
            pagarButton.Text = "Pagar";
            pagarButton.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(211, 212);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(94, 29);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            // 
            // productoCompraLabel
            // 
            productoCompraLabel.AutoSize = true;
            productoCompraLabel.Location = new Point(84, 71);
            productoCompraLabel.Name = "productoCompraLabel";
            productoCompraLabel.Size = new Size(72, 20);
            productoCompraLabel.TabIndex = 4;
            productoCompraLabel.Text = "Producto:";
            // 
            // cantidadCompraLabel
            // 
            cantidadCompraLabel.AutoSize = true;
            cantidadCompraLabel.Location = new Point(84, 132);
            cantidadCompraLabel.Name = "cantidadCompraLabel";
            cantidadCompraLabel.Size = new Size(72, 20);
            cantidadCompraLabel.TabIndex = 5;
            cantidadCompraLabel.Text = "Cantidad:";
            // 
            // comprarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 300);
            Controls.Add(cantidadCompraLabel);
            Controls.Add(productoCompraLabel);
            Controls.Add(cancelarButton);
            Controls.Add(pagarButton);
            Controls.Add(cantidadCompraTextBox);
            Controls.Add(eleccionProductoComboBox);
            Name = "comprarForm";
            Text = "comprarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox eleccionProductoComboBox;
        private TextBox cantidadCompraTextBox;
        private Button pagarButton;
        private Button cancelarButton;
        private Label productoCompraLabel;
        private Label cantidadCompraLabel;
    }
}