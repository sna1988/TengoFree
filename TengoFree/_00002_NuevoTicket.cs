﻿using Aplication.Enums;
using MetroFramework;
using MetroFramework.Forms;
using Services.Core.Email;
using Services.Core.Ticket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            cmbArea.DataSource = EnumInitialization.AreaInitialization();
            cmbArea.DisplayMember = "DisplayName";
            cmbArea.ValueMember = "EnumValue";
            errorProvider= new ErrorProvider();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacion.VerificarDatosObligatorios(new object[] { txtNombre, txtApellido, cmbArea, txtTelefono, txtEmail, txtDescripcion }))
                {
                    if (Validacion.ValidarEmail(txtEmail.Text,errorProvider,txtEmail))
                    {
                        var ticket = _ticketServices.Create(txtNombre.Text, txtApellido.Text, ((TicketArea)((int)cmbArea.SelectedValue)), txtTelefono.Text, txtEmail.Text, txtDescripcion.Text);
                        _emailServices.SendMail(ticket);
                        MetroFramework.MetroMessageBox.Show(this, "Su ticket se generó con éxito", "Confirmación:",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
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
            Validacion.NoLetras(sender, e);
            Validacion.NoInyeccion(sender, e);
        }
    }
}