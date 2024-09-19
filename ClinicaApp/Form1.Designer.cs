namespace ClinicaAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_interface;
            pictureBox1.Location = new Point(239, 36);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(186, 282);
            txtUsuario.Margin = new Padding(5, 4, 5, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(342, 32);
            txtUsuario.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(186, 391);
            txtClave.Margin = new Padding(5, 4, 5, 4);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(342, 32);
            txtClave.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(308, 241);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 26);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(320, 350);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 26);
            label2.TabIndex = 4;
            label2.Text = "Clave:";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(239, 456);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(224, 38);
            button1.TabIndex = 5;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(563, 517);
            label6.Name = "label6";
            label6.Size = new Size(125, 26);
            label6.TabIndex = 11;
            label6.Text = "Version 1.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 242, 254);
            ClientSize = new Size(700, 552);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Ingreso de Usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label6;
    }
}
