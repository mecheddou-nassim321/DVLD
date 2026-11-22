using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buisness_Layer;
using System.IO;

namespace DVLD
{
    public  partial class CtrlPersoneAdd: UserControl
    {
        ClsPeople people = new ClsPeople();
        private int _number = 0;
        public  event Action  SentDataToPrincipaleFrm;
        public event Action sendEventForClose;

        enum enumMode { AddPerspne=0,UpdatePersone=1};
        enumMode mode;
        public CtrlPersoneAdd()
        {
            InitializeComponent();
            
        }
        public CtrlPersoneAdd(int number)
        {
            InitializeComponent();
            if (number == 0)
            {
                _number = number;
                mode = enumMode.AddPerspne;
                return;
            }
            else if (number == 1)
            {
                _number = number;
                mode = enumMode.UpdatePersone;
                lblTitle.Text = "Update Persone";
                return;
            }
            
        }
        public CtrlPersoneAdd(ClsPeople p)
        {
            InitializeComponent();
            if (p != null)
            {
                people = p;
                _number = 1;
                mode = enumMode.UpdatePersone;
            }
        }
        private void _addPeople()
        {
            people.NationalNO = txtNationalNo.Text.Trim();
            people.FirstName = txtFirstName.Text.Trim();
            people.SecondName = txtSecondName.Text.Trim();
            people.ThirdName = txtThirdName.Text.Trim();
            people.LastName = txtLastName.Text.Trim();
            people.DateOfBirth = dtpDateOfBirth.Value;

            // Gender
            if (rbMale.Checked)
            {
                people.Gendor = 0;
            }
            else if (rbFemale.Checked)
            {
                people.Gendor = 1;
            }

            people.Email = txtEmail.Text.Trim();
            people.Address = txtAddress.Text.Trim();
            people.Phone = txtPhone.Text.Trim();

            // Country
            if (cbCountry.SelectedValue != null)
            {
                people.NationalCountryID =
                    Convert.ToInt32(cbCountry.SelectedValue);
            }

            // Profile image
            people.ImagePath = pbProfileImage.ImageLocation;

            // Save person
            if (people.save())
            {
                lblPersonIDValue.Text = people.PersonID.ToString();
                lblTitle.Text = "Update Persone";

                MessageBox.Show(
                    "Person saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                string uniqueId = Guid.NewGuid().ToString();
                string ImageName = Path.GetFileName(pbProfileImage.ImageLocation);
                string SourceFile = @"C:\Users\info\Pictures\Saved Pictures\" + ImageName;
                string destinationFolder = @"D:\store_Images";
                string Extension = Path.GetExtension(SourceFile);
                string destinationFile = Path.Combine(destinationFolder, uniqueId + Extension);
                if (File.Exists(SourceFile))
                {
                    File.Copy(SourceFile, destinationFile, true);
                }


                SentDataToPrincipaleFrm?.Invoke();

            }

        }
        private void _UpdatePeople()
        {
              



                people.NationalNO = txtNationalNo.Text.Trim();
                people.FirstName = txtFirstName.Text.Trim();
                people.SecondName = txtSecondName.Text.Trim();
                people.ThirdName = txtThirdName.Text.Trim();
                people.LastName = txtLastName.Text.Trim();
                people.DateOfBirth = dtpDateOfBirth.Value;

                // Gender
                if (rbMale.Checked)
                {
                    people.Gendor = 0;
                }
                else if (rbFemale.Checked)
                {
                    people.Gendor = 1;
                }

                people.Email = txtEmail.Text.Trim();
                people.Address = txtAddress.Text.Trim();
                people.Phone = txtPhone.Text.Trim();

                // Country
                if (cbCountry.SelectedValue != null)
                {
                    people.NationalCountryID =
                        Convert.ToInt32(cbCountry.SelectedValue);
                }

                // Profile image
                people.ImagePath = pbProfileImage.ImageLocation;

            // Save person
                    
                   
                   
                   
           
                if (people.save())
                {
                    lblPersonIDValue.Text = people.PersonID.ToString();
                    lblTitle.Text = "Update Person";

                    MessageBox.Show("Person updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
          
                    string uniqueId = Guid.NewGuid().ToString();
                    string ImageName = Path.GetFileName(pbProfileImage.ImageLocation);
                    string SourceFile = @"C:\Users\info\Pictures\Saved Pictures\" + ImageName;
                    string destinationFolder = @"D:\store_Images";
                    string Extension = Path.GetExtension(SourceFile);
                    string destinationFile = Path.Combine(destinationFolder, uniqueId + Extension);
                    if (File.Exists(SourceFile))
                    {
                        File.Copy(SourceFile, destinationFile, true);
                    }
                
            }



        
        

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (people==null) {

                _addPeople();
                return;
            }
             if(people != null)
            {
                _UpdatePeople();
                return;
            }

             else
            {
                MessageBox.Show(
                       ClsPeople.ErrorMessage(),
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;

            }
        }
        public void LoadDataByPeopleInformartion(ClsPeople p)
        {
            if (p != null)
            {
                txtFirstName.Text = p.FirstName;
                txtSecondName.Text = p.SecondName;
                txtThirdName.Text=p.ThirdName;
                txtLastName.Text= p.LastName;
                txtNationalNo.Text = p.NationalNO;
                dtpDateOfBirth.Value = p.DateOfBirth;
                rbMale.Checked = (p.Gendor == 0);
                rbFemale.Checked = (p.Gendor == 1);
                int NaionalContryID = cbCountry.SelectedIndex;
                cbCountry.SelectedIndex = NaionalContryID;
                txtAddress.Text = p.Address;
              lblPersonIDValue.Text = p.PersonID.ToString();
             
            
              
                pbProfileImage.Image = Image.FromFile(p.ImagePath);
                lblTitle.Text = "Update Persone";
            }
        }

        public void LoadData()
        {
            DataTable dt = ClsCounteries.CountryNameList();

            cbCountry.DataSource = null;

            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
            cbCountry.DataSource = dt;

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            
          pbProfileImage.Image = Image.FromStream(new MemoryStream(Properties.Resources.Male_512));
        }
        private void CtrlPersoneAdd_Load(object sender, EventArgs e)
        {
            LoadData();

        }


        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            sendEventForClose?.Invoke();
       


        }

        private void txtNationalNo_TextChanged(object sender, EventArgs e)
        {
            if (ClsPeople.IsExsisit_People(txtNationalNo.Text))
            {
                errorProvider1.SetError(txtNationalNo, "enter another NationalNO");
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, "");
            }
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                pbProfileImage.Image = Image.FromStream(new MemoryStream(Properties.Resources.Male_512));
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                pbProfileImage.Image= Image.FromStream(new MemoryStream(Properties.Resources.Female_512));   
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!(txtEmail.Text.Contains("@")))
            {
                errorProvider1.SetError(txtEmail, "fix your email");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Profile Image";
                openFileDialog.Filter =
                    "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbProfileImage.ImageLocation = openFileDialog.FileName;
                    RemoveImage.Visible = true;
                }
            }

        }

        private void RemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbProfileImage.ImageLocation = null;
            pbProfileImage.Image = null;
            RemoveImage.Visible = false;

        }

        private void gbPersonInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
