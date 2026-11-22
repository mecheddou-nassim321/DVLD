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
    public partial class AddEditPersone : Form
    {
        // Pas besoin de dupliquer _p, le User Control gère son propre objet 'people'
        private CtrlPersoneAdd ctrlPersoneAdd;
        private ClsPeople people=new ClsPeople();

        // Constructeur par défaut (Mode Ajout)
        public AddEditPersone()
        {
            InitializeComponent();
            ctrlPersoneAdd = new CtrlPersoneAdd(0); // 0 = Add
            SetupUserControl();
        }

        // Constructeur avec l'objet ClsPeople (Mode Update)
        public AddEditPersone(ClsPeople p)
        {
            InitializeComponent();

            // On passe l'objet directement au constructeur du User Control
          //ctrlPersoneAdd = new CtrlPersoneAdd(p);
         

            if (p != null)
            {
                //ctrlPersoneAdd1.LoadDataByPeopleInformartion(p);
                people = p;
            }
          

          //  SetupUserControl();
        }

        // Constructeur avec un entier (0 pour Add, 1 pour Update)
        public AddEditPersone(int number)
        {
            InitializeComponent();
            ctrlPersoneAdd = new CtrlPersoneAdd(number);
            SetupUserControl();
        }

        private void SetupUserControl()
        {
            // Nettoyer les contrôles du designer s'il y en a un en trop
            this.Controls.Clear();

            ctrlPersoneAdd.Dock = DockStyle.Fill;
            ctrlPersoneAdd.sendEventForClose += () => this.Close();

            this.Controls.Add(ctrlPersoneAdd);
        }

        private void AddEditPersone_Load(object sender, EventArgs e)
        {
            // Tout est géré dans les constructeurs
        }

        private void ctrlPersoneAdd1_Load(object sender, EventArgs e)
        {
            if (people != null)
            {
                ctrlPersoneAdd1.LoadDataByPeopleInformartion(people);
            }
            else
            {
                MessageBox.Show("the data not loaded ");
            }
        }
    }
}