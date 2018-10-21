using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PresentacionBase
{
    public partial class FormularioABM : FormularioBase
    {
        private Dictionary<TipoOperacion, string> diccionarioEjecucion;

        public bool RealizoAlgunaOperacion;
        
        protected TipoOperacion _operacion;
        public TipoOperacion TipoOperacion { set { this._operacion = value; } }

        protected long? _entidadId;
        public long? EntidadId { set { this._entidadId = value; } }

        public virtual Image ImagenBotonEjecutar
        {
            set { this.btnEjecutar.Image = value; }
        }

        public virtual Image ImagenBotonLimpiar
        {
            set { this.btnLimpiar.Image = value; }
        }

        /// <summary>
        /// Constructor del Formulario por defecto
        /// </summary>
        public FormularioABM()
        {
            InitializeComponent();
            
            diccionarioEjecucion = new Dictionary<TipoOperacion, string>();
            InicializadorDiccionarioABM.Cargar(ref diccionarioEjecucion);

            RealizoAlgunaOperacion = false;

            ImagenBotonEjecutar = Imagenes.BotonEjecutar;
            ImagenBotonLimpiar = Imagenes.BotonLimpiar;

            this.Menu.BackColor = Colores.ColorMenuAccesoRapido;
        }

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <param name="tituloFormulario">Titulo del Formulario.  
        /// Nota: El formulario hijo NO debe tener asignado el título en la propiedad Text</param>
        public FormularioABM(string tituloFormulario)
            :this()
        {
            this.Text = tituloFormulario;
        }

        protected void AgregarOpcionDiccionario(TipoOperacion operacion, string nombreMetodo)
        {
            this.diccionarioEjecucion.Add(operacion, nombreMetodo);
        }

        private void FormularioABM_Load(object sender, EventArgs e)
        {
            CargarDatos();
            this.btnEjecutar.ToolTipText = this._operacion == TipoOperacion.Insertar ? "Guardar" : this._operacion == TipoOperacion.Eliminar ? "Eliminar" : "Modificar";
        }

        private void EjecutarOperacion()
        {
            var nombreMetodo = diccionarioEjecucion.First(x => x.Key == this._operacion).Value;
            MethodInfo metodoEjecutar = this.GetType().GetMethod(nombreMetodo);
            metodoEjecutar.Invoke(this, null);
        }

        public virtual void CargarDatos()
        {
            DesactivarControles(this, true);
            LimpiarControles(this);
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (VerificarDatosObligatorios(null))
            {
                if (_operacion != TipoOperacion.Eliminar)
                {
                    if (!VerificarSiExisteRegistro())
                    {
                        try
                        {
                            EjecutarOperacion();
                        }
                        catch (Exception ex)
                        {
                            RealizoAlgunaOperacion = false;
                            Mensaje.Mostrar(ex);
                        }
                    }

                    else
                    {
                        Mensaje.Mostrar(this, "Los datos cargados ya existen", TipoMensaje.Aviso);
                        this.Controls[0].Focus();
                    }
                }
                else
                {
                    try
                    {
                        EjecutarOperacion();
                    }
                    catch (Exception ex)
                    {
                        RealizoAlgunaOperacion = false;
                        Mensaje.Mostrar(ex);
                    }
                }
            }
            else
            {
                Mensaje.Mostrar(this,"Los datos marcados con [*] son Obligatorios", TipoMensaje.Aviso);
                this.Controls[0].Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (this._operacion != TipoOperacion.Eliminar)
            {
                if (VerificarSiHayDatosCargadosEnControles(this))
                    if (Mensaje.Mostrar(this,@"Hay datos cargados,  esta seguro que desea limpiar?", TipoMensaje.Pregunta)
                        == DialogResult.OK)
                    {
                        LimpiarControles(this);
                    }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            RealizoAlgunaOperacion = false;
            this.Close();
        }

      

        public virtual void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                case (int)Keys.Enter:
                    EjecutarTeclaEnter();
                    break;
            }
        }

        public virtual void EjecutarTeclaEnter()
        {
            btnEjecutar.PerformClick();
        }


        // ================================================================================================ //
        // =============== Metodos publicos para sobre escribribir en cada formulario de abm ============== //
        // ================================================================================================ //

        public virtual void InsertarRegistro()
        {
        }

        public virtual void ElimnarRegistro()
        {            
        }

        public virtual void ModificarRegistro()
        {
        }

        public virtual bool VerificarSiExisteRegistro()
        {
            return false;
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }
    }
}

