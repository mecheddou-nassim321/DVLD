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
    public partial class ctrlPersonCard: UserControl
    {
        public  ClsPeople people = new ClsPeople();
        public ctrlPersonCard()
        {
            InitializeComponent();

        }
       
        public void LoadData(ClsPeople p)
        {
            if (p == null)
                return;
            people = p;
            lblPersonID.Text=p.PersonID.ToString();
            lblAddress.Text=p.Address.ToString();
            lblNationalNo.Text=p.NationalNO.ToString();
            lblFullName.Text = p.FirstName + " " + p.LastName;
            lblDateOfBirth.Text=p.DateOfBirth.ToString();   
            lblGendor.Text=p.Gendor.ToString();
            lblPhone.Text=p.Phone.ToString();
            lblEmail.Text=p.Email.ToString();
            string countryName = ClsCounteries.CountryNameByID(p.NationalCountryID);
            lblCountry.Text = countryName;
            if (!string.IsNullOrEmpty(p.ImagePath) && File.Exists(p.ImagePath))
            {
                pbPersonImage.Image = Image.FromFile(p.ImagePath);
            }
            else
            {
                pbPersonImage.Image = null; 
            }


        }
        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }

        private void pbPersonImage_Click(object sender, EventArgs e)
        {

        }
    }
}
