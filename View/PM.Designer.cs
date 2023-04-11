
namespace MaquinaEstacionamiento
{
    partial class ParkingMachine
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDown = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnRequestTicket = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelDown.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(882, 32);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblTitle.Location = new System.Drawing.Point(388, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(107, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PARKING";
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.btnExit);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 484);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(882, 81);
            this.panelDown.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(404, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnRequestTicket);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 32);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(882, 452);
            this.panelMain.TabIndex = 2;
            // 
            // btnRequestTicket
            // 
            this.btnRequestTicket.FlatAppearance.BorderSize = 0;
            this.btnRequestTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestTicket.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestTicket.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnRequestTicket.Location = new System.Drawing.Point(261, 204);
            this.btnRequestTicket.Name = "btnRequestTicket";
            this.btnRequestTicket.Size = new System.Drawing.Size(361, 45);
            this.btnRequestTicket.TabIndex = 1;
            this.btnRequestTicket.Text = "REQUEST YOUR TICKET";
            this.btnRequestTicket.UseVisualStyleBackColor = true;
            this.btnRequestTicket.Click += new System.EventHandler(this.BtnRequestTicket_Click);
            // 
            // ParkingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(71)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(882, 565);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParkingMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDown.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRequestTicket;
        public System.Windows.Forms.Panel panelMain;
    }
}

