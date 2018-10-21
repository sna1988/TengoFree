using MetroFramework.Forms;
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

namespace TengoFree
{
    public partial class _00001_Principal : MetroForm
    {
        
        private readonly ITicketServices _ticketServices;
        public _00001_Principal()
        {
            InitializeComponent();

            try
            {
                _ticketServices = Composition.Resolve<ITicketServices>();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

         
            
        }

        private void mtNewTicket_Click(object sender, EventArgs e)
        {
            var form = Composition.Resolve<_00002_NuevoTicket>();
            form.ShowDialog(this);
        }

        private void mtListadoTickets_Click(object sender, EventArgs e)
        {
            var form = Composition.Resolve<_00003_ListadoTickets>();
            form.ShowDialog(this);
        }
    }
}
