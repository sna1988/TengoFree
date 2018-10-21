namespace PresentacionBase
{
    partial class FormularioABM
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
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.btnEjecutar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnInfo = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMensaje)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEjecutar,
            this.btnLimpiar,
            this.btnInfo,
            this.btnAyuda});
            this.Menu.Location = new System.Drawing.Point(17, 60);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Menu.Size = new System.Drawing.Size(752, 39);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "toolStrip1";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEjecutar.Image = global::PresentacionBase.RecursosCompartidos.Guardar;
            this.btnEjecutar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEjecutar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEjecutar.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(36, 36);
            this.btnEjecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.Image = global::PresentacionBase.RecursosCompartidos.Borrar;
            this.btnLimpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(36, 36);
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpiar.ToolTipText = "Limpiar campos";
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInfo.Image = global::PresentacionBase.RecursosCompartidos.info;
            this.btnInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(36, 36);
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInfo.ToolTipText = "Información";
            this.btnInfo.Visible = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAyuda.Image = global::PresentacionBase.RecursosCompartidos.help;
            this.btnAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(36, 36);
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAyuda.ToolTipText = "Ayuda";
            this.btnAyuda.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos Obligatorios [*]";
            // 
            // errorProviderMensaje
            // 
            this.errorProviderMensaje.ContainerControl = this;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(17, 99);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(752, 336);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FormularioABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 452);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.Menu);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FormularioABM";
            this.Load += new System.EventHandler(this.FormularioABM_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMensaje)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public new System.Windows.Forms.ToolStrip Menu;
        public System.Windows.Forms.ToolStripButton btnEjecutar;
        public System.Windows.Forms.ToolStripButton btnLimpiar;
        public System.Windows.Forms.ErrorProvider errorProviderMensaje;
        public System.Windows.Forms.Label label1;
        public MetroFramework.Controls.MetroPanel metroPanel1;
        public System.Windows.Forms.ToolStripButton btnAyuda;
        public System.Windows.Forms.ToolStripButton btnInfo;
    }
}