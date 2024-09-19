namespace ClinicaAPP
{
    partial class paciente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridViewPacientes = new DataGridView();
            cbSexo = new ComboBox();
            dtFechaNacimiento = new DateTimePicker();
            txtTelefono = new TextBox();
            txtIdentificacion = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 70);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre y Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(739, 70);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 3;
            label3.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 144);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 2;
            label4.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(400, 144);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 5;
            label5.Text = "Direccion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(739, 144);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 4;
            label6.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 220);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 6;
            label7.Text = "Correo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(478, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(255, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(481, 137);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(252, 27);
            txtDireccion.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(133, 213);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(1014, 27);
            txtCorreo.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(228, 272);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 12;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Location = new Point(424, 272);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 13;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(629, 272);
            button3.Name = "button3";
            button3.Size = new Size(140, 29);
            button3.TabIndex = 14;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 255, 255);
            button4.Location = new Point(849, 272);
            button4.Name = "button4";
            button4.Size = new Size(140, 29);
            button4.TabIndex = 15;
            button4.Text = "Consultar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridViewPacientes
            // 
            dataGridViewPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPacientes.Location = new Point(48, 341);
            dataGridViewPacientes.Name = "dataGridViewPacientes";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPacientes.RowHeadersWidth = 51;
            dataGridViewPacientes.RowTemplate.Height = 29;
            dataGridViewPacientes.Size = new Size(1099, 215);
            dataGridViewPacientes.TabIndex = 16;
            dataGridViewPacientes.CellClick += dataGridViewPacientes_CellClick;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cbSexo.Location = new Point(133, 136);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(261, 28);
            cbSexo.TabIndex = 17;
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Location = new Point(873, 65);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(274, 27);
            dtFechaNacimiento.TabIndex = 18;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(815, 136);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(332, 27);
            txtTelefono.TabIndex = 19;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(147, 63);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(180, 27);
            txtIdentificacion.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 70);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 20;
            label2.Text = "Identificacion:";
            // 
            // paciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 254);
            ClientSize = new Size(1179, 568);
            Controls.Add(txtIdentificacion);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(dtFechaNacimiento);
            Controls.Add(cbSexo);
            Controls.Add(dataGridViewPacientes);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCorreo);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "paciente";
            Text = "Pacientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridViewPacientes;
        private ComboBox cbSexo;
        private DateTimePicker dtFechaNacimiento;
        private TextBox txtTelefono;
        private TextBox txtIdentificacion;
        private Label label2;
    }
}