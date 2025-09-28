namespace HolaMundo
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
            lblPassword = new Label();
            lblConfirm = new Label();
            btnValidar = new Button();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(174, 175);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Contraseña:";
            lblPassword.Click += label1_Click;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(104, 240);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(156, 20);
            lblConfirm.TabIndex = 1;
            lblConfirm.Text = "Confirmar Contraseña:";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(509, 306);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(159, 49);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Acceder";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(291, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(278, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(291, 240);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(278, 27);
            txtConfirm.TabIndex = 4;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(291, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(232, 42);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Credenciales";
            lblTitle.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(btnValidar);
            Controls.Add(lblConfirm);
            Controls.Add(lblPassword);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private Label lblConfirm;
        private Button btnValidar;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Label lblTitle;
    }
}
