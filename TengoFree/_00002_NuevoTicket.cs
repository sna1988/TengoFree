using Aplication.Enums;
using Aplication.Interfaces.Email;
using Aplication.Interfaces.Ticket;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using TengoFree.FormFunctions;

namespace TengoFree
{
    public partial class _00002_NuevoTicket : MetroForm
    {
        private readonly ITicketServices _ticketServices;
        private readonly IEmailServices _emailServices;
        ErrorProvider errorProvider;
        public _00002_NuevoTicket()
        {
            InitializeComponent();
            _ticketServices = Composition.Resolve<ITicketServices>();
            _emailServices = Composition.Resolve<IEmailServices>();

            LoadComboBox();
            errorProvider = new ErrorProvider();
        }

        /// <summary>
        /// Load Combo Box with Values from Enum TicketArea
        /// </summary>
        private void LoadComboBox()
        {
            cmbArea.DataSource = EnumInitialization.AreaInitialization();
            cmbArea.DisplayMember = "DisplayName";
            cmbArea.ValueMember = "EnumValue";
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //Check Required fields. True: all required fields has values.
                if (Validacion.VerificarDatosObligatorios(new object[] { txtNombre, txtApellido, cmbArea, txtTelefono, txtEmail, txtDescripcion }))
                {
                    // check email format. True: email has the correct format.
                    if (Validacion.ValidarEmail(txtEmail.Text,errorProvider,txtEmail))
                    {
                        // Create Ticket.
                        var ticket = _ticketServices.Create(txtNombre.Text, txtApellido.Text, ((TicketArea)((int)cmbArea.SelectedValue)), txtTelefono.Text, txtEmail.Text, txtDescripcion.Text);

                        // Send ticket by mail.
                        _emailServices.SendMail(ticket);


                        MetroFramework.MetroMessageBox.Show(this, "Su ticket se generó con éxito", "Confirmación:",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);

                        //Clean Controls in form.
                        FormHelpers.LimpiarControles(this);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "El Email no posee un formato válido.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MetroMessageBox.Show(this, "Los datos marcados * son obligatorios.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ocurrió un error grave al intentar guardar su Ticket.\n Póngase en contacto con el administrador.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent User to insert Leter
            Validacion.NoLetras(sender, e);

            // Prevent user to insert injection char
            Validacion.NoInyeccion(sender, e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent User to insert injection char
            Validacion.NoInyeccion(sender, e);

            // Prevent User to insert number
            Validacion.NoNumeros(sender, e);

            // Prevent User to insert symbol char
            Validacion.NoSimbolos(sender, e);
        }
    }
}
