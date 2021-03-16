using eDentalClinic.Model;
using eDentalClinic.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentalClinic.WinUI.Clients
{
    public partial class frmClientsData : Form
    {
        private readonly APIService _userService = new APIService("Users");
        public frmClientsData()
        {
            InitializeComponent();
        }

        private async void FrmClientsData_Load(object sender, EventArgs e)
        {
            var result = await _userService.GetAll<List<Client>>(null);
            dgvClients.AutoGenerateColumns = false;
            dgvClients.DataSource = result;
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            UserSearchRequest request = new UserSearchRequest
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };
            var result = await _userService.GetAll<List<Client>>(request);
            dgvClients.AutoGenerateColumns = false;
            dgvClients.DataSource = result;
            if(result.Count == 0)
            {
                MessageBox.Show("There are no results for this search", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvClients.SelectedRows[0].Cells[0].Value;
            frmClientDetails frm = new frmClientDetails(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
