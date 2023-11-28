
namespace PointOfSale.usersControls
{
    partial class ucTransaction
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
            this.lblTransactionId = new System.Windows.Forms.Label();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.tbnDetails = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTransactionId
            // 
            this.lblTransactionId.AutoSize = true;
            this.lblTransactionId.Location = new System.Drawing.Point(61, 43);
            this.lblTransactionId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionId.Name = "lblTransactionId";
            this.lblTransactionId.Size = new System.Drawing.Size(20, 16);
            this.lblTransactionId.TabIndex = 0;
            this.lblTransactionId.Text = "ID";
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Location = new System.Drawing.Point(101, 43);
            this.lblTransactionDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(67, 16);
            this.lblTransactionDate.TabIndex = 1;
            this.lblTransactionDate.Text = "DateTime";
            // 
            // tbnDetails
            // 
            this.tbnDetails.Enabled = false;
            this.tbnDetails.Location = new System.Drawing.Point(609, 37);
            this.tbnDetails.Margin = new System.Windows.Forms.Padding(4);
            this.tbnDetails.Name = "tbnDetails";
            this.tbnDetails.Size = new System.Drawing.Size(100, 28);
            this.tbnDetails.TabIndex = 2;
            this.tbnDetails.Text = "Detalles";
            this.tbnDetails.UseVisualStyleBackColor = true;
            this.tbnDetails.Click += new System.EventHandler(this.tbnDetails_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(255, 41);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 18);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbnDetails);
            this.Controls.Add(this.lblTransactionDate);
            this.Controls.Add(this.lblTransactionId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucTransaction";
            this.Size = new System.Drawing.Size(713, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransactionId;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.Button tbnDetails;
        private System.Windows.Forms.Label lblTotal;
    }
}
