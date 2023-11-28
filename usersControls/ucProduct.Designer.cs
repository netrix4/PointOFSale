
namespace PointOfSale.usersControls
{
    partial class ucProduct
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
            this.lblPrductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProductSku = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrductName
            // 
            this.lblPrductName.AutoSize = true;
            this.lblPrductName.BackColor = System.Drawing.Color.Transparent;
            this.lblPrductName.Enabled = false;
            this.lblPrductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrductName.ForeColor = System.Drawing.Color.Black;
            this.lblPrductName.Location = new System.Drawing.Point(84, 12);
            this.lblPrductName.Name = "lblPrductName";
            this.lblPrductName.Size = new System.Drawing.Size(55, 20);
            this.lblPrductName.TabIndex = 0;
            this.lblPrductName.Text = "Name";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblProductPrice.Enabled = false;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.Black;
            this.lblProductPrice.Location = new System.Drawing.Point(486, 12);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(49, 20);
            this.lblProductPrice.TabIndex = 1;
            this.lblProductPrice.Text = "Price";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblProductDescription.Enabled = false;
            this.lblProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.ForeColor = System.Drawing.Color.Black;
            this.lblProductDescription.Location = new System.Drawing.Point(196, 12);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(100, 20);
            this.lblProductDescription.TabIndex = 3;
            this.lblProductDescription.Text = "Description";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.BackColor = System.Drawing.Color.Transparent;
            this.lblProductId.Enabled = false;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.ForeColor = System.Drawing.Color.Black;
            this.lblProductId.Location = new System.Drawing.Point(33, 12);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(28, 20);
            this.lblProductId.TabIndex = 2;
            this.lblProductId.Text = "ID";
            // 
            // lblProductSku
            // 
            this.lblProductSku.AutoSize = true;
            this.lblProductSku.BackColor = System.Drawing.Color.Transparent;
            this.lblProductSku.Enabled = false;
            this.lblProductSku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSku.ForeColor = System.Drawing.Color.Black;
            this.lblProductSku.Location = new System.Drawing.Point(391, 12);
            this.lblProductSku.Name = "lblProductSku";
            this.lblProductSku.Size = new System.Drawing.Size(45, 20);
            this.lblProductSku.TabIndex = 4;
            this.lblProductSku.Text = "SKU";
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblProductSku);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblPrductName);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(591, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductSku;
    }
}
