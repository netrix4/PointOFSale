
namespace PointOfSale
{
    partial class MainForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSideContainer = new System.Windows.Forms.Panel();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.lblOtherDefaultText = new System.Windows.Forms.Label();
            this.lblDefaulText = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMainContent.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideContainer
            // 
            this.pnlSideContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.pnlSideContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideContainer.Location = new System.Drawing.Point(0, 27);
            this.pnlSideContainer.Name = "pnlSideContainer";
            this.pnlSideContainer.Size = new System.Drawing.Size(250, 654);
            this.pnlSideContainer.TabIndex = 0;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.LightGray;
            this.pnlMainContent.Controls.Add(this.lblOtherDefaultText);
            this.pnlMainContent.Controls.Add(this.lblDefaulText);
            this.pnlMainContent.Location = new System.Drawing.Point(249, 26);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(635, 655);
            this.pnlMainContent.TabIndex = 1;
            // 
            // lblOtherDefaultText
            // 
            this.lblOtherDefaultText.AutoSize = true;
            this.lblOtherDefaultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherDefaultText.Location = new System.Drawing.Point(111, 250);
            this.lblOtherDefaultText.Name = "lblOtherDefaultText";
            this.lblOtherDefaultText.Size = new System.Drawing.Size(363, 29);
            this.lblOtherDefaultText.TabIndex = 1;
            this.lblOtherDefaultText.Text = "Selecciona una opcion del menu";
            // 
            // lblDefaulText
            // 
            this.lblDefaulText.AutoSize = true;
            this.lblDefaulText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaulText.Location = new System.Drawing.Point(222, 186);
            this.lblDefaulText.Name = "lblDefaulText";
            this.lblDefaulText.Size = new System.Drawing.Size(148, 31);
            this.lblDefaulText.TabIndex = 0;
            this.lblDefaulText.Text = "Bienvenido";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(884, 27);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::PointOfSale.Properties.Resources.cross_icon;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(858, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 681);
            this.Controls.Add(this.pnlSideContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMainContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Program1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlSideContainer;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDefaulText;
        private System.Windows.Forms.Label lblOtherDefaultText;
    }
}

