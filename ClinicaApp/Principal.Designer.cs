namespace ClinicaAPP
{
    partial class Principal
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btnPanelPaciente = new Button();
            btnPanelMedico = new Button();
            btnPanelCitas = new Button();
            btnPanelTratamiento = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(480, 107);
            label1.Name = "label1";
            label1.Size = new Size(104, 26);
            label1.TabIndex = 0;
            label1.Text = "Paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(484, 178);
            label2.Name = "label2";
            label2.Size = new Size(89, 26);
            label2.TabIndex = 1;
            label2.Text = "Medico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(487, 255);
            label3.Name = "label3";
            label3.Size = new Size(162, 26);
            label3.TabIndex = 2;
            label3.Text = "Tratamientos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(496, 330);
            label4.Name = "label4";
            label4.Size = new Size(66, 26);
            label4.TabIndex = 3;
            label4.Text = "Citas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(454, 28);
            label5.Name = "label5";
            label5.Size = new Size(232, 29);
            label5.TabIndex = 4;
            label5.Text = "Menu de Seleccion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.clinica;
            pictureBox1.Location = new Point(60, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnPanelPaciente
            // 
            btnPanelPaciente.BackColor = Color.LightGreen;
            btnPanelPaciente.Location = new Point(662, 104);
            btnPanelPaciente.Name = "btnPanelPaciente";
            btnPanelPaciente.Size = new Size(398, 29);
            btnPanelPaciente.TabIndex = 6;
            btnPanelPaciente.Text = "Ingresar Registros";
            btnPanelPaciente.UseVisualStyleBackColor = false;
            btnPanelPaciente.Click += button1_Click;
            // 
            // btnPanelMedico
            // 
            btnPanelMedico.BackColor = Color.LightGreen;
            btnPanelMedico.Location = new Point(662, 175);
            btnPanelMedico.Name = "btnPanelMedico";
            btnPanelMedico.Size = new Size(398, 29);
            btnPanelMedico.TabIndex = 7;
            btnPanelMedico.Text = "Ingresar Registros";
            btnPanelMedico.UseVisualStyleBackColor = false;
            btnPanelMedico.Click += btnPanelMedico_Click;
            // 
            // btnPanelCitas
            // 
            btnPanelCitas.BackColor = Color.LightGreen;
            btnPanelCitas.Location = new Point(662, 332);
            btnPanelCitas.Name = "btnPanelCitas";
            btnPanelCitas.Size = new Size(398, 29);
            btnPanelCitas.TabIndex = 9;
            btnPanelCitas.Text = "Ingresar Registros";
            btnPanelCitas.UseVisualStyleBackColor = false;
            btnPanelCitas.Click += btnPanelCitas_Click;
            // 
            // btnPanelTratamiento
            // 
            btnPanelTratamiento.BackColor = Color.LightGreen;
            btnPanelTratamiento.Location = new Point(662, 252);
            btnPanelTratamiento.Name = "btnPanelTratamiento";
            btnPanelTratamiento.Size = new Size(398, 29);
            btnPanelTratamiento.TabIndex = 8;
            btnPanelTratamiento.Text = "Ingresar Registros";
            btnPanelTratamiento.UseVisualStyleBackColor = false;
            btnPanelTratamiento.Click += btnPanelTratamiento_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(961, 485);
            label6.Name = "label6";
            label6.Size = new Size(125, 26);
            label6.TabIndex = 10;
            label6.Text = "Version 1.0";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 254);
            ClientSize = new Size(1098, 520);
            Controls.Add(label6);
            Controls.Add(btnPanelCitas);
            Controls.Add(btnPanelTratamiento);
            Controls.Add(btnPanelMedico);
            Controls.Add(btnPanelPaciente);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Principal";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Button btnPanelPaciente;
        private Button btnPanelMedico;
        private Button btnPanelCitas;
        private Button btnPanelTratamiento;
        private Label label6;
    }
}