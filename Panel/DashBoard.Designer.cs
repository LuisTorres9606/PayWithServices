
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
            this.User = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bar_Principal = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SliderPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddWork = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.Works = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ChildPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Bar_Principal.SuspendLayout();
            this.SliderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(166)))), ((int)(((byte)(212)))));
            this.User.Location = new System.Drawing.Point(92, 21);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(37, 21);
            this.User.TabIndex = 29;
            this.User.Text = "EEX";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 63);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Bar_Principal
            // 
            this.Bar_Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.Bar_Principal.Controls.Add(this.Minimizar);
            this.Bar_Principal.Controls.Add(this.Exit);
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
            this.SliderPanel.Controls.Add(this.button3);
            this.SliderPanel.Controls.Add(this.button2);
            this.SliderPanel.Controls.Add(this.AddWork);
            this.SliderPanel.Controls.Add(this.LogOut);
            this.SliderPanel.Controls.Add(this.Works);
            this.SliderPanel.Controls.Add(this.pictureBox2);
            this.SliderPanel.Controls.Add(this.pictureBox1);
            this.SliderPanel.Controls.Add(this.User);
            this.SliderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SliderPanel.Location = new System.Drawing.Point(0, 0);
            this.SliderPanel.Name = "SliderPanel";
            this.SliderPanel.Size = new System.Drawing.Size(206, 600);
            this.SliderPanel.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(166)))), ((int)(((byte)(212)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(3, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 40);
            this.button3.TabIndex = 33;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(166)))), ((int)(((byte)(212)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(3, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 40);
            this.button2.TabIndex = 32;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // AddWork
            // 
            this.AddWork.BackColor = System.Drawing.Color.Transparent;
            this.AddWork.FlatAppearance.BorderSize = 0;
            this.AddWork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddWork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(166)))), ((int)(((byte)(212)))));
            this.AddWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWork.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.AddWork.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddWork.Location = new System.Drawing.Point(3, 204);
            this.AddWork.Name = "AddWork";
            this.AddWork.Size = new System.Drawing.Size(204, 40);
            this.AddWork.TabIndex = 31;
            this.AddWork.Text = "New Work";
            this.AddWork.UseVisualStyleBackColor = false;
            this.AddWork.Click += new System.EventHandler(this.AddWorks_Click);
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.Transparent;
            this.LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogOut.Location = new System.Drawing.Point(48, 559);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(87, 29);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Works
            // 
            this.Works.BackColor = System.Drawing.Color.Transparent;
            this.Works.FlatAppearance.BorderSize = 0;
            this.Works.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Works.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(166)))), ((int)(((byte)(212)))));
            this.Works.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Works.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Works.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Works.Location = new System.Drawing.Point(2, 250);
            this.Works.Name = "Works";
            this.Works.Size = new System.Drawing.Size(204, 40);
            this.Works.TabIndex = 2;
            this.Works.Text = "Works";
            this.Works.UseVisualStyleBackColor = false;
            this.Works.Click += new System.EventHandler(this.Works_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 559);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 29);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // ChildPanel
            // 
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChildPanel.Location = new System.Drawing.Point(206, 32);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(944, 568);
            this.ChildPanel.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Bar_Principal.ResumeLayout(false);
            this.SliderPanel.ResumeLayout(false);
            this.SliderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Panel Bar_Principal;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimizar;
        private System.Windows.Forms.Panel SliderPanel;
        private System.Windows.Forms.Button Works;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel ChildPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddWork;
    }
}