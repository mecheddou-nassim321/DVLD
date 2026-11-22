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
    
    public partial class frmShowPersonInfo: Form
    {
        private ClsPeople _People=new ClsPeople();
        public frmShowPersonInfo(ClsPeople p)
        {
            InitializeComponent();
            _People = p;

            
            
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadData(_People);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
