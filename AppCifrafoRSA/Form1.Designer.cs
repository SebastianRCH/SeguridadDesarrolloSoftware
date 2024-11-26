namespace AppCifrafoRSA
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
            label1 = new Label();
            txtMensaje = new TextBox();
            btnCifrado = new Button();
            txtResultado = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 55);
            label1.Name = "label1";
            label1.Size = new Size(189, 45);
            label1.TabIndex = 0;
            label1.Text = "Cifrado RSA";
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(78, 178);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(298, 31);
            txtMensaje.TabIndex = 1;
            // 
            // btnCifrado
            // 
            btnCifrado.Location = new Point(130, 249);
            btnCifrado.Name = "btnCifrado";
            btnCifrado.Size = new Size(196, 46);
            btnCifrado.TabIndex = 2;
            btnCifrado.Text = "Click";
            btnCifrado.UseVisualStyleBackColor = true;
            btnCifrado.Click += btnEncryptDecrypt_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.Control;
            txtResultado.Location = new Point(78, 373);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(298, 125);
            txtResultado.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 150);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 4;
            label2.Text = "Texto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 345);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 5;
            label3.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(457, 520);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtResultado);
            Controls.Add(btnCifrado);
            Controls.Add(txtMensaje);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMensaje;
        private Button btnCifrado;
        private TextBox txtResultado;
        private Label label2;
        private Label label3;
    }
}
