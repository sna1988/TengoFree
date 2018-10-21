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
    public partial class _00003_ListadoTickets : MetroForm
    {
        private readonly ITicketServices _ticketServices;
        public _00003_ListadoTickets()
        {

            InitializeComponent();
            _ticketServices = Composition.Resolve<ITicketServices>();
            
            Refresh();
        }


        /// <summary>
        /// Load Grid with tickets from db.
        /// </summary>
        public void Refresh()
        {
            // Get tickets from Db.
            dgvTickets.DataSource = _ticketServices.GetTickets();

            // Format grid.
            FormatearGrilla(dgvTickets);
        }


        /// <summary>
        /// Set format to datagridView hidding all columns and then showing only de ones that user should see.
        /// </summary>
        /// <param name="dgv"> datagridview to format.</param>
        public  void FormatearGrilla(DataGridView dgv)
        {

            // Set Visible Mode for columns to false.
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgv.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


            // Format Creation Date Column
            dgv.Columns["CreationDate"].Visible = true;
            dgv.Columns["CreationDate"].Width = 100;
            dgv.Columns["CreationDate"].HeaderText = "Fecha";
            dgv.Columns["CreationDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["CreationDate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["CreationDate"].ReadOnly = true;

            // Format Number Column
            dgv.Columns["Number"].Visible = true;
            dgv.Columns["Number"].Width = 80;
            dgv.Columns["Number"].HeaderText = "Ticket N°";
            dgv.Columns["Number"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["Number"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["Number"].ReadOnly = true;

            // Format Ticket Area Column
            dgv.Columns["TicketArea"].Visible = true;
            dgv.Columns["TicketArea"].Width = 100;
            dgv.Columns["TicketArea"].HeaderText = "Area";
            dgv.Columns["TicketArea"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["TicketArea"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["TicketArea"].ReadOnly = true;

            // Format Complete Name Column
            dgv.Columns["CompleteName"].Visible = true;
            dgv.Columns["CompleteName"].Width = 180;
            dgv.Columns["CompleteName"].HeaderText = "Nombre Completo";
            dgv.Columns["CompleteName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["CompleteName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["CompleteName"].ReadOnly = true;

            // Format Email Column
            dgv.Columns["Email"].Visible = true;
            dgv.Columns["Email"].Width = 150;
            dgv.Columns["Email"].HeaderText = "Email";
            dgv.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["Email"].ReadOnly = true;

            // Format Telephone Column
            dgv.Columns["Telephone"].Visible = true;
            dgv.Columns["Telephone"].Width = 100;
            dgv.Columns["Telephone"].HeaderText = "Teléfono";
            dgv.Columns["Telephone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["Telephone"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["Telephone"].ReadOnly = true;

            // Format Description Column
            dgv.Columns["Description"].Visible = true;
            dgv.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Description"].HeaderText = "Descripción";
            dgv.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["Description"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["Description"].ReadOnly = true;
        }
    }
}
