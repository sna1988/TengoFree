namespace TengoFree
{
    partial class _00001_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00001_Principal));
            this.mtNewTicket = new MetroFramework.Controls.MetroTile();
            this.mtListadoTickets = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtNewTicket
            // 
            this.mtNewTicket.ActiveControl = null;
            this.mtNewTicket.Location = new System.Drawing.Point(23, 92);
            this.mtNewTicket.Name = "mtNewTicket";
            this.mtNewTicket.Size = new System.Drawing.Size(135, 95);
            this.mtNewTicket.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtNewTicket.TabIndex = 0;
            this.mtNewTicket.Text = "Nuevo Ticket";
            this.mtNewTicket.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtNewTicket.UseSelectable = true;
            this.mtNewTicket.UseStyleColors = true;
            this.mtNewTicket.Click += new System.EventHandler(this.mtNewTicket_Click);
            // 
            // mtListadoTickets
            // 
            this.mtListadoTickets.ActiveControl = null;
            this.mtListadoTickets.Location = new System.Drawing.Point(164, 92);
            this.mtListadoTickets.Name = "mtListadoTickets";
            this.mtListadoTickets.Size = new System.Drawing.Size(204, 95);
            this.mtListadoTickets.Style = MetroFramework.MetroColorStyle.Black;
            this.mtListadoTickets.TabIndex = 1;
            this.mtListadoTickets.Text = "Listado de Tickets";
            this.mtListadoTickets.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtListadoTickets.UseSelectable = true;
            this.mtListadoTickets.UseStyleColors = true;
            this.mtListadoTickets.Click += new System.EventHandler(this.mtListadoTickets_Click);
            // 
            // _00001_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.mtListadoTickets);
            this.Controls.Add(this.mtNewTicket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_00001_Principal";
            this.Text = "TengoFree Tickets";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtNewTicket;
        private MetroFramework.Controls.MetroTile mtListadoTickets;
    }
}