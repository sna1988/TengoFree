using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionBase.Clases.Control
{
    public class DataGridView : System.Windows.Forms.DataGridView
    {
        public DataGridView() : base()
        {
            ResetStyles();
        }

        public void ResetStyles()
        {
            this.BackgroundColor = Colores.ColorFondoFormulario;
            this.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            this.DefaultCellStyle.SelectionForeColor = Color.White;
            this.DefaultCellStyle.ForeColor = Colores.ColorTexto;
            this.ColumnHeadersDefaultCellStyle.BackColor = Colores.ColorMenuAccesoRapido;
            this.ColumnHeadersDefaultCellStyle.ForeColor = Colores.ColorTexto;
            this.ColumnHeadersDefaultCellStyle.SelectionBackColor = Colores.ColorMenuAccesoRapido;
            this.RowHeadersVisible = false;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.AlternatingRowsDefaultCellStyle.ForeColor = Colores.ColorTexto;
            // En Teoria Esto Cambia el tamaño de las columnas a automatico y Fill. yambe
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MultiSelect = false;
            this.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.None;
            this.AllowUserToResizeRows = false;
            this.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        }
    }
}
