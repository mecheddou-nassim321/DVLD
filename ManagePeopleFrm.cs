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
        private DataTable dt=new DataTable();
        public ClsPeople p=new ClsPeople();
        public ManagePeopleFrm()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                initialitaionDataGridView();
                return;
            }

            dt = ClsPeople.GetAllPepole(cbFilterBy.Text, txtFilterValue.Text);

            if (dt != null)
            {
                dgvPeople.DataSource = null; // Réinitialiser brièvement la source pour forcer le rafraîchissement
                dgvPeople.DataSource = dt;
                lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
            }
        }

        private void ManagePeopleFrm_Load(object sender, EventArgs e)
        {
            initialitaionDataGridView();
         
          //  AddEditPersone addEditPersone = new AddEditPersone();
           // addEditPersone.Show();
            //.ctrlPersoneAdd1.SentDataToPrincipaleFrm+= loadData;



        }

        private void lblRecordsCount_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddEditPersone addEditPersone=new AddEditPersone();
            addEditPersone.Show();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si l'utilisateur choisit "None", on réinitialise la grille et on cache ou vide le champ de texte
            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Visible = false;
                txtFilterValue.Text = string.Empty;
                initialitaionDataGridView();
            }
            else
            {
                txtFilterValue.Visible = true;
                txtFilterValue.Text = string.Empty;
                txtFilterValue.Focus();
            }
        }







        void initialitaionDataGridView()
        {
            // Charger la liste complète des personnes
            DataTable dtPeople = ClsPeople.PeopleList();
            dgvPeople.DataSource = dtPeople;

            // Afficher directement le nombre de lignes à partir de la DataTable 
            // (évite un appel supplémentaire à la base de données)
            if (dtPeople != null)
            {
                lblRecordsCount.Text = dtPeople.Rows.Count.ToString();
            }
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                initialitaionDataGridView();
                return; 
            }

         
            loadData();
        }

        private void editItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dgvPeople.CurrentRow.Cells["PersonID"].Value);

            p=ClsPeople.Get_People_ByID(PersonID);
            
            AddEditPersone editPersone=new AddEditPersone(p);

            
            editPersone.Show();
        }

        private void contextMenuPeople_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dgvPeople.CurrentRow.Cells["PersonID"].Value);

            p = ClsPeople.Get_People_ByID(PersonID);
            DialogResult result = MessageBox.Show(
        "Are you sure you want to delete this person?",
        "Confirm Deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (p.DeletePepoleByPersoneID(PersonID))
                    {
                        MessageBox.Show(
                    "The person has been deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                        initialitaionDataGridView();
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(
                "An error occurred while deleting: " + ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
            }
        }

        private void showDetailsItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dgvPeople.CurrentRow.Cells["PersonID"].Value);

            p = ClsPeople.Get_People_ByID(PersonID);
            frmShowPersonInfo frmShowPersonInfo=new frmShowPersonInfo(p);
            frmShowPersonInfo.ShowDialog();
        }

        private void addNewPersonItem_Click(object sender, EventArgs e)
        {
            AddEditPersone addEditPersone = new AddEditPersone();
            addEditPersone.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
