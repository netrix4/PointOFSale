
namespace PointOfSale.usersControls
{
    partial class ucAboutScreen
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
            this.lblAboutContetnt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAboutContetnt
            // 
            this.lblAboutContetnt.AutoSize = true;
            this.lblAboutContetnt.Location = new System.Drawing.Point(169, 97);
            this.lblAboutContetnt.Name = "lblAboutContetnt";
            this.lblAboutContetnt.Size = new System.Drawing.Size(124, 13);
            this.lblAboutContetnt.TabIndex = 0;
            this.lblAboutContetnt.Text = "Contenido de Acerca De";
            // 
            // ucAboutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lblAboutContetnt);
            this.Name = "ucAboutScreen";
            this.Size = new System.Drawing.Size(496, 199);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboutContetnt;
    }
}
