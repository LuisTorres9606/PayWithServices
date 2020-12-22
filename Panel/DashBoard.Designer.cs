
namespace Presentation
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.PictureUser = new System.Windows.Forms.PictureBox();
            this.Bar_Principal = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SliderPanel = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Correo = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.UpPhoto = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.Button();
            this.MyServices = new System.Windows.Forms.Button();
            this.AddService = new System.Windows.Forms.Button();
            this.Service = new System.Windows.Forms.Button();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).BeginInit();
            this.Bar_Principal.SuspendLayout();
            this.SliderPanel.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureUser
            // 
            this.PictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureUser.Location = new System.Drawing.Point(46, 32);
            this.PictureUser.Name = "PictureUser";
            this.PictureUser.Size = new System.Drawing.Size(110, 110);
            this.PictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureUser.TabIndex = 2;
            this.PictureUser.TabStop = false;
            this.PictureUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureUser_MouseClick);
            // 
            // Bar_Principal
            // 
            this.Bar_Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.Bar_Principal.Controls.Add(this.Minimizar);
            this.Bar_Principal.Controls.Add(this.Exit);
            this.Bar_Principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bar_Principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bar_Principal.Location = new System.Drawing.Point(206, 0);
            this.Bar_Principal.Name = "Bar_Principal";
            this.Bar_Principal.Size = new System.Drawing.Size(944, 32);
            this.Bar_Principal.TabIndex = 1;
            this.Bar_Principal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bar_Principal_MouseDown);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimizar.BackgroundImage")));
            this.Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimizar.FlatAppearance.BorderSize = 0;
            this.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizar.Location = new System.Drawing.Point(894, 5);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(21, 21);
            this.Minimizar.TabIndex = 22;
            this.Minimizar.UseVisualStyleBackColor = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(918, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(21, 21);
            this.Exit.TabIndex = 21;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SliderPanel
            // 
            this.SliderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.SliderPanel.Controls.Add(this.Menu);
            this.SliderPanel.Controls.Add(this.UpPhoto);
            this.SliderPanel.Controls.Add(this.Information);
            this.SliderPanel.Controls.Add(this.MyServices);
            this.SliderPanel.Controls.Add(this.AddService);
            this.SliderPanel.Controls.Add(this.Service);
            this.SliderPanel.Controls.Add(this.PictureUser);
            this.SliderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SliderPanel.Location = new System.Drawing.Point(0, 0);
            this.SliderPanel.Name = "SliderPanel";
            this.SliderPanel.Size = new System.Drawing.Size(206, 600);
            this.SliderPanel.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(93)))));
            this.Menu.Controls.Add(this.button4);
            this.Menu.Controls.Add(this.button1);
            this.Menu.Controls.Add(this.Correo);
            this.Menu.Controls.Add(this.User);
            this.Menu.Location = new System.Drawing.Point(0, 142);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(206, 223);
            this.Menu.TabIndex = 36;
            this.Menu.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(0, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 31);
            this.button4.TabIndex = 39;
            this.button4.Text = "Gestionar Cuenta";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 32);
            this.button1.TabIndex = 38;
            this.button1.Text = "Cerrar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Correo
            // 
            this.Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(93)))));
            this.Correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Correo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Correo.Location = new System.Drawing.Point(13, 31);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(180, 15);
            this.Correo.TabIndex = 37;
            this.Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(93)))));
            this.User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.User.Location = new System.Drawing.Point(6, 6);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(194, 16);
            this.User.TabIndex = 35;
            this.User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpPhoto
            // 
            this.UpPhoto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UpPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpPhoto.BackgroundImage")));
            this.UpPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpPhoto.Location = new System.Drawing.Point(116, 102);
            this.UpPhoto.Name = "UpPhoto";
            this.UpPhoto.Size = new System.Drawing.Size(40, 40);
            this.UpPhoto.TabIndex = 37;
            this.UpPhoto.UseVisualStyleBackColor = false;
            this.UpPhoto.Click += new System.EventHandler(this.UpPhoto_Click);
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.Transparent;
            this.Information.FlatAppearance.BorderSize = 0;
            this.Information.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.Information.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.Information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Information.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Information.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Information.Location = new System.Drawing.Point(-1, 323);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(207, 40);
            this.Information.TabIndex = 33;
            this.Information.Text = "Información";
            this.Information.UseVisualStyleBackColor = false;
            this.Information.Click += new System.EventHandler(this.Information_Click);
            // 
            // MyServices
            // 
            this.MyServices.BackColor = System.Drawing.Color.Transparent;
            this.MyServices.FlatAppearance.BorderSize = 0;
            this.MyServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.MyServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.MyServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyServices.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.MyServices.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MyServices.Location = new System.Drawing.Point(-1, 283);
            this.MyServices.Name = "MyServices";
            this.MyServices.Size = new System.Drawing.Size(207, 40);
            this.MyServices.TabIndex = 32;
            this.MyServices.Text = "Mis Servicios";
            this.MyServices.UseVisualStyleBackColor = false;
            this.MyServices.Click += new System.EventHandler(this.MyServices_Click);
            // 
            // AddService
            // 
            this.AddService.BackColor = System.Drawing.Color.Transparent;
            this.AddService.FlatAppearance.BorderSize = 0;
            this.AddService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.AddService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.AddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddService.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.AddService.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddService.Location = new System.Drawing.Point(-1, 204);
            this.AddService.Name = "AddService";
            this.AddService.Size = new System.Drawing.Size(207, 40);
            this.AddService.TabIndex = 31;
            this.AddService.Text = "Nuevo Servicio";
            this.AddService.UseVisualStyleBackColor = false;
            this.AddService.Click += new System.EventHandler(this.AddService_Click);
            // 
            // Service
            // 
            this.Service.BackColor = System.Drawing.Color.Transparent;
            this.Service.FlatAppearance.BorderSize = 0;
            this.Service.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.Service.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Service.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Service.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Service.Location = new System.Drawing.Point(-1, 244);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(207, 40);
            this.Service.TabIndex = 2;
            this.Service.Text = "Servicios";
            this.Service.UseVisualStyleBackColor = false;
            this.Service.Click += new System.EventHandler(this.Service_Click);
            // 
            // ChildPanel
            // 
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChildPanel.Location = new System.Drawing.Point(206, 32);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(944, 568);
            this.ChildPanel.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.ChildPanel);
            this.Controls.Add(this.Bar_Principal);
            this.Controls.Add(this.SliderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).EndInit();
            this.Bar_Principal.ResumeLayout(false);
            this.SliderPanel.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureUser;
        private System.Windows.Forms.Panel Bar_Principal;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimizar;
        private System.Windows.Forms.Panel SliderPanel;
        private System.Windows.Forms.Button Service;
        private System.Windows.Forms.Panel ChildPanel;
        private System.Windows.Forms.Button Information;
        private System.Windows.Forms.Button MyServices;
        private System.Windows.Forms.Button AddService;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button UpPhoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Correo;
    }
}