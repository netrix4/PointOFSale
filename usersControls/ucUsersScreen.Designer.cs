
namespace PointOfSale.usersControls
{
    partial class ucUsersScreen
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
            this.lblContetntUsers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContetntUsers
            // 
            this.lblContetntUsers.AutoSize = true;
            this.lblContetntUsers.Location = new System.Drawing.Point(268, 121);
            this.lblContetntUsers.Name = "lblContetntUsers";
            this.lblContetntUsers.Size = new System.Drawing.Size(89, 13);
            this.lblContetntUsers.TabIndex = 0;
            this.lblContetntUsers.Text = "Texto De Usurios";
            // 
            // ucUsersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.lblContetntUsers);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ucUsersScreen";
            this.Size = new System.Drawing.Size(644, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContetntUsers;
    }
}
