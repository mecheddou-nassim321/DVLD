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

namespace DVLD
{
    public partial class CtrlPersoneAdd: UserControl
    {
        ClsPeople people = new ClsPeople();
        private int _number = 0;
        enum enumMode { AddPerspne=0,UpdatePersone=1};
        enumMode mode;
        public CtrlPersoneAdd()
        {
            InitializeComponent();
        }
        public CtrlPersoneAdd(int number)
        {
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
                return;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_number == 0)
            {
                people.NationalNO = txtNationalNo.Text;
                people.FirstName = txtFirstName.Text;
                people.SecondName = txtSecondName.Text;
                people.ThirdName = txtThirdName.Text;
                people.LastName = txtLastName.Text;
                people.DateOfBirth = dtpDateOfBirth.Value;
                if (rbMale.Checked)
                {
                    people.Gendor = 0;
                }
                else
                {
                    people.Gendor = 1;
                }
                people.Email = txtEmail.Text;
                people.Address = txtAddress.Text;
                people.Phone = txtPhone.Text;
                people.Email = txtEmail.Text;
                //pepole.ationalCountryID=la fonction pour récupére le ID de le pays;
                people.ImagePath = pbProfileImage.ImageLocation;
                if (people.save())
                {
                    MessageBox.Show("The Pepole saved Seccessfully");
                }
                else
                {
                    MessageBox.Show("the saved is Faild");
                }


            }
        }

        private void CtrlPersoneAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
