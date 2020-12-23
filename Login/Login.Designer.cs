
namespace Presentation
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.v_Email = new System.Windows.Forms.TextBox();
            this.v_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GetStarted = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.v_Hide = new System.Windows.Forms.PictureBox();
            this.v_Show = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ErroLogin = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // v_Email
            // 
            this.v_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(93)))));
            this.v_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.v_Email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_Email.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.v_Email.Location = new System.Drawing.Point(43, 9);
            this.v_Email.Name = "v_Email";
            this.v_Email.Size = new System.Drawing.Size(264, 20);
            this.v_Email.TabIndex = 2;
            this.v_Email.Text = "Usuario";
            this.v_Email.Enter += new System.EventHandler(this.v_Email_Enter);
            this.v_Email.Leave += new System.EventHandler(this.v_Email_Leave);
            // 
            // v_Password
            // 
            this.v_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(93)))));
            this.v_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.v_Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_Password.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.v_Password.Location = new System.Drawing.Point(43, 9);
            this.v_Password.Name = "v_Password";
            this.v_Password.Size = new System.Drawing.Size(236, 20);
            this.v_Password.TabIndex = 3;
            this.v_Password.Text = "Password";
            this.v_Password.Enter += new System.EventHandler(this.v_Password_Enter);
            this.v_Password.Leave += new System.EventHandler(this.v_Password_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(166)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(167, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Forgot Password?";
            // 
            // GetStarted
            // 
            this.GetStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.GetStarted.FlatAppearance.BorderSize = 0;
            this.GetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetStarted.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetStarted.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GetStarted.Location = new System.Drawing.Point(185, 349);
            this.GetStarted.Name = "GetStarted";
            this.GetStarted.Size = new System.Drawing.Size(133, 43);
            this.GetStarted.TabIndex = 7;
            this.GetStarted.Text = "Get Started";
            this.GetStarted.UseVisualStyleBackColor = false;
            this.GetStarted.Click += new System.EventHandler(this.GetStarted_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(93)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.v_Email);
            this.panel2.Location = new System.Drawing.Point(94, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 37);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 29);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.v_Hide);
            this.panel1.Controls.Add(this.v_Show);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.v_Password);
            this.panel1.Location = new System.Drawing.Point(94, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 37);
            this.panel1.TabIndex = 10;
            // 
            // v_Hide
            // 
            this.v_Hide.BackColor = System.Drawing.Color.Transparent;
            this.v_Hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("v_Hide.BackgroundImage")));
            this.v_Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.v_Hide.Location = new System.Drawing.Point(285, 6);
            this.v_Hide.Name = "v_Hide";
            this.v_Hide.Size = new System.Drawing.Size(26, 24);
            this.v_Hide.TabIndex = 14;
            this.v_Hide.TabStop = false;
            this.v_Hide.Click += new System.EventHandler(this.v_Hide_Click);
            // 
            // v_Show
            // 
            this.v_Show.BackColor = System.Drawing.Color.Transparent;
            this.v_Show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("v_Show.BackgroundImage")));
            this.v_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.v_Show.Location = new System.Drawing.Point(285, 6);
            this.v_Show.Name = "v_Show";
            this.v_Show.Size = new System.Drawing.Size(26, 24);
            this.v_Show.TabIndex = 13;
            this.v_Show.TabStop = false;
            this.v_Show.Visible = false;
            this.v_Show.Click += new System.EventHandler(this.v_Show_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 24);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(122, -1);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(138, 118);
            this.pictureBox11.TabIndex = 23;
            this.pictureBox11.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(105, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "DONDE EL DINERO NO ES LA UNICA MONEDA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(166)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(271, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Easy Exchange";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(166)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(266, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 44);
            this.label4.TabIndex = 27;
            this.label4.Text = "EEX";
            // 
            // ErroLogin
            // 
            this.ErroLogin.AutoSize = true;
            this.ErroLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErroLogin.ForeColor = System.Drawing.Color.Brown;
            this.ErroLogin.Location = new System.Drawing.Point(93, 277);
            this.ErroLogin.Name = "ErroLogin";
            this.ErroLogin.Size = new System.Drawing.Size(308, 20);
            this.ErroLogin.TabIndex = 29;
            this.ErroLogin.Text = "¡El Usuario o Contraseña son Incorrectos!";
            this.ErroLogin.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(502, 414);
            this.Controls.Add(this.ErroLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GetStarted);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox v_Email;
        private System.Windows.Forms.TextBox v_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GetStarted;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox v_Show;
        private System.Windows.Forms.PictureBox v_Hide;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ErroLogin;
    }
}