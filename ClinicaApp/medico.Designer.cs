namespace ClinicaAPP
{
    partial class medico
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtIdentificacion = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            cbEspecialidad = new ComboBox();
            dataGridViewMedicos = new DataGridView();
            btnConsulta = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicos).BeginInit();
            SuspendLayout();
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(155, 54);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(180, 27);
            txtIdentificacion.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 61);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 39;
            label2.Text = "Identificacion:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(155, 116);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(332, 27);
            txtTelefono.TabIndex = 38;
            // 
            // cbEspecialidad
            // 
            cbEspecialidad.FormattingEnabled = true;
            cbEspecialidad.Items.AddRange(new object[] { "Alergología", "Algología", "Anestesiología", "Angiología", "Cardiología", "Cirugía cardíaca", "Cirugía craneofacial", "Cirugía general", "Cirugía oral y maxilofacial", "Cirugía oncológica", "Cirugía ortopédica", "Cirugía pediátrica", "Cirugía plástica", "Cirugía torácica", "Cirugía vascular", "Coloproctología", "Endocrinología", "Estomatología", "Farmacología Clínica", "Foniatría", "Gastroenterología", "Genética", "Geriatría", "Hematología", "Hepatología", "Infectología", "Inmunología", "Medicina aeroespacial", "Medicina del deporte", "Medicina familiar y comunitaria", "Medicina física y rehabilitación", "Medicina forense", "Medicina intensiva", "Medicina interna", "Medicina nuclear", "Medicina paliativa", "Medicina preventiva y salud pública", "Medicina del trabajo", "Nefrología", "Neumología", "Neurología", "Nutriología", "Oncología médica", "Oncología radioterápica", "Pediatría", "Psiquiatría", "Reumatología", "Toxicología" });
            cbEspecialidad.Location = new Point(861, 53);
            cbEspecialidad.Name = "cbEspecialidad";
            cbEspecialidad.Size = new Size(294, 28);
            cbEspecialidad.TabIndex = 36;
            // 
            // dataGridViewMedicos
            // 
            dataGridViewMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedicos.Location = new Point(56, 275);
            dataGridViewMedicos.Name = "dataGridViewMedicos";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMedicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMedicos.RowHeadersWidth = 51;
            dataGridViewMedicos.RowTemplate.Height = 29;
            dataGridViewMedicos.Size = new Size(1099, 237);
            dataGridViewMedicos.TabIndex = 35;
            dataGridViewMedicos.CellClick += dataGridViewMedicos_CellClick;
            // 
            // btnConsulta
            // 
            btnConsulta.BackColor = Color.FromArgb(128, 255, 255);
            btnConsulta.Location = new Point(745, 205);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(140, 29);
            btnConsulta.TabIndex = 34;
            btnConsulta.Text = "Consultar";
            btnConsulta.UseVisualStyleBackColor = false;
            btnConsulta.Click += button4_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.Location = new Point(525, 205);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 29);
            btnEliminar.TabIndex = 33;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button3_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(255, 192, 128);
            btnActualizar.Location = new Point(320, 205);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(140, 29);
            btnActualizar.TabIndex = 32;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += button2_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregar.Location = new Point(124, 205);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 29);
            btnAgregar.TabIndex = 31;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(595, 112);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(560, 27);
            txtCorreo.TabIndex = 30;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(486, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(255, 27);
            txtNombre.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(515, 119);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 27;
            label7.Text = "Correo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 123);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 25;
            label6.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(759, 61);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 23;
            label4.Text = "Especialidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 61);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 22;
            label1.Text = "Nombre y Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1065, 565);
            label3.Name = "label3";
            label3.Size = new Size(125, 26);
            label3.TabIndex = 41;
            label3.Text = "Version 1.0";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.Location = new Point(959, 205);
            button5.Name = "button5";
            button5.Size = new Size(140, 29);
            button5.TabIndex = 42;
            button5.Text = "Regresar al Menu";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // medico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 254);
            ClientSize = new Size(1211, 600);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(txtIdentificacion);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(cbEspecialidad);
            Controls.Add(dataGridViewMedicos);
            Controls.Add(btnConsulta);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "medico";
            Text = "medico";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdentificacion;
        private Label label2;
        private TextBox txtTelefono;
        private ComboBox cbEspecialidad;
        private DataGridView dataGridViewMedicos;
        private Button btnConsulta;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label1;
        private Label label3;
        private Button button5;
    }
}