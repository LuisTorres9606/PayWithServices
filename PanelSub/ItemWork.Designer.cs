
namespace Presentation.PanelSub
{
    partial class ItemWork
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.v_Login = new System.Windows.Forms.Button();
            this.Favorite = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // v_Login
            // 
            this.v_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.v_Login.FlatAppearance.BorderSize = 0;
            this.v_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(166)))), ((int)(((byte)(212)))));
            this.v_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_Login.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.v_Login.Location = new System.Drawing.Point(22, 140);
            this.v_Login.Name = "v_Login";
            this.v_Login.Size = new System.Drawing.Size(99, 39);
            this.v_Login.TabIndex = 1;
            this.v_Login.Text = "Ver Oferta";
            this.v_Login.UseVisualStyleBackColor = false;
            // 
            // Favorite
            // 
            this.Favorite.AutoSize = true;
            this.Favorite.BackColor = System.Drawing.Color.Transparent;
            this.Favorite.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.Favorite.FlatAppearance.BorderSize = 0;
            this.Favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Favorite.Location = new System.Drawing.Point(132, 3);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(12, 11);
            this.Favorite.TabIndex = 2;
            this.Favorite.UseVisualStyleBackColor = false;
            // 
            // ItemWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.Favorite);
            this.Controls.Add(this.v_Login);
            this.Name = "ItemWork";
            this.Size = new System.Drawing.Size(150, 182);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button v_Login;
        private System.Windows.Forms.CheckBox Favorite;
    }
}
