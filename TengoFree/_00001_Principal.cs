using MetroFramework.Forms;
using System;

namespace TengoFree
{
    public partial class _00001_Principal : MetroForm
    {
        
 
        public _00001_Principal()
        {
            InitializeComponent();

        }


        private void mtNewTicket_Click(object sender, EventArgs e)
        {
            // open CreateTicket Form
            var form = Composition.Resolve<_00002_NuevoTicket>();
            form.ShowDialog(this);
        }

        private void mtListadoTickets_Click(object sender, EventArgs e)
        {
            // open LookupTikcet Form
            var form = Composition.Resolve<_00003_ListadoTickets>();
            form.ShowDialog(this);
        }
    }
}
