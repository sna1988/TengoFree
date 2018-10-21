namespace PresentacionBase
{
    partial class FormularioConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripSplitButton();
            this.btnImprimirSelección = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImprmirListaCompleta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.dgvGrilla = new MetroFramework.Controls.MetroGrid();
            this.loadingImg = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar,
            this.btnActualizar,
            this.btnImprimir,
            this.btnBuscar});
            this.Menu.Location = new System.Drawing.Point(17, 60);
            this.Menu.Margin = new System.Windows.Forms.Padding(0, 49, 0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu.Size = new System.Drawing.Size(990, 39);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.Image = global::PresentacionBase.RecursosCompartidos.Nuevo;
            this.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(36, 36);
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.ToolTipText = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.Image = global::PresentacionBase.RecursosCompartidos.Editar;
            this.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(36, 36);
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.ToolTipText = "Editar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.Image = global::PresentacionBase.RecursosCompartidos.Actualizar;
            this.btnActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(36, 36);
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.ToolTipText = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.Image = global::PresentacionBase.RecursosCompartidos.Borrar;
            this.btnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 36);
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.ToolTipText = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImprimir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimirSelección,
            this.btnImprmirListaCompleta});
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImprimir.Image = global::PresentacionBase.RecursosCompartidos.Impresora;
            this.btnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(48, 36);
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.ToolTipText = "Imprimir";
            this.btnImprimir.Visible = false;
            // 
            // btnImprimirSelección
            // 
            this.btnImprimirSelección.Name = "btnImprimirSelección";
            this.btnImprimirSelección.Size = new System.Drawing.Size(199, 22);
            this.btnImprimirSelección.Text = "Imprimir Selección";
            this.btnImprimirSelección.Click += new System.EventHandler(this.btnImprimirSelección_Click);
            // 
            // btnImprmirListaCompleta
            // 
            this.btnImprmirListaCompleta.Name = "btnImprmirListaCompleta";
            this.btnImprmirListaCompleta.Size = new System.Drawing.Size(199, 22);
            this.btnImprmirListaCompleta.Text = "Imprmir Lista Completa";
            this.btnImprmirListaCompleta.Click += new System.EventHandler(this.btnImprmirListaCompleta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.Image = global::PresentacionBase.RecursosCompartidos.Buscar;
            this.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 36);
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.ToolTipText = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtBuscar.CustomButton.Image = null;
            this.txtBuscar.CustomButton.Location = new System.Drawing.Point(267, 2);
            this.txtBuscar.CustomButton.Name = "";
            this.txtBuscar.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscar.CustomButton.TabIndex = 1;
            this.txtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscar.CustomButton.UseSelectable = true;
            this.txtBuscar.CustomButton.Visible = false;
            this.txtBuscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(661, 63);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PromptText = "Buscar";
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(297, 32);
            this.txtBuscar.Style = MetroFramework.MetroColorStyle.Green;
            this.txtBuscar.TabIndex = 15;
            this.txtBuscar.UseSelectable = true;
            this.txtBuscar.WaterMark = "Buscar";
            this.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.AllowUserToResizeColumns = false;
            this.dgvGrilla.AllowUserToResizeRows = false;
            this.dgvGrilla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvGrilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrilla.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrilla.EnableHeadersVisualStyles = false;
            this.dgvGrilla.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvGrilla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvGrilla.Location = new System.Drawing.Point(17, 99);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGrilla.RowHeadersVisible = false;
            this.dgvGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(990, 610);
            this.dgvGrilla.Style = MetroFramework.MetroColorStyle.Green;
            this.dgvGrilla.TabIndex = 16;
            this.dgvGrilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellContentClick);
            this.dgvGrilla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_RowEnter);
            // 
            // loadingImg
            // 
            this.loadingImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingImg.Location = new System.Drawing.Point(17, 102);
            this.loadingImg.MinimumSize = new System.Drawing.Size(990, 612);
            this.loadingImg.Name = "loadingImg";
            this.loadingImg.Size = new System.Drawing.Size(990, 612);
            this.loadingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadingImg.TabIndex = 31;
            this.loadingImg.TabStop = false;
            // 
            // FormularioConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 726);
            this.Controls.Add(this.loadingImg);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormularioConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormularioConsulta_Load);
            this.Shown += new System.EventHandler(this.FormularioConsulta_Shown);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStripButton btnNuevo;
        public System.Windows.Forms.ToolStripButton btnModificar;
        public System.Windows.Forms.ToolStripButton btnEliminar;
        public System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripMenuItem btnImprmirListaCompleta;
        public System.Windows.Forms.ToolStripMenuItem btnImprimirSelección;
        public System.Windows.Forms.ToolStripSplitButton btnImprimir;
        protected new System.Windows.Forms.ToolStrip Menu;
        protected MetroFramework.Controls.MetroGrid dgvGrilla;
        protected System.Windows.Forms.PictureBox loadingImg;
        public System.Windows.Forms.ToolStripButton btnBuscar;
        public MetroFramework.Controls.MetroTextBox txtBuscar;
    }
}