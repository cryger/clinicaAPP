namespace ClinicaAPP
{
    partial class tratamiento
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
            label3 = new Label();
            cbIdCita = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTratamientos).BeginInit();
            SuspendLayout();
            // 
            // txtIdTratamiento
            // 
            txtIdTratamiento.Location = new Point(337, 26);
            txtIdTratamiento.Name = "txtIdTratamiento";
            txtIdTratamiento.Size = new Size(255, 27);
            txtIdTratamiento.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 33);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 54;
            label2.Text = "ID Tratamiento:";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(203, 181);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(332, 27);
            txtCosto.TabIndex = 53;
            // 
            // dataGridViewTratamientos
            // 
            dataGridViewTratamientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTratamientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTratamientos.Location = new Point(31, 290);
            dataGridViewTratamientos.Name = "dataGridViewTratamientos";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTratamientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTratamientos.RowHeadersWidth = 51;
            dataGridViewTratamientos.RowTemplate.Height = 29;
            dataGridViewTratamientos.Size = new Size(1099, 207);
            dataGridViewTratamientos.TabIndex = 51;
            dataGridViewTratamientos.CellClick += dataGridViewTratamientos_CellClick;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 255, 255);
            button4.Location = new Point(858, 232);
            button4.Name = "button4";
            button4.Size = new Size(140, 29);
            button4.TabIndex = 50;
            button4.Text = "Consultar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(638, 232);
            button3.Name = "button3";
            button3.Size = new Size(140, 29);
            button3.TabIndex = 49;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Location = new Point(433, 232);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 48;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(237, 232);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 47;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(203, 81);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(927, 69);
            txtDescripcion.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 188);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 43;
            label6.Text = "Costo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 84);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 41;
            label1.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(708, 33);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 56;
            label3.Text = "ID Cita:";
            // 
            // cbIdCita
            // 
            cbIdCita.FormattingEnabled = true;
            cbIdCita.Location = new Point(771, 26);
            cbIdCita.Name = "cbIdCita";
            cbIdCita.Size = new Size(359, 28);
            cbIdCita.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1033, 509);
            label4.Name = "label4";
            label4.Size = new Size(125, 26);
            label4.TabIndex = 58;
            label4.Text = "Version 1.0";
            // 
            // tratamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 254);
            ClientSize = new Size(1160, 543);
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
            MaximizeBox = false;
            Name = "tratamiento";
            Text = "Tratamiento";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTratamientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label label3;
        private ComboBox cbIdCita;
        private Label label4;
    }
}