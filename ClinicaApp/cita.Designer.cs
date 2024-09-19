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
            cbIdCita = new ComboBox();
            label3 = new Label();
            txtIdTratamiento = new TextBox();
            label2 = new Label();
            txtCosto = new TextBox();
            dataGridViewTratamientos = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtDescripcion = new TextBox();
            label6 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTratamientos).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1048, 502);
            label4.Name = "label4";
            label4.Size = new Size(125, 26);
            label4.TabIndex = 72;
            label4.Text = "Version 1.0";
            // 
            // cbIdCita
            // 
            cbIdCita.FormattingEnabled = true;
            cbIdCita.Location = new Point(522, 23);
            cbIdCita.Name = "cbIdCita";
            cbIdCita.Size = new Size(296, 28);
            cbIdCita.TabIndex = 71;
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
            // txtIdTratamiento
            // 
            txtIdTratamiento.Location = new Point(109, 23);
            txtIdTratamiento.Name = "txtIdTratamiento";
            txtIdTratamiento.Size = new Size(255, 27);
            txtIdTratamiento.TabIndex = 69;
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
            // txtCosto
            // 
            txtCosto.Location = new Point(218, 174);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(332, 27);
            txtCosto.TabIndex = 67;
            // 
            // dataGridViewTratamientos
            // 
            dataGridViewTratamientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTratamientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTratamientos.Location = new Point(46, 283);
            dataGridViewTratamientos.Name = "dataGridViewTratamientos";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewTratamientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTratamientos.RowHeadersWidth = 51;
            dataGridViewTratamientos.RowTemplate.Height = 29;
            dataGridViewTratamientos.Size = new Size(1099, 207);
            dataGridViewTratamientos.TabIndex = 66;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 255, 255);
            button4.Location = new Point(873, 225);
            button4.Name = "button4";
            button4.Size = new Size(140, 29);
            button4.TabIndex = 65;
            button4.Text = "Consultar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(653, 225);
            button3.Name = "button3";
            button3.Size = new Size(140, 29);
            button3.TabIndex = 64;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Location = new Point(448, 225);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 63;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(252, 225);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 62;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(218, 74);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(927, 69);
            txtDescripcion.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 181);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 60;
            label6.Text = "Costo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 77);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 59;
            label1.Text = "Descripcion:";
            // 
            // cita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 254);
            ClientSize = new Size(1172, 541);
            Controls.Add(label4);
            Controls.Add(cbIdCita);
            Controls.Add(label3);
            Controls.Add(txtIdTratamiento);
            Controls.Add(label2);
            Controls.Add(txtCosto);
            Controls.Add(dataGridViewTratamientos);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDescripcion);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "cita";
            Text = "cita";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTratamientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox cbIdCita;
        private Label label3;
        private TextBox txtIdTratamiento;
        private Label label2;
        private TextBox txtCosto;
        private DataGridView dataGridViewTratamientos;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtDescripcion;
        private Label label6;
        private Label label1;
    }
}