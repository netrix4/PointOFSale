
namespace PointOfSale.usersControls
{
    partial class ucSettingsScreen
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
            this.pnlSettingsContent = new System.Windows.Forms.Panel();
            this.lblTextSttings = new System.Windows.Forms.Label();
            this.pnlSettingsContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSettingsContent
            // 
            this.pnlSettingsContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSettingsContent.Controls.Add(this.lblTextSttings);
            this.pnlSettingsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingsContent.Location = new System.Drawing.Point(0, 0);
            this.pnlSettingsContent.Name = "pnlSettingsContent";
            this.pnlSettingsContent.Size = new System.Drawing.Size(416, 130);
            this.pnlSettingsContent.TabIndex = 0;
            // 
            // lblTextSttings
            // 
            this.lblTextSttings.AutoSize = true;
            this.lblTextSttings.Location = new System.Drawing.Point(179, 60);
            this.lblTextSttings.Name = "lblTextSttings";
            this.lblTextSttings.Size = new System.Drawing.Size(72, 13);
            this.lblTextSttings.TabIndex = 0;
            this.lblTextSttings.Text = "SettingsTexto";
            // 
            // ucSettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlSettingsContent);
            this.Name = "ucSettingsScreen";
            this.Size = new System.Drawing.Size(416, 130);
            this.pnlSettingsContent.ResumeLayout(false);
            this.pnlSettingsContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSettingsContent;
        private System.Windows.Forms.Label lblTextSttings;
    }
}
