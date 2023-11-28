
namespace PointOfSale.usersControls
{
    partial class ucHomeScreen
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblProductsQuantity = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlHistoryList = new System.Windows.Forms.Panel();
            this.txtMainInput = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblProductsQuantity);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.pnlHistoryList);
            this.panel1.Controls.Add(this.txtMainInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 655);
            this.panel1.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(17, 301);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total: ";
            // 
            // lblProductsQuantity
            // 
            this.lblProductsQuantity.AutoSize = true;
            this.lblProductsQuantity.Location = new System.Drawing.Point(17, 288);
            this.lblProductsQuantity.Name = "lblProductsQuantity";
            this.lblProductsQuantity.Size = new System.Drawing.Size(123, 13);
            this.lblProductsQuantity.TabIndex = 0;
            this.lblProductsQuantity.Text = "Cantidad de prductos:: 0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(460, 371);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlHistoryList
            // 
            this.pnlHistoryList.AutoScroll = true;
            this.pnlHistoryList.Location = new System.Drawing.Point(20, 3);
            this.pnlHistoryList.Name = "pnlHistoryList";
            this.pnlHistoryList.Size = new System.Drawing.Size(591, 282);
            this.pnlHistoryList.TabIndex = 2;
            // 
            // txtMainInput
            // 
            this.txtMainInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainInput.Location = new System.Drawing.Point(229, 371);
            this.txtMainInput.Name = "txtMainInput";
            this.txtMainInput.Size = new System.Drawing.Size(139, 26);
            this.txtMainInput.TabIndex = 1;
            this.txtMainInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMainInput_KeyUp);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.Location = new System.Drawing.Point(243, 516);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(108, 57);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Cobrar";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // ucHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "ucHomeScreen";
            this.Size = new System.Drawing.Size(635, 655);
            this.Load += new System.EventHandler(this.ucHomeScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlHistoryList;
        private System.Windows.Forms.TextBox txtMainInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblProductsQuantity;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCheckOut;
    }
}
