
namespace MaquinaEstacionamiento
{
    partial class Ticket
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
            this.panelTopTicket = new System.Windows.Forms.Panel();
            this.lblTicket = new System.Windows.Forms.Label();
            this.panelTicket = new System.Windows.Forms.Panel();
            this.panelDepartureTime = new System.Windows.Forms.Panel();
            this.btnConfLeave = new System.Windows.Forms.Button();
            this.LBLTxMin = new System.Windows.Forms.Label();
            this.lblTxHour = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.lblTwoPoints = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.btnLeave = new System.Windows.Forms.Button();
            this.lblCheckInTime = new System.Windows.Forms.Label();
            this.lblAnounce = new System.Windows.Forms.Label();
            this.cbxTime = new MaquinaEstacionamiento.Personalized_Controls.CbxPersonalized();
            this.panelTopTicket.SuspendLayout();
            this.panelTicket.SuspendLayout();
            this.panelDepartureTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopTicket
            // 
            this.panelTopTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(28)))), ((int)(((byte)(214)))));
            this.panelTopTicket.Controls.Add(this.lblTicket);
            this.panelTopTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTicket.Location = new System.Drawing.Point(0, 0);
            this.panelTopTicket.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelTopTicket.Name = "panelTopTicket";
            this.panelTopTicket.Size = new System.Drawing.Size(684, 73);
            this.panelTopTicket.TabIndex = 0;
            // 
            // lblTicket
            // 
            this.lblTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.ForeColor = System.Drawing.Color.Cyan;
            this.lblTicket.Location = new System.Drawing.Point(292, 24);
            this.lblTicket.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(100, 25);
            this.lblTicket.TabIndex = 0;
            this.lblTicket.Text = "TICKET";
            // 
            // panelTicket
            // 
            this.panelTicket.Controls.Add(this.panelDepartureTime);
            this.panelTicket.Controls.Add(this.btnLeave);
            this.panelTicket.Controls.Add(this.lblCheckInTime);
            this.panelTicket.Controls.Add(this.lblAnounce);
            this.panelTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTicket.Location = new System.Drawing.Point(0, 73);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(684, 374);
            this.panelTicket.TabIndex = 1;
            // 
            // panelDepartureTime
            // 
            this.panelDepartureTime.Controls.Add(this.cbxTime);
            this.panelDepartureTime.Controls.Add(this.btnConfLeave);
            this.panelDepartureTime.Controls.Add(this.LBLTxMin);
            this.panelDepartureTime.Controls.Add(this.lblTxHour);
            this.panelDepartureTime.Controls.Add(this.txtMinutes);
            this.panelDepartureTime.Controls.Add(this.lblTwoPoints);
            this.panelDepartureTime.Controls.Add(this.panelLine);
            this.panelDepartureTime.Controls.Add(this.txtHour);
            this.panelDepartureTime.Controls.Add(this.lblDeparture);
            this.panelDepartureTime.Location = new System.Drawing.Point(38, 46);
            this.panelDepartureTime.Name = "panelDepartureTime";
            this.panelDepartureTime.Size = new System.Drawing.Size(268, 305);
            this.panelDepartureTime.TabIndex = 3;
            this.panelDepartureTime.Visible = false;
            // 
            // btnConfLeave
            // 
            this.btnConfLeave.FlatAppearance.BorderSize = 0;
            this.btnConfLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfLeave.ForeColor = System.Drawing.Color.DarkRed;
            this.btnConfLeave.Location = new System.Drawing.Point(83, 247);
            this.btnConfLeave.Name = "btnConfLeave";
            this.btnConfLeave.Size = new System.Drawing.Size(102, 31);
            this.btnConfLeave.TabIndex = 8;
            this.btnConfLeave.Text = "CONFIRM";
            this.btnConfLeave.UseVisualStyleBackColor = true;
            this.btnConfLeave.Click += new System.EventHandler(this.btnConfLeave_Click);
            // 
            // LBLTxMin
            // 
            this.LBLTxMin.AutoEllipsis = true;
            this.LBLTxMin.AutoSize = true;
            this.LBLTxMin.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTxMin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBLTxMin.Location = new System.Drawing.Point(130, 148);
            this.LBLTxMin.Name = "LBLTxMin";
            this.LBLTxMin.Size = new System.Drawing.Size(75, 17);
            this.LBLTxMin.TabIndex = 7;
            this.LBLTxMin.Text = "MINUTES";
            // 
            // lblTxHour
            // 
            this.lblTxHour.AutoEllipsis = true;
            this.lblTxHour.AutoSize = true;
            this.lblTxHour.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxHour.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTxHour.Location = new System.Drawing.Point(58, 148);
            this.lblTxHour.Name = "lblTxHour";
            this.lblTxHour.Size = new System.Drawing.Size(51, 17);
            this.lblTxHour.TabIndex = 6;
            this.lblTxHour.Text = "HOUR";
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.txtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinutes.Location = new System.Drawing.Point(133, 169);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(63, 21);
            this.txtMinutes.TabIndex = 5;
            this.txtMinutes.Text = "00";
            // 
            // lblTwoPoints
            // 
            this.lblTwoPoints.AutoEllipsis = true;
            this.lblTwoPoints.AutoSize = true;
            this.lblTwoPoints.Location = new System.Drawing.Point(115, 169);
            this.lblTwoPoints.Name = "lblTwoPoints";
            this.lblTwoPoints.Size = new System.Drawing.Size(14, 21);
            this.lblTwoPoints.TabIndex = 4;
            this.lblTwoPoints.Text = ":";
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelLine.Location = new System.Drawing.Point(46, 193);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(150, 3);
            this.panelLine.TabIndex = 3;
            // 
            // txtHour
            // 
            this.txtHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.txtHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHour.Location = new System.Drawing.Point(46, 169);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(63, 21);
            this.txtHour.TabIndex = 2;
            this.txtHour.Text = "00";
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDeparture
            // 
            this.lblDeparture.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparture.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDeparture.Location = new System.Drawing.Point(19, 21);
            this.lblDeparture.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(231, 86);
            this.lblDeparture.TabIndex = 1;
            this.lblDeparture.Text = "ENTER DEPARTURE TIME";
            this.lblDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLeave
            // 
            this.btnLeave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeave.FlatAppearance.BorderSize = 0;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLeave.Location = new System.Drawing.Point(297, 279);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(91, 31);
            this.btnLeave.TabIndex = 2;
            this.btnLeave.Text = "LEAVE";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // lblCheckInTime
            // 
            this.lblCheckInTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckInTime.AutoSize = true;
            this.lblCheckInTime.Location = new System.Drawing.Point(312, 137);
            this.lblCheckInTime.Name = "lblCheckInTime";
            this.lblCheckInTime.Size = new System.Drawing.Size(24, 21);
            this.lblCheckInTime.TabIndex = 1;
            this.lblCheckInTime.Text = "\"\"";
            // 
            // lblAnounce
            // 
            this.lblAnounce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnounce.AutoSize = true;
            this.lblAnounce.Location = new System.Drawing.Point(74, 5);
            this.lblAnounce.Name = "lblAnounce";
            this.lblAnounce.Size = new System.Drawing.Size(536, 21);
            this.lblAnounce.TabIndex = 0;
            this.lblAnounce.Text = "The Rate is $20 for Two Hours, then $5 for every Extra 15 Minutes";
            // 
            // cbxTime
            // 
            this.cbxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.cbxTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxTime.BorderSize = 0;
            this.cbxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxTime.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.cbxTime.ForeColor = System.Drawing.Color.Black;
            this.cbxTime.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxTime.Items.AddRange(new object[] {
            "a. m.",
            "p. m."});
            this.cbxTime.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxTime.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxTime.Location = new System.Drawing.Point(157, 163);
            this.cbxTime.MinimumSize = new System.Drawing.Size(65, 30);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.Size = new System.Drawing.Size(86, 30);
            this.cbxTime.TabIndex = 4;
            this.cbxTime.Texts = "a. m.";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.Controls.Add(this.panelTicket);
            this.Controls.Add(this.panelTopTicket);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Ticket";
            this.Size = new System.Drawing.Size(684, 447);
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.panelTopTicket.ResumeLayout(false);
            this.panelTopTicket.PerformLayout();
            this.panelTicket.ResumeLayout(false);
            this.panelTicket.PerformLayout();
            this.panelDepartureTime.ResumeLayout(false);
            this.panelDepartureTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopTicket;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Panel panelTicket;
        private System.Windows.Forms.Label lblCheckInTime;
        private System.Windows.Forms.Label lblAnounce;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Panel panelDepartureTime;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Button btnConfLeave;
        private System.Windows.Forms.Label LBLTxMin;
        private System.Windows.Forms.Label lblTxHour;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label lblTwoPoints;
        private Personalized_Controls.CbxPersonalized cbxTime;
    }
}
