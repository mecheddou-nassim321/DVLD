using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 1. Appliquer le fond noir sur le conteneur MDI principal
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient mdiClient)
                {
                    mdiClient.BackColor = Color.Black;
                }
            }

            // 2. Événement pour ajuster le centrage au redimensionnement de la fenêtre
            this.Resize += Form1_Resize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterLogo();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterLogo();
        }

        private void CenterLogo()
        {
            if (pictureBox1 != null)
            {
                // Positionne l'image exactement au centre de la zone MDI (sous le menu)
                pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
                pictureBox1.Top = (this.ClientSize.Height - pictureBox1.Height + menuStrip1.Height) / 2;
            }
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePeopleFrm managePeopleFrm=new ManagePeopleFrm();
            managePeopleFrm.Show();
        }
    }
}