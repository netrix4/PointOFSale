
namespace PointOfSale.usersControls
{
    partial class ucReceiptScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbnRefresh = new System.Windows.Forms.Button();
            this.pnlTransactionList = new System.Windows.Forms.Panel();
            this.lblReceiptTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbnRefresh);
            this.panel1.Controls.Add(this.pnlTransactionList);
            this.panel1.Controls.Add(this.lblReceiptTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 806);
            this.panel1.TabIndex = 1;
            // 
            // tbnRefresh
            // 
            this.tbnRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbnRefresh.Location = new System.Drawing.Point(366, 720);
            this.tbnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbnRefresh.Name = "tbnRefresh";
            this.tbnRefresh.Size = new System.Drawing.Size(100, 28);
            this.tbnRefresh.TabIndex = 3;
            this.tbnRefresh.Text = "Refresh";
            this.tbnRefresh.UseVisualStyleBackColor = true;
            this.tbnRefresh.Click += new System.EventHandler(this.tbnRefresh_Click);
            // 
            // pnlTransactionList
            // 
            this.pnlTransactionList.AutoScroll = true;
            this.pnlTransactionList.BackColor = System.Drawing.Color.White;
            this.pnlTransactionList.Location = new System.Drawing.Point(35, 50);
            this.pnlTransactionList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTransactionList.Name = "pnlTransactionList";
            this.pnlTransactionList.Size = new System.Drawing.Size(768, 587);
            this.pnlTransactionList.TabIndex = 2;
            // 
            // lblReceiptTitle
            // 
            this.lblReceiptTitle.AutoSize = true;
            this.lblReceiptTitle.Location = new System.Drawing.Point(329, 26);
            this.lblReceiptTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiptTitle.Name = "lblReceiptTitle";
            this.lblReceiptTitle.Size = new System.Drawing.Size(159, 16);
            this.lblReceiptTitle.TabIndex = 1;
            this.lblReceiptTitle.Text = "Recibos (Transacciones)";
            // 
            // ucReceiptScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucReceiptScreen";
            this.Size = new System.Drawing.Size(847, 806);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReceiptTitle;
        private System.Windows.Forms.Panel pnlTransactionList;
        private System.Windows.Forms.Button tbnRefresh;
    }
}
