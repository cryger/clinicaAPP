namespace ClinicaAPP
{
    partial class cita
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
            label4 = new Label();
            cbIdPaciente = new ComboBox();
            label3 = new Label();
            txtIdCita = new TextBox();
            label2 = new Label();
            dataGridViewCitas = new DataGridView();
            btnConsultar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            txtMotivo = new TextBox();
            label6 = new Label();
            label1 = new Label();
            cbIdMedico = new ComboBox();
            label5 = new Label();
            dtpFechaCita = new DateTimePicker();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1142, 506);
            label4.Name = "label4";
            label4.Size = new Size(125, 26);
            label4.TabIndex = 72;
            label4.Text = "Version 1.0";
            // 
            // cbIdPaciente
            // 
            cbIdPaciente.FormattingEnabled = true;
            cbIdPaciente.Location = new Point(522, 23);
            cbIdPaciente.Name = "cbIdPaciente";
            cbIdPaciente.Size = new Size(296, 28);
            cbIdPaciente.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 26);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 70;
            label3.Text = "ID Paciente:";
            // 
            // txtIdCita
            // 
            txtIdCita.Location = new Point(109, 23);
            txtIdCita.Name = "txtIdCita";
            txtIdCita.Size = new Size(255, 27);
            txtIdCita.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 30);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 68;
            label2.Text = "ID Cita:";
            // 
            // dataGridViewCitas
            // 
            dataGridViewCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCitas.Location = new Point(46, 283);
            dataGridViewCitas.Name = "dataGridViewCitas";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCitas.RowHeadersWidth = 51;
            dataGridViewCitas.RowTemplate.Height = 29;
            dataGridViewCitas.Size = new Size(1214, 207);
            dataGridViewCitas.TabIndex = 66;
            dataGridViewCitas.CellClick += dataGridViewCitas_CellClick;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(128, 255, 255);
            btnConsultar.Location = new Point(783, 223);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(140, 29);
            btnConsultar.TabIndex = 65;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.Location = new Point(563, 223);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 29);
            btnEliminar.TabIndex = 64;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(255, 192, 128);
            btnActualizar.Location = new Point(358, 223);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(140, 29);
            btnActualizar.TabIndex = 63;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregar.Location = new Point(162, 223);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 29);
            btnAgregar.TabIndex = 62;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(218, 74);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(1049, 69);
            txtMotivo.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 181);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 60;
            label6.Text = "Fecha Cita:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 77);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 59;
            label1.Text = "Motivo:";
            // 
            // cbIdMedico
            // 
            cbIdMedico.FormattingEnabled = true;
            cbIdMedico.Location = new Point(964, 23);
            cbIdMedico.Name = "cbIdMedico";
            cbIdMedico.Size = new Size(296, 28);
            cbIdMedico.TabIndex = 74;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(839, 26);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 73;
            label5.Text = "ID Medico:";
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Location = new Point(252, 174);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(336, 27);
            dtpFechaCita.TabIndex = 75;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.Location = new Point(980, 223);
            button5.Name = "button5";
            button5.Size = new Size(140, 29);
            button5.TabIndex = 76;
            button5.Text = "Regresar al Menu";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // cita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 254);
            ClientSize = new Size(1279, 541);
            Controls.Add(button5);
            Controls.Add(dtpFechaCita);
            Controls.Add(cbIdMedico);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbIdPaciente);
            Controls.Add(label3);
            Controls.Add(txtIdCita);
            Controls.Add(label2);
            Controls.Add(dataGridViewCitas);
            Controls.Add(btnConsultar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtMotivo);
            Controls.Add(label6);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "cita";
            Text = "cita";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox cbIdPaciente;
        private Label label3;
        private TextBox txtIdCita;
        private Label label2;
        private DataGridView dataGridViewCitas;
        private Button btnConsultar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private TextBox txtMotivo;
        private Label label6;
        private Label label1;
        private ComboBox cbIdMedico;
        private Label label5;
        private DateTimePicker dtpFechaCita;
        private Button button5;
    }
}