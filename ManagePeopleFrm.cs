using Buisness_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ManagePeopleFrm: Form
    {
        public ManagePeopleFrm()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            dgvPeople.DataSource = ClsPeople.PeopleList();
            lblRecordsCount.Text = ClsPeople.ReturnedNumberOfReccord().ToString();
        }

        private void ManagePeopleFrm_Load(object sender, EventArgs e)
        {
            loadData();
            
        }

        private void lblRecordsCount_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddEditPersone addEditPersone=new AddEditPersone();
            addEditPersone.Show();
        }
    }
}
