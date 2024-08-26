namespace tiendaRepuestos
{
    partial class registroForm
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
            tituloLabel = new Label();
            tituloRegistroLabel = new Label();
            nombreLabel = new Label();
            nombreTextBox = new TextBox();
            apellidoTextBox = new TextBox();
            apellidoLabel = new Label();
            fechaNacimientolabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            registrarseButton = new Button();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloLabel.Location = new Point(150, 45);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(189, 25);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "Tienda de Repuestos";
            // 
            // tituloRegistroLabel
            // 
            tituloRegistroLabel.AutoSize = true;
            tituloRegistroLabel.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloRegistroLabel.Location = new Point(150, 92);
            tituloRegistroLabel.Name = "tituloRegistroLabel";
            tituloRegistroLabel.Size = new Size(186, 17);
            tituloRegistroLabel.TabIndex = 1;
            tituloRegistroLabel.Text = "Regístrese para hacer su compra";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(124, 141);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(67, 20);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(214, 141);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(125, 27);
            nombreTextBox.TabIndex = 3;
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(214, 207);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(125, 27);
            apellidoTextBox.TabIndex = 5;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new Point(122, 210);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(69, 20);
            apellidoLabel.TabIndex = 4;
            apellidoLabel.Text = "Apellido:";
            // 
            // fechaNacimientolabel
            // 
            fechaNacimientolabel.AutoSize = true;
            fechaNacimientolabel.Location = new Point(42, 281);
            fechaNacimientolabel.Name = "fechaNacimientolabel";
            fechaNacimientolabel.Size = new Size(149, 20);
            fechaNacimientolabel.TabIndex = 6;
            fechaNacimientolabel.Text = "Fecha de nacimiento:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(214, 276);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(271, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // registrarseButton
            // 
            registrarseButton.Location = new Point(189, 343);
            registrarseButton.Name = "registrarseButton";
            registrarseButton.Size = new Size(94, 29);
            registrarseButton.TabIndex = 8;
            registrarseButton.Text = "Registrarse";
            registrarseButton.UseVisualStyleBackColor = true;
            // 
            // registroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 410);
            Controls.Add(registrarseButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(fechaNacimientolabel);
            Controls.Add(apellidoTextBox);
            Controls.Add(apellidoLabel);
            Controls.Add(nombreTextBox);
            Controls.Add(nombreLabel);
            Controls.Add(tituloRegistroLabel);
            Controls.Add(tituloLabel);
            Name = "registroForm";
            Text = "registroUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
        private Label tituloRegistroLabel;
        private Label nombreLabel;
        private TextBox nombreTextBox;
        private TextBox apellidoTextBox;
        private Label apellidoLabel;
        private Label fechaNacimientolabel;
        private DateTimePicker dateTimePicker1;
        private Button registrarseButton;
    }
}