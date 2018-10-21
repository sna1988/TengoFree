using PresentacionBase.Clases;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MetroFramework.Controls;


namespace PresentacionBase
{
    public partial class FormularioBase : MetroFramework.Forms.MetroForm
    {

        public long Idmio { get; set; }
        private TextRenderingHint _hint = TextRenderingHint.ClearTypeGridFit;
        public TextRenderingHint TextRenderingHint
        {
            get { return this._hint; }
            set { this._hint = value; }
        }

        public FormularioBase()
        {
            InitializeComponent();
            this.BackColor = Colores.ColorFondoFormulario;
            this.ForeColor = Colores.ColorTexto;
        }

        public FormularioBase(Color colorFondoForm)             
        {
            this.BackColor = colorFondoForm;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.TextRenderingHint = TextRenderingHint;
            base.OnPaint(pe);

        }

        public void PoblarComboBox(ComboBox cmb, object lista, string propiedadMostrar, string propiedadDevolver = "Id")
        {
           
            cmb.DisplayMember = propiedadMostrar;
            cmb.ValueMember = propiedadDevolver;
            cmb.DataSource = lista;

        }
        
        public void PoblarComboBox(ComboBox cmb, object obj, string propiedadMostrar, string propiedadDevolver, int elementoSeleccionadoId)
        {
            cmb.DataSource = obj;
            cmb.DisplayMember = propiedadMostrar;
            cmb.ValueMember = propiedadDevolver;
            cmb.SelectedValue = elementoSeleccionadoId;
        }

        public virtual bool VerificarSiHayDatosCargadosEnControles(FormularioABM form)
        {
            foreach (var ctrol in form.Controls)
            {
                if (VerificarControles(ctrol))
                {
                    return true;
                };
            }

            return false;
        }

        public virtual bool VerificarControles(object ctrol)
        {
            if (ctrol is TextBox)
            {
                return !string.IsNullOrEmpty(((TextBox)ctrol).Text);
            }

            if (ctrol is NumericUpDown)
            {
                return !string.IsNullOrEmpty(((NumericUpDown)ctrol).Text);
            }

            if (ctrol is CheckBox)
            {
                if (((CheckBox)ctrol).Checked)
                {
                    return true;
                }
            }

            if (ctrol is Panel)
            {
                foreach (var panelControl in ((Panel)ctrol).Controls)
                {
                    VerificarControles(panelControl);
                }
                
            }

            return false;
        }

        public virtual void LimpiarControles(object obj)
        {
            if (obj is Form)
            {
                foreach (var ctrol in ((Form)obj).Controls)
                {
                    LimpiarControles(ctrol);
                }
            }

            if (obj is Panel)
            {
                foreach (var ctrol in ((Panel)obj).Controls)
                {
                    LimpiarControles(ctrol);
                }
            }

            if (obj is TextBox)
            {
                ((TextBox)obj).Clear();
            }
            if (obj is MetroTextBox)
            {
                ((MetroTextBox)obj).Clear();
            }
            if (obj is ComboBox)
            {
                if (((ComboBox)obj).Items.Count > 0)
                    ((ComboBox)obj).SelectedIndex = 0;
            }
            if (obj is MetroComboBox)
            {
                if (((MetroComboBox)obj).Items.Count > 0)
                    ((MetroComboBox)obj).SelectedIndex = 0;
            }
            if (obj is CheckBox)
            {
                ((CheckBox)obj).Checked = false;
            }
            if (obj is MetroCheckBox)
            {
                ((MetroCheckBox)obj).Checked = false;
            }
            if (obj is MetroToggle)
            {
                ((MetroToggle)obj).Checked = false;
            }
            if (obj is DateTimePicker)
            {
                ((DateTimePicker)obj).Value = DateTime.Now;
            }
            
        }

        public virtual void LimpiarControles(object obj, bool valorPorDefectoCheckBox)
        {
            if (obj is Form)
            {
                foreach (var ctrol in ((Form)obj).Controls)
                {
                    LimpiarControles(ctrol);
                }
            }

            if (obj is Panel)
            {
                foreach (var ctrol in ((Panel)obj).Controls)
                {
                    LimpiarControles(ctrol);
                }
            }

            if (obj is TextBox)
            {
                ((TextBox)obj).Clear();
            }

            if (obj is ComboBox)
            {
                ((ComboBox)obj).SelectedIndex = 0;
            }

            if (obj is CheckBox)
            {
                ((CheckBox)obj).Checked = valorPorDefectoCheckBox;
            }

            if (obj is DateTimePicker)
            {
                ((DateTimePicker)obj).Value = DateTime.Now;
            }

            if (obj is NumericUpDown)
            {
                ((NumericUpDown)obj).Value = ((NumericUpDown)obj).Minimum;
            }

            
        }

        public virtual bool VerificarDatosObligatorios(object[] controlesParaVerificar)
        {
            if (controlesParaVerificar != null)
            {
                foreach (var ctrol in controlesParaVerificar)
                {
                    if (ctrol is TextBox)
                    {
                        if (VerificarSiTieneDatosCtrol(((TextBox)ctrol)))
                            return false;
                    }

                    if (ctrol is NumericUpDown)
                    {
                        if (VerificarSiTieneDatosCtrol(((NumericUpDown)ctrol)))
                            return false;
                    }

                    if (ctrol is ComboBox)
                    {
                        if (!VerificarSiTieneDatosCtrol(((ComboBox)ctrol)))
                            return false;
                    }
                    if (ctrol is MetroTextBox)
                    {
                        if (VerificarSiTieneDatosCtrol(((MetroTextBox)ctrol)))
                            return false;
                    }

                   

                    if (ctrol is MetroComboBox)
                    {
                        if (!VerificarSiTieneDatosCtrol(((MetroComboBox)ctrol)))
                            return false;
                    }
                }
            }

            return true;
        }        

        public virtual bool VerificarSiTieneDatosCtrol(TextBox txt)
        {
            return string.IsNullOrEmpty(txt.Text.Trim()) && string.IsNullOrWhiteSpace(txt.Text.Trim());
        }
        public virtual bool VerificarSiTieneDatosCtrol(MetroTextBox txt)
        {
            return string.IsNullOrEmpty(txt.Text.Trim()) && string.IsNullOrWhiteSpace(txt.Text.Trim());
        }
        public virtual bool VerificarSiTieneDatosCtrol(NumericUpDown nud)
        {
            return string.IsNullOrEmpty(nud.Text) && string.IsNullOrWhiteSpace(nud.Text);
        }

        public virtual bool VerificarSiTieneDatosCtrol(ComboBox cmb)
        {
          
            return !string.IsNullOrEmpty(cmb.Text) && !string.IsNullOrWhiteSpace(cmb.Text) && cmb.Items.Count > 0;
            
        }
        public virtual bool VerificarSiTieneDatosCtrol(MetroComboBox cmb)
        {
            return !string.IsNullOrEmpty(cmb.Text) && !string.IsNullOrWhiteSpace(cmb.Text) && cmb.Items.Count > 0;
        }
        public virtual void FormatearGrilla(DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgv.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public virtual void DesactivarControles(object obj, bool estado)
        {
            if (obj is Form)
            {
                foreach (var ctrol in ((Form)obj).Controls)
                {
                    DesactivarControles(ctrol, estado);
                }
            }

            if (obj is Panel)
            {
                foreach (var ctrol in ((Panel)obj).Controls)
                {
                    DesactivarControles(ctrol, estado);
                }
            }

            if (obj is MetroTextBox)
            {
                ((MetroTextBox)obj).Enabled = estado;
            }
            if (obj is MetroLabel)
            {
                ((MetroLabel)obj).Enabled = estado;
            }
            if (obj is MetroToggle)
            {
                ((MetroToggle)obj).Enabled = estado;
            }
            if (obj is MetroDateTime)
            {
                ((MetroDateTime)obj).Enabled = estado;
            }
            if (obj is MetroButton)
            {
                ((MetroButton)obj).Enabled = estado;
            }

            if (obj is TextBox)
            {
                ((TextBox)obj).Enabled = estado;
            }

            if (obj is ComboBox)
            {
                ((ComboBox)obj).Enabled = estado;
            }

            if (obj is CheckBox)
            {
                ((CheckBox)obj).Enabled = estado;
            }

            if (obj is DateTimePicker)
            {
                ((DateTimePicker)obj).Enabled = estado;
            }

            if (obj is NumericUpDown)
            {
                ((NumericUpDown)obj).Enabled = estado;
            }

            if (obj is RadioButton)
            {
                ((RadioButton)obj).Enabled = estado;
            }
        }

        public virtual void Control_Enter(object sender, EventArgs e)
        {
            CambiarColorControl(sender, Colores.ColorControlConFoco);
        }

        public virtual void Control_Leave(object sender, EventArgs e)
        {
            CambiarColorControl(sender, Colores.ColorControlSinFoco);
        }

        public virtual void CambiarColorControl(object sender, Color colorControl)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = colorControl;
            }

            if (sender is NumericUpDown)
            {
                ((NumericUpDown)sender).BackColor = colorControl;
            }
        }

        private void FormularioBase_Load(object sender, EventArgs e)
        {
        }

        private void FormularioBase_Enter(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        // Atajo Escape para salir de la ventana

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
